using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        List<IShape> shape;

        public Form1()
        {
            InitializeComponent();
            shape = new List<IShape>();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var b in shape)
                b.Draw(e);
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            shape.Add(new Rectangle());
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            shape.Add(new Circle());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var b in shape)
                b.Update();

            picCanvas.Refresh();
        }


        private void btnreset(object sender, EventArgs e)
        {
            shape.Clear();
        }

        private void btnexit(object sender, EventArgs e)
        {
            DialogResult keluar = MessageBox.Show("Yakin ingin keluar?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (keluar == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                shape.AsReadOnly();
            }


        }

       
    }
}
