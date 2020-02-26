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
    public partial class Form5 : Form
    {
        StudentEntities test;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {   
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
