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
        public void CargarLst(ComboBox cmb)
        {
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.TableDirect;
            comm.CommandText = "Proveedores";
            rdr = comm.ExecuteReader();
            cmb.Items.Clear();
            while (rdr.Read())
            {
                cmb.Items.Add(rdr.GetString(8));
            }
            rdr.Close();
        }

        public void CargarLst(ComboBox cmb, string NombrePais)
        {
            comm.Connection = conn;
            comm.CommandType = System.Data.CommandType.TableDirect;
            comm.CommandText = "Proveedores";

            rdr = comm.ExecuteReader();

            //Limpio para que o se acumule 
            cmb.Items.Clear();

            while (rdr.Read())
            {
                if (rdr.GetString(8) == NombrePais)
                {
                    cmb.Items.Add(rdr.GetString(5));
                }

            }
            rdr.Close();
        }
    }
}
