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
    public partial class FrmMain : Form
    {
        OleDbCommand comm = new OleDbCommand();
        OleDbConnection conn = new OleDbConnection();


        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

        }
    }
}
