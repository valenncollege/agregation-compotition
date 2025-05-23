using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academic_System
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public BindingList<Teacher> listTeacher = new BindingList<Teacher>();
        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTeacher formTeacher = new FormAddTeacher();
            formTeacher.Owner = this;
            formTeacher.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSubject formSubject = new FormAddSubject();
            formSubject.Owner = this;
            formSubject.ShowDialog();
        }
    }
}
