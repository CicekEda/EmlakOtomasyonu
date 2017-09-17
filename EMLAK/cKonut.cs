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
   sealed class cKonut : cIsyeri
    {
        #region Members
        private double _aidat;
        private string _odaSayisi;
        private string _banyoSayisi;
        private string _binaYasi;
        private string _balkonSayisi;

        private bool _kapici;
        private bool _goruntuluDiyafon;
        private bool _bahce;
        private bool _siteIcinde;
        private bool _denizManzarali;
        private bool _yuruyusParkuru;
        private bool _sporKompleksi;
        private bool _market;
        private bool _okul;
        private bool _hastane;
        private bool _sidingKaplama;
        private bool _granitKaplama;
        private bool _mantolama;
        private bool _ahsapKaplama;
        private bool _sivali;
        private bool _boyali;

        private bool _ahsapParke;
        private bool _pvcKaplamali;
        private bool _laminantParke;
        private bool _marley;
        private bool _haliDoseme;
        private bool _kartonpiyerTavan;
        private bool _ankastreMutfak;
        private bool _celikKapi;
        private bool _ebeveynBanyo;
        private bool _dusakabin;
        #endregion

        #region Properties
        public double Aidat
        {
            get
            {
                return _aidat;
            }

            set
            {
                _aidat = value;
            }
        }

        public string OdaSayisi
        {
            get
            {
                return _odaSayisi;
            }

            set
            {
                _odaSayisi = value;
            }
        }

        public string BanyoSayisi
        {
            get
            {
                return _banyoSayisi;
            }

            set
            {
                _banyoSayisi = value;
            }
        }

        public string BinaYasi
        {
            get
            {
                return _binaYasi;
            }

            set
            {
                _binaYasi = value;
            }
        }

        public string BalkonSayisi
        {
            get
            {
                return _balkonSayisi;
            }

            set
            {
                _balkonSayisi = value;
            }
        }

        public bool Kapici
        {
            get
            {
                return _kapici;
            }

            set
            {
                _kapici = value;
            }
        }

        public bool GoruntuluDiyafon
        {
            get
            {
                return _goruntuluDiyafon;
            }

            set
            {
                _goruntuluDiyafon = value;
            }
        }

        public bool Bahce
        {
            get
            {
                return _bahce;
            }

            set
            {
                _bahce = value;
            }
        }

        public bool SiteIcinde
        {
            get
            {
                return _siteIcinde;
            }

            set
            {
                _siteIcinde = value;
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

        public bool YuruyusParkuru
        {
            get
            {
                return _yuruyusParkuru;
            }

            set
            {
                _yuruyusParkuru = value;
            }
        }

        public bool SporKompleksi
        {
            get
            {
                return _sporKompleksi;
            }

            set
            {
                _sporKompleksi = value;
            }
        }

        public bool Market
        {
            get
            {
                return _market;
            }

            set
            {
                _market = value;
            }
        }

        public bool Okul
        {
            get
            {
                return _okul;
            }

            set
            {
                _okul = value;
            }
        }

        public bool Hastane
        {
            get
            {
                return _hastane;
            }

            set
            {
                _hastane = value;
            }
        }

        public bool Mantolama
        {
            get
            {
                return _mantolama;
            }

            set
            {
                _mantolama = value;
            }
        }

        public bool AhsapKaplama
        {
            get
            {
                return _ahsapKaplama;
            }

            set
            {
                _ahsapKaplama = value;
            }
        }

        public bool Sivali
        {
            get
            {
                return _sivali;
            }

            set
            {
                _sivali = value;
            }
        }

        public bool Boyali
        {
            get
            {
                return _boyali;
            }

            set
            {
                _boyali = value;
            }
        }

        public bool AhsapParke
        {
            get
            {
                return _ahsapParke;
            }

            set
            {
                _ahsapParke = value;
            }
        }

        public bool LaminantParke
        {
            get
            {
                return _laminantParke;
            }

            set
            {
                _laminantParke = value;
            }
        }

        public bool Marley
        {
            get
            {
                return _marley;
            }

            set
            {
                _marley = value;
            }
        }

        public bool HaliDoseme
        {
            get
            {
                return _haliDoseme;
            }

            set
            {
                _haliDoseme = value;
            }
        }

        public bool KartonpiyerTavan
        {
            get
            {
                return _kartonpiyerTavan;
            }

            set
            {
                _kartonpiyerTavan = value;
            }
        }

        public bool AnkastreMutfak
        {
            get
            {
                return _ankastreMutfak;
            }

            set
            {
                _ankastreMutfak = value;
            }
        }

        public bool CelikKapi
        {
            get
            {
                return _celikKapi;
            }

            set
            {
                _celikKapi = value;
            }
        }

        public bool EbeveynBanyo
        {
            get
            {
                return _ebeveynBanyo;
            }

            set
            {
                _ebeveynBanyo = value;
            }
        }

        public bool Dusakabin
        {
            get
            {
                return _dusakabin;
            }

            set
            {
                _dusakabin = value;
            }
        }

        public bool SidingKaplama
        {
            get
            {
                return _sidingKaplama;
            }

            set
            {
                _sidingKaplama = value;
            }
        }

        public bool GranitKaplama
        {
            get
            {
                return _granitKaplama;
            }

            set
            {
                _granitKaplama = value;
            }
        }

        public bool PvcKaplamali
        {
            get
            {
                return _pvcKaplamali;
            }

            set
            {
                _pvcKaplamali = value;
            }
        }

        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public bool EmlakKontrol(cKonut k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from Konut where Silindi=0 and EmlakSahibi=@EmlakSahibi and Adres=@Adres and IlanID=@IlanID ", conn);
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = k.EmlakSahibi;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = k.Adres;
            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = k.IlanID;
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
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); }
            return Sonuc;
        }
        public bool EmlakEkle(cKonut k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Konut(IslemTuru,EmlakSahibi,Il,Adres,EklenmeTarihi,Fiyat,Metrekare,OdaSayisi,BanyoSayisi,Katsayisi,BinaYasi,BulunduguKat,Aidat,BalkonSayisi,Isitma,Aciklama,AhsapParke,PvcKaplamali,LaminantParke,Marley,HaliDoseme,KartonpiyerTavan,AnkastreMutfak,CelikKapi,EbeveynBanyo,Dusakabin,SidingKaplama,GranitKaplama,Mantolama,AhsapKaplama,Sivali,Boyali,Bahce,SiteIcinde,DenizManzarali,YuruyusParkuru,SporKompleksi,Market,Okul,Hastane,Guvenlik,Otopark,KabloTvUydu,TerasVeranda,Jenarator,Asansor,GoruntuluDiyafon,YanginMerdiveni,Kapici) values(@IslemTuru,@EmlakSahibi,@Il,@Adres,@EklenmeTarihi,@Fiyat,@Metrekare,@OdaSayisi,@BanyoSayisi,@Katsayisi,@BinaYasi,@BulunduguKat,@Aidat,@BalkonSayisi,@Isitma,@Aciklama,@AhsapParke,@PvcKaplamali,@LaminantParke,@Marley,@HaliDoseme,@KartonpiyerTavan,@AnkastreMutfak,@CelikKapi,@EbeveynBanyo,@Dusakabin,@SidingKaplama,@GranitKaplama,@Mantolama,@AhsapKaplama,@Sivali,@Boyali,@Bahce,@SiteIcinde,@DenizManzarali,@YuruyusParkuru,@SporKompleksi,@Market,@Okul,@Hastane,@Guvenlik,@Otopark,@KabloTvUydu,@TerasVeranda,@Jenarator,@Asansor,@GoruntuluDiyafon,@YanginMerdiveni,@Kapici)", conn);


            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = k.IslemTuru;
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = k.EmlakSahibi;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = k.Il;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = k.Adres;
            comm.Parameters.Add("@EklenmeTarihi", SqlDbType.VarChar).Value = k.EklenmeTarihi;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = k.Fiyat;
            comm.Parameters.Add("@Metrekare", SqlDbType.Int).Value = k.Metrekare;
            comm.Parameters.Add("@OdaSayisi", SqlDbType.VarChar).Value = k.OdaSayisi;
            comm.Parameters.Add("@BanyoSayisi", SqlDbType.VarChar).Value = k.BanyoSayisi;
            comm.Parameters.Add("@Katsayisi", SqlDbType.Int).Value = k.KatSayisi;
            comm.Parameters.Add("@BinaYasi", SqlDbType.VarChar).Value = k.BinaYasi;
            comm.Parameters.Add("@BulunduguKat", SqlDbType.Int).Value = k.BulunduguKat;
            comm.Parameters.Add("@Aidat", SqlDbType.Money).Value = k.Aidat;
            comm.Parameters.Add("@BalkonSayisi", SqlDbType.VarChar).Value = k.BalkonSayisi;
            comm.Parameters.Add("@Isitma", SqlDbType.VarChar).Value = k.Isitma;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = k.Aciklama;
            comm.Parameters.Add("@AhsapParke", SqlDbType.Bit).Value = k.AhsapParke;
            comm.Parameters.Add("@PvcKaplamali", SqlDbType.Bit).Value = k.PvcKaplamali;
            comm.Parameters.Add("@LaminantParke", SqlDbType.Bit).Value = k.LaminantParke;
            comm.Parameters.Add("@Marley", SqlDbType.Bit).Value = k.Marley;
            comm.Parameters.Add("@HaliDoseme", SqlDbType.Bit).Value = k.HaliDoseme;
            comm.Parameters.Add("@KartonpiyerTavan", SqlDbType.Bit).Value = k.KartonpiyerTavan;
            comm.Parameters.Add("@AnkastreMutfak", SqlDbType.Bit).Value = k.AnkastreMutfak;
            comm.Parameters.Add("@CelikKapi", SqlDbType.Bit).Value = k.CelikKapi;
            comm.Parameters.Add("@EbeveynBanyo", SqlDbType.Bit).Value = k.EbeveynBanyo;
            comm.Parameters.Add("@Dusakabin", SqlDbType.Bit).Value = k.Dusakabin;
            comm.Parameters.Add("@SidingKaplama", SqlDbType.Bit).Value = k.SidingKaplama;
            comm.Parameters.Add("@GranitKaplama", SqlDbType.Bit).Value = k.GranitKaplama;
            comm.Parameters.Add("@Mantolama", SqlDbType.Bit).Value = k.Mantolama;
            comm.Parameters.Add("@AhsapKaplama", SqlDbType.Bit).Value = k.AhsapKaplama;
            comm.Parameters.Add("@Sivali", SqlDbType.Bit).Value = k.Sivali;
            comm.Parameters.Add("@Boyali", SqlDbType.Bit).Value = k.Boyali;
            comm.Parameters.Add("@Bahce", SqlDbType.Bit).Value = k.Bahce;
            comm.Parameters.Add("@SiteIcinde", SqlDbType.Bit).Value = k.SiteIcinde;
            comm.Parameters.Add("@DenizManzarali", SqlDbType.Bit).Value = k.DenizManzarali;
            comm.Parameters.Add("@YuruyusParkuru", SqlDbType.Bit).Value = k.YuruyusParkuru;
            comm.Parameters.Add("@SporKompleksi", SqlDbType.Bit).Value = k.SporKompleksi;
            comm.Parameters.Add("@Market", SqlDbType.Bit).Value = k.Market;
            comm.Parameters.Add("@Okul", SqlDbType.Bit).Value = k.Okul;
            comm.Parameters.Add("@Hastane", SqlDbType.Bit).Value = k.Hastane;
            comm.Parameters.Add("@Guvenlik", SqlDbType.Bit).Value = k.Guvenlik;
            comm.Parameters.Add("@Otopark", SqlDbType.Bit).Value = k.Otopark;
            comm.Parameters.Add("@KabloTvUydu", SqlDbType.Bit).Value = k.KabloTvUydu;
            comm.Parameters.Add("@TerasVeranda", SqlDbType.Bit).Value = k.TerasVeranda;
            comm.Parameters.Add("@Jenarator", SqlDbType.Bit).Value = k.Jenarator;
            comm.Parameters.Add("@Asansor", SqlDbType.Bit).Value = k.Asansor;
            comm.Parameters.Add("@GoruntuluDiyafon", SqlDbType.Bit).Value = k.GoruntuluDiyafon;
            comm.Parameters.Add("@YanginMerdiveni", SqlDbType.Bit).Value = k.YanginMerdiveni;
            comm.Parameters.Add("@Kapici", SqlDbType.Bit).Value = k.Kapici;

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

        DataTable dt = new DataTable();
        public DataTable KonutGosterByAra(double Fiyat1, double Fiyat2, int Metrekare1, int Metrekare2, string IslemTuru, string Il)
        {
            SqlDataAdapter da = new SqlDataAdapter("select IlanID,EmlakSahibi,IslemTuru,Il,Adres,Fiyat,Metrekare,EklenmeTarihi from Konut where Silindi=0 and(Fiyat>=@Fiyat1 and Fiyat<=@Fiyat2) and (Metrekare>=@Metrekare1 and Metrekare<=@Metrekare2) and IslemTuru=@IslemTuru and Il=@Il", conn);

            da.SelectCommand.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value =IslemTuru;
            da.SelectCommand.Parameters.Add("@Il", SqlDbType.VarChar).Value =Il;
            da.SelectCommand.Parameters.Add("@Metrekare1", SqlDbType.Int).Value = Metrekare1;
            da.SelectCommand.Parameters.Add("@Metrekare2", SqlDbType.Int).Value = Metrekare2;
            da.SelectCommand.Parameters.Add("@Fiyat1", SqlDbType.Money).Value = Fiyat1;
            da.SelectCommand.Parameters.Add("@Fiyat2", SqlDbType.Money).Value = Fiyat2;
            try
            {
                da.Fill(dt);
            }
            catch (Exception hata)
            {
                string Mesaj = hata.Message;
            }
            return dt;
        }
        public bool KonutSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Konut set Silindi=1 where IlanID=@IlanID", conn);
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
        public bool EmlakKontrolByGuncelle(cKonut k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from Konut where Silindi=0 and EmlakSahibi=@EmlakSahibi and IslemTuru=@IslemTuru and Adres=@Adres and Fiyat=@Fiyat and Il=@Il and IlanID != @IlanID", conn);
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = k.EmlakSahibi;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = k.IslemTuru;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = k.Adres;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = k.Fiyat;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = k.Il;
            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = k.IlanID;
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
        public bool EmlakGuncelle(cKonut k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Konut set IslemTuru=@IslemTuru, EmlakSahibi=@EmlakSahibi, Il=@Il, Adres=@Adres, EklenmeTarihi=@EklenmeTarihi, Fiyat=@Fiyat, Metrekare=@Metrekare, OdaSayisi=@OdaSayisi, BanyoSayisi=@BanyoSayisi, Katsayisi=@Katsayisi, BinaYasi=@BinaYasi, BulunduguKat=@BulunduguKat, Aidat=@Aidat, BalkonSayisi=@BalkonSayisi, Isitma=@Isitma, Aciklama=@Aciklama, AhsapParke=@AhsapParke, PvcKaplamali=@PvcKaplamali, LaminantParke=@LaminantParke, Marley=@Marley, HaliDoseme=@HaliDoseme, KartonpiyerTavan=@KartonpiyerTavan, AnkastreMutfak=@AnkastreMutfak, CelikKapi=@CelikKapi, EbeveynBanyo=@EbeveynBanyo, Dusakabin=@Dusakabin, SidingKaplama=@SidingKaplama, GranitKaplama=@GranitKaplama, Mantolama=@Mantoloma, AhsapKaplama=@AhsapKaplama, Sivali=@Sivali, Boyali=@Boyali, Bahce=@Bahce, SiteIcinde=@SiteIcinde, DenizManzarali=@DenizManzarali, YuruyusParkuru=@YuruyusParkuru, SporKompleksi=@SporKompleksi, Market=@Market, Okul=@Okul, Hastane=@Hastane, Guvenlik=@Guvenlik, Otopark=@Otopark, KabloTvUydu=@KabloTvUydu, TerasVeranda=@TerasVeranda, Jenarator=@Jenarator, Asansor=@Asansor, GoruntuluDiyafon=@GoruntuluDiyafon, YanginMerdiveni=@YanginMerdiveni, Kapici=@Kapici where IlanID=@IlanID ", conn);

            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = k.IlanID;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = k.IslemTuru;
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = k.EmlakSahibi;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = k.Il;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = k.Adres;
            comm.Parameters.Add("@EklenmeTarihi", SqlDbType.VarChar).Value = k.EklenmeTarihi;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = k.Fiyat;
            comm.Parameters.Add("@Metrekare", SqlDbType.Int).Value = k.Metrekare;
            comm.Parameters.Add("@OdaSayisi", SqlDbType.VarChar).Value = k.OdaSayisi;
            comm.Parameters.Add("@BanyoSayisi", SqlDbType.VarChar).Value = k.BanyoSayisi;
            comm.Parameters.Add("@Katsayisi", SqlDbType.Int).Value = k.KatSayisi;
            comm.Parameters.Add("@BinaYasi", SqlDbType.VarChar).Value = k.BinaYasi;
            comm.Parameters.Add("@BulunduguKat", SqlDbType.Int).Value = k.BulunduguKat;
            comm.Parameters.Add("@Aidat", SqlDbType.Money).Value = k.Aidat;
            comm.Parameters.Add("@BalkonSayisi", SqlDbType.VarChar).Value = k.BalkonSayisi;
            comm.Parameters.Add("@Isitma", SqlDbType.VarChar).Value = k.Isitma;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = k.Aciklama;
            comm.Parameters.Add("@AhsapParke", SqlDbType.Bit).Value = k.AhsapParke;
            comm.Parameters.Add("@PvcKaplamali", SqlDbType.Bit).Value = k.PvcKaplamali;
            comm.Parameters.Add("@LaminantParke", SqlDbType.Bit).Value = k.LaminantParke;
            comm.Parameters.Add("@Marley", SqlDbType.Bit).Value = k.Marley;
            comm.Parameters.Add("@HaliDoseme", SqlDbType.Bit).Value = k.HaliDoseme;
            comm.Parameters.Add("@KartonpiyerTavan", SqlDbType.Bit).Value = k.KartonpiyerTavan;
            comm.Parameters.Add("@AnkastreMutfak", SqlDbType.Bit).Value = k.AnkastreMutfak;
            comm.Parameters.Add("@CelikKapi", SqlDbType.Bit).Value = k.CelikKapi;
            comm.Parameters.Add("@EbeveynBanyo", SqlDbType.Bit).Value = k.EbeveynBanyo;
            comm.Parameters.Add("@Dusakabin", SqlDbType.Bit).Value = k.Dusakabin;
            comm.Parameters.Add("@SidingKaplama", SqlDbType.Bit).Value = k.SidingKaplama;
            comm.Parameters.Add("@GranitKaplama", SqlDbType.Bit).Value = k.GranitKaplama;
            comm.Parameters.Add("@Mantoloma", SqlDbType.Bit).Value = k.Mantolama;
            comm.Parameters.Add("@AhsapKaplama", SqlDbType.Bit).Value = k.AhsapKaplama;
            comm.Parameters.Add("@Sivali", SqlDbType.Bit).Value = k.Sivali;
            comm.Parameters.Add("@Boyali", SqlDbType.Bit).Value = k.Boyali;
            comm.Parameters.Add("@Bahce", SqlDbType.Bit).Value = k.Bahce;
            comm.Parameters.Add("@SiteIcinde", SqlDbType.Bit).Value = k.SiteIcinde;
            comm.Parameters.Add("@DenizManzarali", SqlDbType.Bit).Value = k.DenizManzarali;
            comm.Parameters.Add("@YuruyusParkuru", SqlDbType.Bit).Value = k.YuruyusParkuru;
            comm.Parameters.Add("@SporKompleksi", SqlDbType.Bit).Value = k.SporKompleksi;
            comm.Parameters.Add("@Market", SqlDbType.Bit).Value = k.Market;
            comm.Parameters.Add("@Okul", SqlDbType.Bit).Value = k.Okul;
            comm.Parameters.Add("@Hastane", SqlDbType.Bit).Value = k.Hastane;
            comm.Parameters.Add("@Guvenlik", SqlDbType.Bit).Value = k.Guvenlik;
            comm.Parameters.Add("@Otopark", SqlDbType.Bit).Value = k.Otopark;
            comm.Parameters.Add("@KabloTvUydu", SqlDbType.Bit).Value = k.KabloTvUydu;
            comm.Parameters.Add("@TerasVeranda", SqlDbType.Bit).Value = k.TerasVeranda;
            comm.Parameters.Add("@Jenarator", SqlDbType.Bit).Value = k.Jenarator;
            comm.Parameters.Add("@Asansor", SqlDbType.Bit).Value = k.Asansor;
            comm.Parameters.Add("@GoruntuluDiyafon", SqlDbType.Bit).Value = k.GoruntuluDiyafon;
            comm.Parameters.Add("@YanginMerdiveni", SqlDbType.Bit).Value = k.YanginMerdiveni;
            comm.Parameters.Add("@Kapici", SqlDbType.Bit).Value = k.Kapici;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException dex)
            {
                string hata = dex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
    }
    class cKonutModel
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
        public List<cKonutModel> KonutGosterByAra()
        {
            SqlCommand comm = new SqlCommand("Select IlanID,EmlakSahibi,IslemTuru,Il,Adres,Fiyat,Metrekare,EklenmeTarihi from Konut where Silindi=0", conn);
            List<cKonutModel> liste = new List<cKonutModel>();

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cKonutModel k = new cKonutModel();

                    k.IlanID = Convert.ToInt32(dr["IlanID"].ToString());
                    k.EmlakSahibi = dr["EmlakSahibi"].ToString();
                    k.IslemTuru = dr["IslemTuru"].ToString();
                    k.Il = dr["Il"].ToString();
                    k.Adres = dr["Adres"].ToString();
                    k.Fiyat = Convert.ToDouble(dr["Fiyat"].ToString());
                    k.Metrekare = Convert.ToInt32(dr["Metrekare"].ToString());
                    k.EklenmeTarihi = dr["EklenmeTarihi"].ToString();
                    liste.Add(k);
                }

                dr.Close();
            }
            catch (Exception hata)
            {
                string Mesaj = hata.Message;
            }
            conn.Close();
            return liste;
        }
    }
}
