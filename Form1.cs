using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace limbajeapp
{
    public partial class Form1 : Form
    {
        string filename;

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=limbaje;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();

        }

        public void getEmails(string filePath, string outputPath)
        {
            string data = File.ReadAllText(filePath);

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            //cuvant de dimensiune > 1 cu simboluri sau numere optionale + @ + cuvant de dimensiune > 1 cu simboluri sau numere optionale + . + cuvant de dimensiune > 1 cu simboluri sau numere optionale
            MatchCollection emailMatches = emailRegex.Matches(data);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);

                string currentmail = emailMatch.Value.ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into emails values ('" + currentmail + "')";
                cmd.ExecuteNonQuery();
                con.Close();


            }
            //store to file
            File.WriteAllText(outputPath, sb.ToString());
        }

        public void getPhones(string filePath, string outputPath)
        {
            string data = File.ReadAllText(filePath);

            //Regex emailRegex = new Regex(@"(\+4)?07\d{8}");
            Regex emailRegex = new Regex(@"(\+4)?0 ?(\d{3} ?){2}\d{3}");
            // numarul poate incepe cu +4 (e optional), dar va incepe sigur cu 0 urmat de un spatiu optional, o grupare de 3 cifre cu spatiu optional (de 2 ori), apoi inca 3 cifre
            MatchCollection emailMatches = emailRegex.Matches(data);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);

                string currentphone = emailMatch.Value.ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into phones values ('" + currentphone + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            File.WriteAllText(outputPath, sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open HTML File";
            theDialog.Filter = "HTML files|*.html";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                filename = theDialog.FileName;
                
                string content = File.ReadAllText(filename);
                richTextBox1.Text = content;

                getEmails(filename, "C:\\Users\\rober\\Desktop\\outputemails.txt");
                getPhones(filename, "C:\\Users\\rober\\Desktop\\outputphones.txt");
            }

            Form form2 = new Form2();
            form2.ShowDialog();

        }

        private void emailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.limbajeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'limbajeDataSet.emails' table. You can move, or remove it, as needed.
            this.emailsTableAdapter.Fill(this.limbajeDataSet.emails);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
