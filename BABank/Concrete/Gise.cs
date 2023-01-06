using BABank.Abstract;
using BABank.Concrete;

namespace BABank
{
    public class Gise : IGise
    {
        public INumara islemYapilanNumara { get; set; }

        public event HaberTipi KuyrukBenMusaitim;
        public event NumaraHaberTipi SayacİsimBitti;

        public void IslemYap()
        {
            SayacİsimBitti(islemYapilanNumara);
            KuyrukBenMusaitim(this);
        }

        public void Kontrol(object sender)
        {
            IMusteri musteri = (IMusteri)sender;
            if (musteri.Numara == islemYapilanNumara)
            {
                IslemYap();
            }
        }
    }
}