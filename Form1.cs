using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marvel_Proj
{
    public partial class Form1 : Form
    {
        int panelspeed = 2;

        public Form1()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = textBox_path.Text;
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.pause();
        }

        private void pictureTimerEvent(object sender, EventArgs e)
        {
            panel6.Left -= panelspeed;
            panel8.Left -= panelspeed;
            panel7.Left -= panelspeed;
            panel10.Left -= panelspeed;
            panel9.Left -= panelspeed;
            panel12.Left -= panelspeed;
            panel11.Left -= panelspeed;


            if(panel6.Left < -35)
            {
                panel6.Left = 1188;
            }
            if(panel8.Left < -35)
            {
                panel8.Left = 1188;
            }
            if(panel7.Left < -35)
            {
                panel7.Left = 1188;
            }
            if (panel10.Left < -35)
            {
                panel10.Left = 1188;
            }
            if (panel9.Left < -35)
            {
                panel9.Left = 1188;
            }
            if (panel12.Left < -35)
            {
                panel12.Left = 1188;
            }
            if (panel11.Left < -35)
            {
                panel11.Left = 1188;
            }

        }
    }
}
