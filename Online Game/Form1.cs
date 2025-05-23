using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<Player> listPlayer = new BindingList<Player>();
        private void buttonPlayerSave_Click(object sender, EventArgs e)
        {
            string id = textBoxPlayerID.Text;
            string name = textBoxPlayerName.Text;
            Player newPlayer = new Player(id, name);
            listBoxDisplay.Items.AddRange(newPlayer.Display().Split('\n'));
            listPlayer.Add(newPlayer);

            
        }
        Player SelectedPlayer;
        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPlayer = (Player)comboBoxPlayer.SelectedValue;
        }

        private void buttonWeaponSave_Click(object sender, EventArgs e)
        {
            string id = textBoxWeaponID.Text;
            string name = textBoxWeaponName.Text;
            SelectedPlayer.AddWeapon(id, name);
            
            listBoxDisplay.Items.AddRange(SelectedPlayer.DisplayWeapon().Split('\n'));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPlayer.DataSource = listPlayer;
            comboBoxPlayer.DisplayMember = "Name";
        }
    }
}
