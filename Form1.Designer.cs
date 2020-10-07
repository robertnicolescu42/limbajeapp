namespace limbajeapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.limbajeDataSet = new limbajeapp.limbajeDataSet();
            this.emailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailsTableAdapter = new limbajeapp.limbajeDataSetTableAdapters.emailsTableAdapter();
            this.tableAdapterManager = new limbajeapp.limbajeDataSetTableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.limbajeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "load html file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // limbajeDataSet
            // 
            this.limbajeDataSet.DataSetName = "limbajeDataSet";
            this.limbajeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailsBindingSource
            // 
            this.emailsBindingSource.DataMember = "emails";
            this.emailsBindingSource.DataSource = this.limbajeDataSet;
            // 
            // emailsTableAdapter
            // 
            this.emailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.emailsTableAdapter = this.emailsTableAdapter;
            this.tableAdapterManager.phonesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = limbajeapp.limbajeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(209, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(579, 426);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "open database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 79);
            this.button3.TabIndex = 4;
            this.button3.Text = "close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.limbajeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private limbajeDataSet limbajeDataSet;
        private System.Windows.Forms.BindingSource emailsBindingSource;
        private limbajeDataSetTableAdapters.emailsTableAdapter emailsTableAdapter;
        private limbajeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

