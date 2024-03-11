using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Praktica_13._3
{
    internal class Mebel
    {
        private string tip;
        private string color;
        private int ves;
        private int kolv;

        public Mebel(string tip, string color, int ves, int kolv)
        {
            this.tip = tip;
            this.color = color;
            this.ves = ves;
            this.kolv = kolv;
        }

        public string Tip { get; set; }
        public string Color { get; set; }
        public int Ves { get; set; }
        public int Kolv { get;set; }

        public string getTip()
        {
            return tip;
        }
        public string getColor()
        {
            return color;
        }
        public int getVes()
        {
            return ves;
        }
        public int getKolv()
        {
            return kolv;
        }
    }
}


    