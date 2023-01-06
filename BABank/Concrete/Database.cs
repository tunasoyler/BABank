using BABank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Concrete
{
    class Database : IMusteriDatabaseYoneticisi
    {
        public Database()
        {
            MusteriTcleri = new List<string>() { "1111", "2222", "3333", "4444", "5555" };
        }
        public List<string> MusteriTcleri { get; set; }
        public bool VipMi(string Tc)
        {
            return MusteriTcleri.Contains(Tc);
        }
    }
}
