using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLAK
{
    class cMusteriAlici
    {
        private int _musteriAliciID;
        private string _musteriAliciAd;
        private string _musteriAliciSoyad;
        private string _telefon;
        private string _mail;
        private string _islemTarihi;
        private string _islemTuru;
        private string _kategori;
        private string _aciklama;
        private bool _silindi;


        #region prop
        public int MusteriAliciID
        {
            get
            {
                return _musteriAliciID;
            }

            set
            {
                _musteriAliciID = value;
            }
        }

        public string MusteriAliciAd
        {
            get
            {
                return _musteriAliciAd;
            }

            set
            {
                _musteriAliciAd = value;
            }
        }

        public string MusteriAliciSoyad
        {
            get
            {
                return _musteriAliciSoyad;
            }

            set
            {
                _musteriAliciSoyad = value;
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

        public string IslemTarihi
        {
            get
            {
                return _islemTarihi;
            }

            set
            {
                _islemTarihi = value;
            }
        }

        public string IslemTuru
        {
            get
            {
                return _islemTuru;
            }

            set
            {
                _islemTuru = value;
            }
        }

        public string Kategori
        {
            get
            {
                return _kategori;
            }

            set
            {
                _kategori = value;
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

        public bool Silindi
        {
            get
            {
                return _silindi;
            }

            set
            {
                _silindi = value;
            }
        }
        #endregion


        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public bool MusteriAliciVarMi(cMusteriAlici ma)
        {
            bool Sonuc = false;

            SqlCommand comm = new SqlCommand("select * from MusteriAlici where Silindi=0 and MusteriAliciAd = @MusteriAliciAd and MusteriAliciSoyad = @MusteriAliciSoyad", conn);
            comm.Parameters.Add("@MusteriAliciAd", SqlDbType.VarChar).Value = ma._musteriAliciAd;
            comm.Parameters.Add("@MusteriAliciSoyad", SqlDbType.VarChar).Value = ma._musteriAliciSoyad;


            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) Sonuc = true;
            dr.Close();
            conn.Close();

            return Sonuc;

        }
        public bool MusteriAliciEkle(cMusteriAlici ma)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into MusteriAlici (MusteriAliciAd ,MusteriAliciSoyad, Telefon, Mail, IslemTarihi, Aciklama, IslemTuru, Kategori) values (@MusteriAliciAd ,@MusteriAliciSoyad, @Telefon, @Mail, @IslemTarihi, @Aciklama, @IslemTuru, @Kategori)", conn);

            comm.Parameters.Add("@MusteriAliciAd", SqlDbType.VarChar).Value = ma._musteriAliciAd;
            comm.Parameters.Add("@MusteriAliciSoyad", SqlDbType.VarChar).Value = ma._musteriAliciSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = ma._telefon;
            comm.Parameters.Add("@Mail", SqlDbType.VarChar).Value = ma.Mail;
            comm.Parameters.Add("@IslemTarihi", SqlDbType.VarChar).Value = ma._islemTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ma._aciklama;

            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = ma._islemTuru;


            comm.Parameters.Add("@Kategori", SqlDbType.VarChar).Value = ma._kategori;

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
        public bool MusteriAliciVarMiByGuncelle(cMusteriAlici ma)
        {
            bool  Sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from MusteriAlici where Silindi=0 and MusteriAliciAd = @MusteriAliciAd and MusteriAliciSoyad = @MusteriAliciSoyad and MusteriAliciID != @MusteriAliciID", conn);
            comm.Parameters.Add("@MusteriAliciAd", SqlDbType.VarChar).Value = ma._musteriAliciAd;
            comm.Parameters.Add("@MusteriAliciSoyad", SqlDbType.VarChar).Value = ma._musteriAliciSoyad;
            comm.Parameters.Add("@MusteriAliciID", SqlDbType.Int).Value = ma._musteriAliciID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Sonuc = true;
            }

            dr.Close();
            conn.Close();

            return Sonuc;
        }
        public bool MusteriAliciGuncelle(cMusteriAlici ma)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update MusteriAlici set MusteriAliciAd=@MusteriAliciAd , MusteriAliciSoyad=@MusteriAliciSoyad , Telefon=@Telefon , Mail=@Mail , IslemTarihi=@IslemTarihi , Aciklama=@Aciklama , IslemTuru =@IslemTuru ,Kategori =@Kategori where MusteriAliciID=@MusteriAliciID", conn);
            comm.Parameters.Add("@MusteriAliciID", SqlDbType.VarChar).Value = ma._musteriAliciID;
            comm.Parameters.Add("@MusteriAliciAd", SqlDbType.VarChar).Value = ma._musteriAliciAd;
            comm.Parameters.Add("@MusteriAliciSoyad", SqlDbType.VarChar).Value = ma._musteriAliciSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = ma._telefon;
            comm.Parameters.Add("@Mail", SqlDbType.VarChar).Value = ma._mail;
            comm.Parameters.Add("@IslemTarihi", SqlDbType.VarChar).Value = ma._islemTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ma._aciklama;

            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = ma._islemTuru;
            comm.Parameters.Add("@Kategori", SqlDbType.VarChar).Value = ma._kategori;

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
        public bool MusteriAliciSil(int MusteriAliciID)
        {
          bool  Sonuc = false;
            SqlCommand comm = new SqlCommand("Update MusteriAlici set Silindi=1 where  MusteriAliciID = @MusteriAliciID ", conn);

            comm.Parameters.Add("@MusteriAliciID", SqlDbType.Int).Value = MusteriAliciID;

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
        public List<cMusteriAlici> MusteriAliciGoster()
        {

            SqlCommand comm = new SqlCommand("Select MusteriAliciID ,MusteriAliciAd ,MusteriAliciSoyad ,Telefon ,Mail ,IslemTarihi , Aciklama ,IslemTuru , Kategori from MusteriAlici where Silindi=0", conn);

            List<cMusteriAlici> liste = new List<cMusteriAlici>();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cMusteriAlici ma = new cMusteriAlici();
                ma.MusteriAliciID = Convert.ToInt32(dr[0]);
                ma.MusteriAliciAd = dr[1].ToString();
                ma.MusteriAliciSoyad = dr[2].ToString();
                ma.Telefon = dr[3].ToString();
                ma.Mail = dr[4].ToString();
                ma.IslemTarihi = dr[5].ToString();
                ma.Aciklama = dr[6].ToString();
                ma.IslemTuru = dr[7].ToString();
                ma.Kategori = dr[8].ToString();
                liste.Add(ma);
            }
            dr.Close();
            conn.Close();

            return liste;
        }
    }
}
