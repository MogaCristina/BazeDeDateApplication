using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAppl
{
    public partial class Form3 : Form
    {
        StudentEntities test;
        public Form3()
        {
            InitializeComponent();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtStudentID.Focus();
                Student s = new Student();
                test.Students.Add(s);
                studentBindingSource.Add(s);
                studentBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            test = new StudentEntities();
            studentBindingSource.DataSource = test.Students.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                studentBindingSource.EndEdit();
                test.SaveChangesAsync();
                panel.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentBindingSource.ResetBindings(false);

            }
            this.Close();
        }
    }
}
