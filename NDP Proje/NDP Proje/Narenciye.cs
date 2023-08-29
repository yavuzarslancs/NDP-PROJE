using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
    abstract class Narenciye
    {
        // gerekli özellikleri tanıttım

        private int gram { get; set; }
        private int vita { get; set; }
        private int vitc { get; set; }
        private int islemAgirligi { get; set; }
        protected int atik { get; set; }
        public bool sikilabilirlik = true;

        public int Gram
        {
            get { return gram; }
            set { gram = value; }
        }

        public int vitA
        {
            get { return vita; }
            set { vita = value; }
        }

        public int vitC
        {
            get { return vitc; }
            set { vitc = value; }
        }

        public int islem_Agirligi
        {
            get { return islemAgirligi; }
            set { islemAgirligi= value; }
        }

        public int Atik
        {
            get { return atik; }
            set { atik = value; }
        }
    }
}
