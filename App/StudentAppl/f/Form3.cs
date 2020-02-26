using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAppl
{
    public partial class Form1 : Form
    {
        StudentEntities test;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtStudentID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            studentBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test.ChangeTracker.Entries()) {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;

                }
            }
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try {
                panel.Enabled = true;
                txtStudentID.Focus();
                Student s = new Student();
                test.Students.Add(s);
                studentBindingSource.Add(s);
                studentBindingSource.MoveLast();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                studentBindingSource.EndEdit();
                test.SaveChangesAsync();
                panel.Enabled = false;


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentBindingSource.ResetBindings(false);

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            test = new StudentEntities();
            studentBindingSource.DataSource = test.Students.ToList();

        }

        private void txtCautare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtCautare.Text))
                {
                    dataGridView.DataSource = studentBindingSource;
                }
                else
                {
                    var query = from o in studentBindingSource.DataSource as List<Student>
                                where o.Nume.Contains(txtCautare.Text)
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
           /* try
            {
                panel.Enabled = true;
                if (MessageBox.Show("Sigur stergi asta ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test.Students.Remove(studentBindingSource.Current as Student);
                    studentBindingSource.RemoveCurrent();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }
    }
}
