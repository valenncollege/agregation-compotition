using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online_Game
{
    public class Player
    {
        private string id;
        private string name;
        private Weapon myWeapon;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Weapon MyWeapon { get => myWeapon; private set => myWeapon = value; }

        public Player(string pId, string pName)
        {
            this.Id = pId;
            this.Name = pName;
          
        }

        public void AddWeapon(string inputId, string inputName)
        {
            this.MyWeapon = new Weapon(inputId, inputName);
            
        }
        public string Display()
        {
            string result = "ID : " + this.Id + "\n" +
                "Name : " + this.Name + "\n";
            return result;
        }
        public string DisplayWeapon()
        {
            string result = "ID : " + this.Id + "\n" +
                "Name : " + this.Name + "\n" +
                "Weapon : " + this.MyWeapon.Name + "\n" +
                "Weapon ID : " + this.MyWeapon.Id + "\n";
            return result;
        }
    }
}