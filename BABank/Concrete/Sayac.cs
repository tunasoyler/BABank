using BABank.Concrete;

namespace BABank
{
    public class Sayac : ISayac
    {
        public Sayac()
        {
            VipMusteriSayisi = 0;
            BireyselMusteriSayisi = 0;
            GiseMusteriSayisi = 0;
        }
        public int VipMusteriSayisi { get; set; }
        public int GiseMusteriSayisi { get; set; }
        public int BireyselMusteriSayisi { get; set; }

        public void GisedenIsiBitenNumaraAl(INumara numara)
        {
            if (numara is VipNumarasi)
            {
                VipMusteriSayisi++;
            }
            else if(numara is BireyselNumara)
            {
                BireyselMusteriSayisi++;
            }
            else if(numara is GiseNumarasi)
            {
                GiseMusteriSayisi++;
            }
        }
    }
}