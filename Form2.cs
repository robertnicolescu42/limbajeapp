using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace limbajeapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void emailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.limbajeDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'limbajeDataSet.phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.limbajeDataSet.phones);
            // TODO: This line of code loads data into the 'limbajeDataSet.emails' table. You can move, or remove it, as needed.
            this.emailsTableAdapter.Fill(this.limbajeDataSet.emails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=limbaje;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "truncate table phones truncate table emails";
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();

        }
    }
}
