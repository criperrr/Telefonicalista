using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telehonicalista.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /* =>
        * <=>
        * <=
        * ==>
        * ===
        * !=
        * !==
        * <==
        * >=
        * 
        */

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmNovoContato frmNovoContato = new FrmNovoContato();
            frmNovoContato.ShowDialog();
        }
    }
}
