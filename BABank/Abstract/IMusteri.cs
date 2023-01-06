using BABank.Concrete;
using BABank.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Abstract
{
    public interface IMusteri
    {//NumaratorBenGeldim
        //GiseBenGeldim

        event HaberTipi NumaratorBenGeldim;//numarator ben geldim eventini haber tipi isimli delege temsil ediyor.
        event HaberTipi GiseBenGeldim;//bağlama yapmadım.Nesne oluşunca bağlıcam.
        string TcNo { get; set; }
        IslemTipi IslemTipi { get; set; }
        INumara Numara { get; set; }
        void NumaraAl();
        void KontrolEt(INumara numara);
    }
}
