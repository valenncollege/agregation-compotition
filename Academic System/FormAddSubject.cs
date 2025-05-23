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
    public partial class FormAddSubject : Form
    {
        public FormAddSubject()
        {
            InitializeComponent();
        }
        FormMenu formUtama;
        private void comboBoxAssignTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTeacher = (Teacher)comboBoxAssignTeacher.SelectedValue;
        }
        Teacher SelectedTeacher;
        private void FormAddSubject_Load(object sender, EventArgs e)
        {
            formUtama = (FormMenu)this.Owner;
            comboBoxAssignTeacher.DataSource = formUtama.listTeacher;
            comboBoxAssignTeacher.DisplayMember = "Name";
        }
        Subject newSubject;
        List<Subject> listSubject = new List<Subject>();
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            listBoxAssignedTeacher.Items.Clear();
            newSubject.ListTeacher.Add(SelectedTeacher);
            
            listBoxAssignedTeacher.Items.AddRange(newSubject.DisplaySubject().Split('\n'));
        }

        private void buttonSubjectSave_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            string id = textBoxSubjectID.Text;
            string name = textBoxSubjectName.Text;
            int credit = int.Parse(textBoxSubjectCredit.Text);
            newSubject = new Subject(id, name, credit);
            listBoxDisplay.Items.AddRange(newSubject.DisplaySubject().Split('\n'));

        }
    }
}
