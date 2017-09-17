using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLAK
{
    class cKayit
    {
        private int _ilanID;
        private double _fiyat;
        private string _emlakSahibi;
        private int _metrekare;
        private string _fotograf;
        private string _il;
        private string _adres;
        private string _eklenmeTarihi;
        private string _aciklama;

        #region properties
        public int IlanID
        {
            get
            {
                return _ilanID;
            }

            set
            {
                _ilanID = value;
            }
        }

        public double Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }

        public string EmlakSahibi
        {
            get
            {
                return _emlakSahibi;
            }

            set
            {
                _emlakSahibi = value;
            }
        }

        public int Metrekare
        {
            get
            {
                return _metrekare;
            }

            set
            {
                _metrekare = value;
            }
        }

        public string Il
        {
            get
            {
                return _il;
            }

            set
            {
                _il = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        public string EklenmeTarihi
        {
            get
            {
                return _eklenmeTarihi;
            }

            set
            {
                _eklenmeTarihi = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }

        public string Fotograf
        {
            get
            {
                return _fotograf;
            }

            set
            {
                _fotograf = value;
            }
        }
        #endregion


        //private void FotografKaydet()
        //{
        //    byte[] data = File.ReadAllBytes("C:\\Users\\Nagihan-Laptop\\Downloads\\EMLAK (3)\\EMLAK\\EMLAK\\image");
        //    SqlCommand cmd = new SqlCommand("insert into Isyeri(Fotograf) values (@binary)", conn);
        //    cmd.Parameters.AddWithValue("binary", data);
        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}
    }
}
