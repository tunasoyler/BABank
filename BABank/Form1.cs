using BABank.Abstract;
using BABank.Concrete;
using BABank.Enum;

namespace BABank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static IBank banka;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(IslemTipi.Gise);
            comboBox1.Items.Add(IslemTipi.Bireysel);
        }

        private void btnbankolustur_Click(object sender, EventArgs e)
        {
            banka = new Banka();
            banka.MesaiBaslat(3);
        }

        private void btnmusterigeldi_Click(object sender, EventArgs e)
        {
            IMusteri musteri=new Musteri();
            musteri.IslemTipi = (IslemTipi)comboBox1.SelectedItem;
            musteri.TcNo = textBoxtc.Text;
            musteri.NumaratorBenGeldim += banka.Numarator.NumaraUret;//numarator ben geldim çalıştığında numarator numara üretecek metodu çalışacak
            foreach (IGise gise in banka.Giseler)
            {
                musteri.GiseBenGeldim += gise.Kontrol;
            }

            musteri.NumaraAl();
            banka.Kuyruk.NumaraAtadim += musteri.KontrolEt;
            ListeleriYukle();
        }

        private void ListeleriYukle()
        {
            lstBireysel.DataSource = null;
            lstVip.DataSource = null;
            lstGiseIslem.DataSource = null;
            lstVip.ValueMember = "SiraNumarasi";
            lstVip.DataSource = banka.Kuyruk.VipNumaraListesi;
            lstBireysel.ValueMember = "SiraNumarasi";
            lstBireysel.DataSource = banka.Kuyruk.BireyselNumaraListesi;
            lstGiseIslem.ValueMember = "SiraNumarasi";
            lstGiseIslem.DataSource = banka.Kuyruk.GiseNumaraListesi;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiseOlustur(banka.Giseler);
        }

        private void GiseOlustur(List<IGise> giseler)
        {
            for (int i = 0; i < giseler.Count; i++)
            {
                Button btnMusaitim = new Button();
                btnMusaitim.Text = "Müsait";
                btnMusaitim.Height = 100;
                btnMusaitim.Width = 100;
                btnMusaitim.Click += new EventHandler(musait);
                flowLayoutPanel1.Controls.Add(btnMusaitim);
            }
        }

        private void musait(object? sender, EventArgs e)
        {
            banka.Giseler[0].IslemYap();
        }
    }
}