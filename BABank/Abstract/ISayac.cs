namespace BABank
{
    public interface ISayac
    {
        int VipMusteriSayisi { get;set; }
        int GiseMusteriSayisi { get;set; }
        int BireyselMusteriSayisi { get;set; }
        void GisedenIsiBitenNumaraAl(INumara numara);
    }
}