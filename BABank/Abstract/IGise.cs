using BABank.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Abstract
{
    public interface IGise
    {
        //KuyrukBenmüsaitim
        //SayacIsimBitti
        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacİsimBitti;
        INumara islemYapilanNumara { get;set;}
        void IslemYap();
        void Kontrol(object sender);
    }
}
