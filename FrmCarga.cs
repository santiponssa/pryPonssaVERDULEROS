using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryPonssaVERDULEROS
{
    public partial class FrmRegistro : Form
    {
        ClsManejoBD objBD = new ClsManejoBD();
        OleDbCommand comm = new OleDbCommand();
        OleDbConnection conn = new OleDbConnection();
        OleDbDataReader rdr;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                objBD.ConectarBD();
                objBD.CargarLst(lstNombreVend, lstNombreProd);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception exc)
            {
                MessageBox.Show (exc.Message);
            }
        }
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
