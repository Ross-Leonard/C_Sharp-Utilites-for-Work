namespace Utility_For_Andy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Opkey = new System.Windows.Forms.TextBox();
            this.postnotebutton = new System.Windows.Forms.Button();
            this.startedcheckbox = new System.Windows.Forms.CheckBox();
            this.completecheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.floornotetext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Utility_For_Andy.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.jobTableAdapter = new Utility_For_Andy.DataSet1TableAdapters.JobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 46);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 56);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Type, Scan, or Paste the Operation Key";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Opkey
            // 
            this.Opkey.Location = new System.Drawing.Point(24, 113);
            this.Opkey.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Opkey.Multiline = true;
            this.Opkey.Name = "Opkey";
            this.Opkey.Size = new System.Drawing.Size(360, 171);
            this.Opkey.TabIndex = 0;
            this.Opkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Opkey.TextChanged += new System.EventHandler(this.jobnum_TextChanged);
            // 
            // postnotebutton
            // 
            this.postnotebutton.Location = new System.Drawing.Point(24, 694);
            this.postnotebutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.postnotebutton.Name = "postnotebutton";
            this.postnotebutton.Size = new System.Drawing.Size(362, 44);
            this.postnotebutton.TabIndex = 13;
            this.postnotebutton.Text = "Post Note";
            this.postnotebutton.UseVisualStyleBackColor = true;
            this.postnotebutton.Click += new System.EventHandler(this.postnotebutton_Click);
            // 
            // startedcheckbox
            // 
            this.startedcheckbox.AutoSize = true;
            this.startedcheckbox.Location = new System.Drawing.Point(24, 606);
            this.startedcheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startedcheckbox.Name = "startedcheckbox";
            this.startedcheckbox.Size = new System.Drawing.Size(397, 29);
            this.startedcheckbox.TabIndex = 14;
            this.startedcheckbox.Text = "Set the Status of Operation to \'Started\'";
            this.startedcheckbox.UseVisualStyleBackColor = true;
            // 
            // completecheckbox
            // 
            this.completecheckbox.AutoSize = true;
            this.completecheckbox.Location = new System.Drawing.Point(24, 650);
            this.completecheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.completecheckbox.Name = "completecheckbox";
            this.completecheckbox.Size = new System.Drawing.Size(419, 29);
            this.completecheckbox.TabIndex = 15;
            this.completecheckbox.Text = "Set the Status of Operation to \'Complete\'";
            this.completecheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 108);
            this.button1.TabIndex = 16;
            this.button1.Text = "Click Here to Paste, and to Fill Table below";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // floornotetext
            // 
            this.floornotetext.Location = new System.Drawing.Point(24, 344);
            this.floornotetext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.floornotetext.Multiline = true;
            this.floornotetext.Name = "floornotetext";
            this.floornotetext.Size = new System.Drawing.Size(238, 225);
            this.floornotetext.TabIndex = 17;
            this.floornotetext.TextChanged += new System.EventHandler(this.floornotetext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 763);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Record Updating...0%";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(378, 763);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 38);
            this.progressBar1.TabIndex = 19;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter Floor Notes Below";
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 825);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.floornotetext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.completecheckbox);
            this.Controls.Add(this.startedcheckbox);
            this.Controls.Add(this.postnotebutton);
            this.Controls.Add(this.Opkey);
            this.Controls.Add(this.textBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.JobTableAdapter jobTableAdapter;
        internal System.Windows.Forms.TextBox Opkey;
        private System.Windows.Forms.Button postnotebutton;
        private System.Windows.Forms.CheckBox startedcheckbox;
        private System.Windows.Forms.CheckBox completecheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox floornotetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label label2;
    }
}

