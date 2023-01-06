﻿using BABank.Concrete;

namespace BABank
{
    public interface IKuyruk
    {
        event NumaraHaberTipi NumaraAtadim;

        List<INumara> VipNumaraListesi { get;set;}
        List<INumara> BireyselNumaraListesi { get;set;}
        List<INumara> GiseNumaraListesi { get;set;}
        int sayac { get; set; }
        void NumaratordenNumaraAl(INumara numara);
        void GiseyeNumaraGonder(object sender);

    }
}