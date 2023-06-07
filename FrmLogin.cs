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
    public partial class FrmLogin : Form
    {
        ClsManejoBD objBD = new ClsManejoBD();
        OleDbCommand comm = new OleDbCommand();
        OleDbConnection conn = new OleDbConnection();
        OleDbDataReader rdr;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                objBD.ConectarBD();
                objBD.CargarLst(lstNombreVend);
                objBD.CargarLst(lstNombreProd);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
