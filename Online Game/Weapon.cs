using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online_Game
{
    public class Weapon
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Weapon(string pId, string pName)
        {
            this.Id = pId;
            this.Name = pName;
        }
    
    }
}