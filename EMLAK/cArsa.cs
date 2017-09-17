using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLAK
{
    class cArsa: cKayit
    {
        #region Members
        private decimal _birimmFiyat;
        private int _maxBina;
        private bool _denizManzarali;
        private bool _elektrikHatti;
        private bool _kanalizasyon;
        private bool _dogaManzarali;
        private bool _parselli;
        private bool _yoluAcilmamis;
        private bool _dogalgaz;
        private bool _imarli;
        private bool _su; 
        #endregion

        #region Properties
        public decimal BirimmFiyat
        {
            get
            {
                return _birimmFiyat;
            }

            set
            {
                _birimmFiyat = value;
            }
        }

        public int MaxBina
        {
            get
            {
                return _maxBina;
            }

            set
            {
                _maxBina = value;
            }
        }

        public bool DenizManzarali
        {
            get
            {
                return _denizManzarali;
            }

            set
            {
                _denizManzarali = value;
            }
        }

        public bool ElektrikHatti
        {
            get
            {
                return _elektrikHatti;
            }

            set
            {
                _elektrikHatti = value;
            }
        }

        public bool Kanalizasyon
        {
            get
            {
                return _kanalizasyon;
            }

            set
            {
                _kanalizasyon = value;
            }
        }

        public bool DogaManzarali
        {
            get
            {
                return _dogaManzarali;
            }

            set
            {
                _dogaManzarali = value;
            }
        }

        public bool Parselli
        {
            get
            {
                return _parselli;
            }

            set
            {
                _parselli = value;
            }
        }

        public bool YoluAcilmamis
        {
            get
            {
                return _yoluAcilmamis;
            }

            set
            {
                _yoluAcilmamis = value;
            }
        }

        public bool Dogalgaz
        {
            get
            {
                return _dogalgaz;
            }

            set
            {
                _dogalgaz = value;
            }
        }

        public bool Imarli
        {
            get
            {
                return _imarli;
            }

            set
            {
                _imarli = value;
            }
        }

        public bool Su
        {
            get
            {
                return _su;
            }

            set
            {
                _su = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public bool ArsaKontrol(cArsa ck)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from Arsa where Silindi=0 and EmlakSahibi=@EmlakSahibi and Adres=@Adres and Il=@Il ", conn);
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = ck.EmlakSahibi;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = ck.Adres;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = ck.Il;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    Sonuc = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
            return Sonuc;
        }
        public bool ArsaEkle(cArsa ce)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Arsa(Fiyat,Metrekare,Il,Adres,EklenmeTarihi,Aciklama,BirimFiyat,MaxBinaYuksekligi,EmlakSahibi,DenizManzarali,ElektrikHatti,Kanalizasyon,DogaManzarali,Parselli,YoluAcilmamis,Dogalgaz,Imarli,Su) values(@Fiyat, @Metrekare, @Il, @Adres,@EklenmeTarihi,@Aciklama,@BirimFiyat,@Max,@EmlakSahibi,@DenizManzarali,@ElektrikHatti,@Kanalizasyon,@DogaManzarali,@Parselli,@YoluAcilmamis,@Dogalgaz,@Imar,@Su)", conn);
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = ce.Fiyat;
            comm.Parameters.Add("@Metrekare", SqlDbType.Int).Value = ce.Metrekare;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = ce.Il;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = ce.Adres;
            comm.Parameters.Add("@EklenmeTarihi", SqlDbType.VarChar).Value = ce.EklenmeTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value =ce.Aciklama;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = ce.BirimmFiyat;
            comm.Parameters.Add("@Max", SqlDbType.Int).Value = ce.MaxBina;
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = ce.EmlakSahibi;
            comm.Parameters.Add("@DenizManzarali", SqlDbType.Bit).Value = ce.DenizManzarali;
            comm.Parameters.Add("@ElektrikHatti", SqlDbType.Bit).Value = ce.ElektrikHatti;
            comm.Parameters.Add("@Kanalizasyon", SqlDbType.Bit).Value = ce.Kanalizasyon;
            comm.Parameters.Add("@DogaManzarali", SqlDbType.Bit).Value = ce.DogaManzarali;
            comm.Parameters.Add("@Parselli", SqlDbType.Bit).Value = ce.Parselli;
            comm.Parameters.Add("@YoluAcilmamis", SqlDbType.Bit).Value = ce.YoluAcilmamis;
            comm.Parameters.Add("@Dogalgaz", SqlDbType.Bit).Value = ce.Dogalgaz;
            comm.Parameters.Add("@Imar", SqlDbType.Bit).Value = ce.Imarli;
            comm.Parameters.Add("@Su", SqlDbType.Bit).Value = ce.Su;

            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException hata)
            {
                string mesaj = hata.Message;
            }
            finally { conn.Close(); }
            return Sonuc;

        }
        public int ArsaIDGetir()
        {
            int cg = 0;
            SqlCommand comm = new SqlCommand("select IlanID from Arsa where Silindi=0 and EmlakSahibi=@EmlakSahibi", conn);
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = EmlakSahibi; 
            if (conn.State == ConnectionState.Closed) conn.Open();
            
            try
            {
                cg=Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException hata)
            {
                string mesaj = hata.Message;
            }
            finally { conn.Close(); }
            conn.Close();
            return cg;
        }
        public bool ArsaSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Arsa set Silindi=1 where IlanID=@IlanID", conn);
            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException Hata)
            {
                string Mesaj = Hata.Message;
            }
            conn.Close();
            return Sonuc;
        }
        public bool ArsaKontrolByGuncelle(cArsa ak)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from Arsa where Silindi=0 and EmlakSahibi=@EmlakSahibi and Adres=@Adres and Fiyat=@Fiyat and Il=@Il and IlanID != @IlanID", conn);
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = ak.EmlakSahibi;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = ak.Adres;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = ak.Fiyat;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = ak.Il;
            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = ak.IlanID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
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
        public bool ArsaGuncelle(cArsa ce)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Arsa set dbo.Arsa.Fiyat=@Fiyat, dbo.Arsa.Metrekare=@Metrekare, dbo.Arsa.Il=@Il, dbo.Arsa.Adres=@Adres, dbo.Arsa.EklenmeTarihi=@EklenmeTarihi, dbo.Arsa.Aciklama=@Aciklama,dbo.Arsa.BirimFiyat=@BirimFiyat, dbo.Arsa.MaxBinaYuksekligi=@Max,dbo.Arsa.DenizManzarali=@DenizManzarali,dbo.Arsa.ElektrikHatti=@ElektrikHatti,dbo.Arsa.Kanalizasyon=@Kanalizasyon,dbo.Arsa.DogaManzarali=@DogaManzarali,dbo.Arsa.Parselli=@Parselli,dbo.Arsa.YoluAcilmamis=@YoluAcilmamis,dbo.Arsa.Dogalgaz=@Dogalgaz,dbo.Arsa.Imarli=@Imar,dbo.Arsa.Su=@Su where IlanID=@IlanID", conn);
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = ce.Fiyat;
            comm.Parameters.Add("@Metrekare", SqlDbType.Int).Value = ce.Metrekare;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = ce.Il;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = ce.Adres;
            comm.Parameters.Add("@EklenmeTarihi", SqlDbType.VarChar).Value = ce.EklenmeTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = ce.Aciklama;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = ce.BirimmFiyat;
            comm.Parameters.Add("@Max", SqlDbType.Int).Value = ce.MaxBina;
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = ce.EmlakSahibi;
            comm.Parameters.Add("@DenizManzarali", SqlDbType.Bit).Value = ce.DenizManzarali;
            comm.Parameters.Add("@ElektrikHatti", SqlDbType.Bit).Value = ce.ElektrikHatti;
            comm.Parameters.Add("@Kanalizasyon", SqlDbType.Bit).Value = ce.Kanalizasyon;
            comm.Parameters.Add("@DogaManzarali", SqlDbType.Bit).Value = ce.DogaManzarali;
            comm.Parameters.Add("@Parselli", SqlDbType.Bit).Value = ce.Parselli;
            comm.Parameters.Add("@YoluAcilmamis", SqlDbType.Bit).Value = ce.YoluAcilmamis;
            comm.Parameters.Add("@Dogalgaz", SqlDbType.Bit).Value = ce.Dogalgaz;
            comm.Parameters.Add("@Imar", SqlDbType.Bit).Value = ce.Imarli;
            comm.Parameters.Add("@Su", SqlDbType.Bit).Value = ce.Su;
            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = ce.IlanID;


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

        DataTable dt = new DataTable();
        public DataTable ArsaGoster(string IslemTuru, double minFiyat, double MaxFiyat, int minMetrekare, int MaxMetrekare, string Il)
        {
            SqlDataAdapter ilan = new SqlDataAdapter("Select IlanID, EmlakSahibi, IslemTuru, Fiyat, Metrekare, Il, Adres, EklenmeTarihi from Arsa where Silindi = 0 and IslemTuru = @IslemTuru and Il = @Il and (Fiyat >= @minFiyat and Fiyat <= @MaxFiyat) and (Metrekare >= @minMetrekare and Metrekare <= @MaxMetrekare)", conn);

            ilan.SelectCommand.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = IslemTuru;
            ilan.SelectCommand.Parameters.Add("@minFiyat", SqlDbType.Money).Value = minFiyat;
            ilan.SelectCommand.Parameters.Add("@MaxFiyat", SqlDbType.Money).Value = MaxFiyat;
            ilan.SelectCommand.Parameters.Add("@minMetrekare", SqlDbType.Int).Value = minMetrekare;
            ilan.SelectCommand.Parameters.Add("@MaxMetrekare", SqlDbType.Int).Value = MaxMetrekare;
            ilan.SelectCommand.Parameters.Add("@Il", SqlDbType.VarChar).Value = Il;

            try
            {
                ilan.Fill(dt);
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }
    }
    class cArsaModel

    {
        public int IlanID { get; set; }
        public string EmlakSahibi { get; set; }
        public string IslemTuru { get; set; }
        public string Il { get; set; }
        public string Adres { get; set; }
        public double Fiyat { get; set; }
        public int Metrekare { get; set; }
        public string EklenmeTarihi { get; set; }


        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public List<cArsaModel> ArsaGosterByAra()
        {
            SqlCommand comm = new SqlCommand("Select IlanID,EmlakSahibi,IslemTuru,Il,Adres,Fiyat,Metrekare,EklenmeTarihi from Arsa where Silindi=0", conn);
            List<cArsaModel> liste = new List<cArsaModel>();

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cArsaModel i = new cArsaModel();
                    i.IlanID = Convert.ToInt32(dr["IlanID"].ToString());
                    i.EmlakSahibi = dr["EmlakSahibi"].ToString();
                    i.IslemTuru = dr["IslemTuru"].ToString();
                    i.Il = dr["Il"].ToString();
                    i.Adres = dr["Adres"].ToString();
                    i.Fiyat = Convert.ToDouble(dr["Fiyat"].ToString());
                    i.Metrekare = Convert.ToInt32(dr["Metrekare"].ToString());
                    i.EklenmeTarihi = dr["EklenmeTarihi"].ToString();
                    liste.Add(i);
                }

                dr.Close();
            }
            catch (SqlException hata)
            {
                string Mesaj = hata.Message;
            }
            conn.Close();
            return liste;
        }
    }
}
