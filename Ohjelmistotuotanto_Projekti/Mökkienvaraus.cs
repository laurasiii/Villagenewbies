using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ohjelmistotuotanto_Projekti
{
    public partial class Mökkienvaraus : Form
    {
        public Mökkienvaraus()
        {
            InitializeComponent();
        }

        private void Mökkienvaraus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkiDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.mokkiDataset.mokki);

        }
    }
}
