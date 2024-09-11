using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Game
{
    public partial class arcadeForm : Form
    {
        public arcadeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.beep);
            startButton.Text = "3";
            Refresh();
            sp.Play();
            Thread.Sleep(1000);
            startButton.Text = "2";
            Refresh();
            sp.Play();
            Thread.Sleep(1000);
            startButton.Text = "1";
            Refresh();
            sp.Play();
            Thread.Sleep(1000);
            startButton.Text = "Go!";
            Refresh();
            sp.Play();
            Thread.Sleep(1000);
            startButton.Visible = false;
        }
    }
}
