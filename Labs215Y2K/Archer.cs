using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Archer: Unit
    {
        public Archer(string class1, int strength, int dextericy, int intelegent, int constitution)
        {
            this.Class = class1;
            this.Strength = strength;
            this.Dextericy = dextericy;
            this.Intelegent = intelegent;
            this.Constitution = constitution;
        }
    }
}
