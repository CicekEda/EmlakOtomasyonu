using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMLAK
{
  public  class cKullaniciGirisi
    {
        private string _kullaniciAdi;
        private string _kullaniciSifre;

        #region Properties
        public string KullaniciAdi
        {
            get
            {
                return _kullaniciAdi;
            }

            set
            {
                _kullaniciAdi = value;
            }
        }

        public string KullaniciSifre
        {
            get
            {
                return _kullaniciSifre;
            }

            set
            {
                _kullaniciSifre = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public bool KullaniciGiris(cKullaniciGirisi a)
        {
            bool sonuc = false;
            conn.Open();
            SqlCommand comm = new SqlCommand("Select * from Kullanici where KullaniciAdi=@Adi and Sifre=@Sifre ", conn);
            comm.Parameters.Add("@Adi", SqlDbType.VarChar).Value = a.KullaniciAdi.Trim();
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = a.KullaniciSifre.Trim();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);

          while (dt.Rows.Count > 0)
            {
                sonuc = true;
            }
            conn.Close();
            return sonuc;

        }
    }
}
