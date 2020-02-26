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
    public partial class Form4 : Form
    {
        StudentEntities test;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtStudentID.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel.Enabled = true;
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
