using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
     class Urhajo: IComparable
    {
        AirplaneCategory airplan;
        int koltseg;
        int harciEro;
        public int Koltseg
        {
            get
            {
                return koltseg;
            }
            set
            {
                koltseg = value;
            }
        }
        public int HarciEro
        {
            get
            {
                return harciEro;
            }
            set
            {
                harciEro = value;
            }
        }
        public AirplaneCategory Airplane
        {
            get
            {
                return airplan;
            }
            set
            {
                airplan = value;
            }
        }
        public Urhajo(int koltseg, int harciEro, AirplaneCategory airplan)
        {
            this.koltseg = koltseg;
            this.harciEro = harciEro;
            this.airplan = airplan;

        }

        public int CompareTo(object obj)
        {
            if (this.koltseg < (obj as Urhajo).koltseg)
            {
                return koltseg;
            }
            else
            {
                return (obj as Urhajo).koltseg;
            }
        }
    }
}
