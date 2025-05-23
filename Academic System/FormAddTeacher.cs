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
    public partial class FormAddTeacher : Form
    {
        public FormAddTeacher()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void buttonTeacherSave_Click(object sender, EventArgs e)
        {
            string name = textBoxTeacherName.Text;
            string id = textBoxTeacherID.Text;
            Teacher newTeacher = new Teacher(name, id);
            formUtama.listTeacher.Add(newTeacher);
            listBoxAssignedTeacher.Items.AddRange(newTeacher.DisplayTeacher().Split('\n'));
        }

        private void FormAddTeacher_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
        }
    }
}
