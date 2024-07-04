using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	class function
	{
		protected SqlConnection getConnection()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "data source=DESKTOP-9C1DA56\\SQLEXPRESS;database=myHotel;integrated security =True";
			return con;
		}

		public DataSet getData(String query) // Get data from database
		{
			SqlConnection con = getConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			cmd.CommandText = query;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return ds;
		}

		public void setData(String query, String message) // Insertion, Deletion, Updation
		{
			SqlConnection con = getConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = query;
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public SqlDataReader getForCombo(string query)
		{
			SqlConnection con = getConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd = new SqlCommand(query, con);
			SqlDataReader sdr = cmd.ExecuteReader();
			return sdr;
		}
	}
}
