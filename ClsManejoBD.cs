using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryPonssaVERDULEROS
{
    public class ClsManejoBD
    {
        //OBJETOS para manipular la conexiòn y datos de una BD
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader rdr;

        //zona de declaraciones de objetos y variables
        public string RutaDeBaseDatos;

        public void ConectarBD()
        {
            RutaDeBaseDatos = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\VERDULEROS.mdb";
            try
            {
                conn.ConnectionString = RutaDeBaseDatos;
                conn.Open();
                MessageBox.Show("Base de Datos conectada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        internal void CargarLst(ComboBox lstNombreVend)
        {
            throw new NotImplementedException();
        }

        public void CargarLst(ComboBox cmb, ComboBox cmb1)
        {
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.TableDirect;
            comm.CommandText = "Vendedores";
            rdr = comm.ExecuteReader();
            //cmb.Items.Clear();
            while (rdr.Read())
            {
                cmb.Items.Add(rdr.GetString(1));
            }
            rdr.Close();
            comm.CommandText = "Productos";
            rdr = comm.ExecuteReader();
            //cmb.Items.Clear();
            while (rdr.Read())
            {
                cmb1.Items.Add(rdr.GetString(1));
            }
            rdr.Close();
        }
    }
}
