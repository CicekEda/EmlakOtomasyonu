
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
    class cMusteriSatici
    {
        private int _musteriSaticiID;
        private string _musteriSaticiAd;
        private string _musteriSaticiSoyad;


        #region properties
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
                _musteriSaticiAd = value;
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
                _musteriSaticiSoyad = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void MusteriSaticiGoster(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand();

            comm.CommandText = "sp_EmlakSahibi";
            comm.Connection = conn;

            comm.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {

                liste.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
    }
}
