using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Pen pen = new Pen(Color.Black, 3.0f))
                {
                    int x = 60;
                    int y = 30;
                    bool zigzag = false;
                    SolidBrush brush = new SolidBrush(Color.Black);
                    for (; y < 270; y += 30)
                    {
                        for (; x < 270; x += 60)
                            g.FillRectangle(brush, new Rectangle(x, y, 30, 30));
                        if (zigzag)
                        {
                            x = 60;
                            zigzag = false;
                        }
                        else
                        {
                            x = 30;
                            zigzag = true;
                        }
                    }
                    g.DrawRectangle(pen, new Rectangle(30, 30, 240, 240));
                }
            }
        }
    }
}