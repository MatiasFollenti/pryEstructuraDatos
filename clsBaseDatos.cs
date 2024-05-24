using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public class clsBaseDatos
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        
        private string varCadenaConexion1 = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=..//..//Resources//Libreria.mdb";

        private string varCadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        public void Listar(DataGridView dgv) 
        {
            DataTable dt = new DataTable();
            try 
            {
                conn.ConnectionString = varCadenaConexion1;
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Libro";
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;

                conn.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Listar(DataGridView dgv, string query)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = varCadenaConexion1;
                conn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dgv.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
