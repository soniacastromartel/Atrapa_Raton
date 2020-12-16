using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            raton.MouseMove += Raton_MouseMove;
        }

        private void Raton_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int x = (int)(this.ClientRectangle.Right * rnd.NextDouble()) - 30;
            int y = (int)(this.ClientRectangle.Bottom * rnd.NextDouble()) - 10;
            raton.Location = new Point(x, y);
            

        }

        
    }
}
