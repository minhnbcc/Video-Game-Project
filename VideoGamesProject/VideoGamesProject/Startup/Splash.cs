using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGamesProject
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBar1.Value = 0;
            //prgBar1.Increment(1);

            while (prgBar1.Value < prgBar1.Maximum)
            {
                Thread.Sleep(15);
                prgBar1.Value += 1;
            }

            if (prgBar1.Value == 100)
                timer1.Stop();

        }
    }
}
