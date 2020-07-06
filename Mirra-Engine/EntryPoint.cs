using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirra_Engine
{
    public partial class EntryPoint : MetroForm
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void Log_In_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Engine engine = new Engine();
            engine.Show();
        }

        private void EntryPoint_Closed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
