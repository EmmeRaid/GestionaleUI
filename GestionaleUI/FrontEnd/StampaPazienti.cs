using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionaleUI.BackEnd;

namespace GestionaleUI.FrontEnd
{
    public partial class StampaPazienti : UserControl
    {

        public StampaPazienti()
        {
            InitializeComponent();
            CaricaPazienti();
        }

        private void CaricaPazienti()
        {
            var lista = PazienteStore.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // facoltativo
        }
    }
}
