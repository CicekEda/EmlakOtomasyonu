using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMLAK
{
   public class cMusteriSatici
    {
        #region Members
        private int _musteriSaticiID;
        private string _musteriSaticiAd;
        private string _musteriSaticiSoyad;
        private string _telefon;
        private string _mail;
        #endregion

        #region Properties
        public int MusteriSaticiID
        {
            get
            {
                return _musteriSaticiID;
            }

            set
            {
                _musteriSaticiID = value;
            }
        }

        public string MusteriSaticiAd
        {
            get
            {
                return _musteriSaticiAd;
            }

            set
            {
                _musteriSaticiAd = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string MusteriSaticiSoyad
        {
            get
            {
                return _musteriSaticiSoyad;
            }

            set
            {
                _musteriSaticiSoyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }

        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public void EmlakSahibiGetir(ComboBox cb)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "sp_yeniEmlakSahibi";
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch (SqlException hata)
            {
                string mesaj = hata.Message;
            }
            finally { conn.Close(); }
        }
        public bool MusteriSaticiKontrol(cMusteriSatici ms)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from MusteriSatici where Silindi=0 and MusteriSaticiAd=@MusteriSaticiAd and MusteriSaticiSoyad=@MusteriSaticiSoyad and MusteriSaticiID != @MusteriSaticiID", conn);

            comm.Parameters.Add("@MusteriSaticiAd", SqlDbType.VarChar).Value = ms.MusteriSaticiAd;
            comm.Parameters.Add("@MusteriSaticiSoyad", SqlDbType.VarChar).Value = ms.MusteriSaticiSoyad;
            comm.Parameters.Add("@MusteriSaticiID", SqlDbType.Int).Value = ms.MusteriSaticiID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                { Sonuc = true; }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            conn.Close();
            return Sonuc;
        }
        public bool MusteriSaticiEkle(cMusteriSatici ms)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into MusteriSatici(MusteriSaticiAd,MusteriSaticiSoyad,Telefon,Mail) values(@MusteriSaticiAd,@MusteriSaticiSoyad,@Telefon,@Mail)", conn);

            comm.Parameters.Add("@MusteriSaticiAd", SqlDbType.VarChar).Value = ms.MusteriSaticiAd;
            comm.Parameters.Add("@MusteriSaticiSoyad", SqlDbType.VarChar).Value = ms.MusteriSaticiSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = ms.Telefon;
            comm.Parameters.Add("@Mail", SqlDbType.VarChar).Value = ms.Mail;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool MusteriSaticiSil(int MusteriSaticiID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update MusteriSatici set Silindi=1 where MusteriSaticiID=@MusteriSaticiID", conn);
            comm.Parameters.Add("@MusterisaticiID", SqlDbType.Int).Value = MusteriSaticiID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException Hata)
            {
                string mesaj = Hata.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public List<cMusteriSatici> MusteriSaticiGoster()
        {
            SqlCommand comm = new SqlCommand("select MusteriSaticiID,MusteriSaticiAd,MusteriSaticiSoyad,Telefon,Mail from MusteriSatici where Silindi=0", conn);
            List<cMusteriSatici> liste = new List<cMusteriSatici>();

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cMusteriSatici ms = new cMusteriSatici();
                ms.MusteriSaticiID = Convert.ToInt32(dr["MusteriSaticiID"]);
                ms.MusteriSaticiAd = dr["MusteriSaticiAd"].ToString();
                ms.MusteriSaticiSoyad = dr["MusteriSaticiSoyad"].ToString();
                ms.Telefon = dr["Telefon"].ToString();
                ms.Mail = dr["Mail"].ToString();
                liste.Add(ms);
            }
            dr.Close();
            conn.Close();
            return liste;
        }
        public bool MusteriKontrolByGuncelle(cMusteriSatici ms)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from MusteriSatici where Silindi=0 and MusteriSaticiAd=@MusteriSaticiAd and MusteriSaticiSoyad=@MusteriSaticiSoyad and Telefon=@Telefon and MusteriSaticiID != @MusteriSaticiID", conn);

            comm.Parameters.Add("@MusteriSaticiAd", SqlDbType.VarChar).Value = ms.MusteriSaticiAd;
            comm.Parameters.Add("@MusteriSaticiSoyad", SqlDbType.VarChar).Value = ms.MusteriSaticiSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = ms.Telefon;
            comm.Parameters.Add("@MusteriSaticiID", SqlDbType.Int).Value = ms.MusteriSaticiID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Sonuc = true;
                }
                dr.Close();
            }
            catch (SqlException hata)
            {
                string Mesaj = hata.Message;
            }

            finally { conn.Close(); }
            return Sonuc;
        }
        public bool MusteriGuncelle(cMusteriSatici ms)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update MusteriSatici set MusteriSaticiAd=@MusteriSaticiAd, MusteriSaticiSoyad=@MusteriSaticiSoyad, Telefon=@Telefon, Mail=@Mail where MusteriSaticiID=@MusteriSaticiID", conn);

            comm.Parameters.Add("@MusteriSaticiAd", SqlDbType.VarChar).Value = ms.MusteriSaticiAd;
            comm.Parameters.Add("@MusteriSaticiSoyad", SqlDbType.VarChar).Value = ms.MusteriSaticiSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = ms.Telefon;
            comm.Parameters.Add("@Mail", SqlDbType.VarChar).Value = ms.Mail;
            comm.Parameters.Add("@MusteriSaticiID", SqlDbType.Int).Value = ms.MusteriSaticiID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
    }
}
