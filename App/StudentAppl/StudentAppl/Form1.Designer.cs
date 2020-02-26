namespace StudentAppl
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Plum;
            this.btnNew.Location = new System.Drawing.Point(179, 184);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(181, 41);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Adauga un student nou";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Plum;
            this.btnEdit.Location = new System.Drawing.Point(179, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(181, 42);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Actualizeaza datele unui student";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.BackColor = System.Drawing.Color.Plum;
            this.txtDelete.Location = new System.Drawing.Point(179, 284);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(181, 40);
            this.txtDelete.TabIndex = 7;
            this.txtDelete.Text = "Sterge un student";
            this.txtDelete.UseVisualStyleBackColor = false;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.Color.Plum;
            this.btnCautare.Location = new System.Drawing.Point(179, 231);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(181, 38);
            this.btnCautare.TabIndex = 8;
            this.btnCautare.Text = "Vezi tabela si cauta un student";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentAppl.Student);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(StudentAppl.Student);
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(StudentAppl.Student);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.richTextBox2.Location = new System.Drawing.Point(180, 148);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(180, 30);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "Alege o optiune:";
            this.richTextBox2.ZoomFactor = 2F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 415);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

