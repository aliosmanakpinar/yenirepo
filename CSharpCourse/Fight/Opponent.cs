using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    internal class Opponent
    {
        public double health;

        public double mana;
        public Opponent(double health)
        {
            this.health = health;
            this.mana = 100;
        }
    }
    
}
