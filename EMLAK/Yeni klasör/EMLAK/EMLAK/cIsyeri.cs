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
    class cIsyeri:cKayit
    {
        
        private string _katSayisi;
        private string _bulunduguKat;
        private string _islemTuru;
        private string _isitma;
        private bool _guvenlik;
        private bool _otopark;
        private bool _kabloTvUydu;
        private bool _terasVeranda;
        private bool _jenarator;
        private bool _asansor;
        private bool _yanginMerdiveni;

        #region properties
        public string KatSayisi
        {
            get
            {
                return _katSayisi;
            }

            set
            {
                _katSayisi = value;
            }
        }

        public string BulunduguKat
        {
            get
            {
                return _bulunduguKat;
            }

            set
            {
                _bulunduguKat = value;
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

       

        public string Isitma
        {
            get
            {
                return _isitma;
            }

            set
            {
                _isitma = value;
            }
        }

        public bool Guvenlik
        {
            get
            {
                return _guvenlik;
            }

            set
            {
                _guvenlik = value;
            }
        }

        public bool Otopark
        {
            get
            {
                return _otopark;
            }

            set
            {
                _otopark = value;
            }
        }

        public bool KabloTvUydu
        {
            get
            {
                return _kabloTvUydu;
            }

            set
            {
                _kabloTvUydu = value;
            }
        }

        public bool TerasVeranda
        {
            get
            {
                return _terasVeranda;
            }

            set
            {
                _terasVeranda = value;
            }
        }

        public bool Jenarator
        {
            get
            {
                return _jenarator;
            }

            set
            {
                _jenarator = value;
            }
        }

        public bool Asansor
        {
            get
            {
                return _asansor;
            }

            set
            {
                _asansor = value;
            }
        }

        public bool YanginMerdiveni
        {
            get
            {
                return _yanginMerdiveni;
            }

            set
            {
                _yanginMerdiveni = value;
            }
        }

       







        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public bool IlanKontrol(cIsyeri i)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from Isyeri where Silindi=0 and Adres=@Adres and  EmlakSahibi=@EmlakSahibi and IlanID =@IlanID ", conn);
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = i.Adres ;
        
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = i.EmlakSahibi;

            comm.Parameters.Add("@IlanID", SqlDbType.Int).Value = i.IlanID;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();

            try
            {
                while (dr.Read())
                {

                    Sonuc = true;
                } dr.Close();
            }
            catch (SqlException ex)
            {

                string Hata = ex.Message;
            }
           
           
            conn.Close();
            return Sonuc;
        }
        public bool IlanEkle(cIsyeri i)
        {
            bool Sonuc = false;   
        SqlCommand comm = new SqlCommand("insert into Isyeri(Fiyat,EmlakSahibi,Metrekare,Il,Adres,EklenmeTarihi,Aciklama,BulunduguKat,KatSayisi,IslemTuru,Isitma,Otopark,Guvenlik,YanginMerdiveni,Asansor,Jenarator,KabloTvUydu,TerasVeranda) values(@Fiyat,@EmlakSahibi,@Metrekare,@Il,@Adres,@EklenmeTarihi,@Aciklama,@BulunduguKat,@KatSayisi,@IslemTuru, @Isitma,@Otopark,@Guvenlik,@YanginMerdiveni,@Asansor,@Jenarator,@KabloTvUydu,@TerasVeranda)" , conn);

            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = i.Fiyat;
            comm.Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = i.EmlakSahibi;
            comm.Parameters.Add("@Metrekare", SqlDbType.Int).Value = i.Metrekare;
            comm.Parameters.Add("@Il", SqlDbType.VarChar).Value = i.Il;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = i.Adres;
            comm.Parameters.Add("@EklenmeTarihi", SqlDbType.VarChar).Value = i.EklenmeTarihi;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = i.Aciklama;
            comm.Parameters.Add("@BulunduguKat", SqlDbType.VarChar).Value = i.BulunduguKat;
            comm.Parameters.Add("@KatSayisi", SqlDbType.VarChar).Value = i.KatSayisi;
            //comm.Parameters.Add("@Fotograf", SqlDbType.VarChar).Value = i.Fotograf;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = i.IslemTuru;
            comm.Parameters.Add("@Isitma", SqlDbType.VarChar).Value = i.Isitma;
            comm.Parameters.Add("@Otopark", SqlDbType.Bit).Value = i.Otopark;
            comm.Parameters.Add("@Guvenlik", SqlDbType.Bit).Value = i.Guvenlik;
            comm.Parameters.Add("@YanginMerdiveni", SqlDbType.Bit).Value = i.YanginMerdiveni;
            comm.Parameters.Add("@Asansor", SqlDbType.Bit).Value = i.Asansor;
            comm.Parameters.Add("@Jenarator", SqlDbType.Bit).Value = i.Jenarator;
            comm.Parameters.Add("@KabloTvUydu", SqlDbType.Bit).Value = i.KabloTvUydu;
            comm.Parameters.Add("@TerasVeranda", SqlDbType.Bit).Value = i.TerasVeranda;

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





        //public bool IlanDegistir(cIsyeri i)
        //{
        //   bool   Sonuc = false;

        //    return Sonuc;
        //}
        //public void IlanlarıGoster(DataGridView liste)
        //{
        //    SqlCommand ilan = new SqlCommand("Select EmlakSahibi, IslemTuru, Il, Adres, Fiyat, Metrekare, EklenmeTarihi from Isyeri where Silindi = 0  ", conn);
         

        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    try
        //    {
        //        SqlDataReader dr = ilan.ExecuteReader();
        //        int i = 0;
        //        while (dr.Read())
        //        {
        //          liste.Rows[i].Cells[dr[0].ToString()].Value.ToString();
        //          liste.Rows[i].Cells[dr[1].ToString()].Value.ToString();
        //          liste.Rows[i].Cells[dr[2].ToString()].Value.ToString();
        //          liste.Rows[i].Cells[dr[3].ToString()].Value.ToString();
        //          liste.Rows[i].Cells[dr[4].ToString()].Value.ToString();
        //          liste.Rows[i].Cells[dr[5].ToString()].Value.ToString();
        //          liste.Rows[i].Cells[dr[6].ToString()].Value.ToString();
        //          i++;
        //        }
        //        dr.Close();

        //    }
        //    catch (Exception ex)
        //    {

        //        string hata = ex.Message;
        //    }



        //    finally { conn.Close(); }

        //}
        public DataTable IlanlarıGoster(string EmlakSahibi, string IslemTuru, double minFiyat, double MaxFiyat, int minMetrekare, int MaxMetrekare, string Il, DataGridView liste)
        {/*SqlCommand ilan = new SqlCommand*/
              DataTable dt = new DataTable();
            SqlDataAdapter ilan= new SqlDataAdapter("Select EmlakSahibi, IslemTuru, Il, Adres, Fiyat, Metrekare, EklenmeTarihi from Isyeri where Silindi = 0 and((Fiyat >= @minFiyat and Fiyat <= @MaxFiyat) and(Metrekare >= @minMetrekare and Metrekare <= @MaxMetrekare)) and EmlakSahibi like @EmlakSahibi + '%' and IslemTuru like @IslemTuru + '%' and Il like @Il + '%'  ", conn);
            ilan.SelectCommand .Parameters.Add("@EmlakSahibi", SqlDbType.VarChar).Value = EmlakSahibi;
            ilan.SelectCommand.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = IslemTuru;
            ilan.SelectCommand.Parameters.Add("@minFiyat", SqlDbType.Money).Value = minFiyat;
            ilan.SelectCommand.Parameters.Add("@MaxFiyat", SqlDbType.Money).Value = MaxFiyat;
            ilan.SelectCommand.Parameters.Add("@minMetrekare", SqlDbType.Int).Value = minMetrekare;
            ilan.SelectCommand.Parameters.Add("@MaxMetrekare", SqlDbType.Int).Value = MaxMetrekare;
             ilan.SelectCommand.Parameters.Add("@Il", SqlDbType.VarChar).Value = Il;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
               ilan .Fill(dt);
                //    SqlDataReader dr = ilan.ExecuteReader();
                //    int i = 0;
                //    while (dr.Read())
                //{
                //        liste.Rows[i].Cells[dr[0].ToString()].Value.ToString();
                //        liste.Rows[i].Cells[dr[1].ToString()].Value.ToString();
                //        liste.Rows[i].Cells[dr[2].ToString()].Value.ToString();
                //        liste.Rows[i].Cells[dr[3].ToString()].Value.ToString();
                //        liste.Rows[i].Cells[dr[4].ToString()].Value.ToString();
                //        liste.Rows[i].Cells[dr[5].ToString()].Value.ToString();
                //        liste.Rows[i].Cells[dr[6].ToString()].Value.ToString();
                //        i++;
                //    }
                //    dr.Close();

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }



            finally { conn.Close(); }



            return dt;

        }
    }

    class cIsyeriModel

    {
        public string EmlakSahibi { get; set; }
        public string IslemTuru { get; set; }
        public string Il { get; set; }
        public string Adres { get; set; }
        public double Fiyat { get; set; }
        public int Metrekare { get; set; }
        public string EklenmeTarihi { get; set; }

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        public List<cIsyeriModel> IsyeriGosterByAra()
        {
            SqlCommand comm = new SqlCommand("Select EmlakSahibi,IslemTuru,Il,Adres,Fiyat,Metrekare,EklenmeTarihi from Isyeri where Silindi=0", conn);
            List<cIsyeriModel> liste = new List<cIsyeriModel>();

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cIsyeriModel  i = new EMLAK.cIsyeriModel ();

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
            catch (Exception hata)
            {
                string Mesaj = hata.Message;
            }
            conn.Close();
            return liste;
        }
    }
}
