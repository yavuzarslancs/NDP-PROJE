using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Proje
{
    class Portakal:Narenciye
    {
        // portakal için ağırlık fonksiyonu oluşturdum

        public void Agirlik()
        {
            // random classından bir değişken üretip aralığını 70-120 aralğıyı yaptım.

            Random rastgele = new Random();
            int agirlik = rastgele.Next(70, 120);
            this.Gram = agirlik;

            // bir tane daha rastgele oluşturup üstte oluşturduğum gramın verimine atadım

            Random r = new Random();
            int siviR = r.Next(30, 70);
            this.islem_Agirligi = (Gram - siviR);

            int atik = 0;

            this.atik = Gram - islem_Agirligi;

        }

        // işlem ağırlığından (verimden) vitamin a hesabı.

        public void vitAhesap()
        {

            vitA = (islem_Agirligi * 9) / 4;

        }

        // işlem ağırlığından (verimden) vitamin c hesabı.

        public void vitChesap()
        {

            vitC = (islem_Agirligi * 9) / 20;

        }

    }
}
