using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace sekiro_stalin
{
    public partial class LastDialog : Form
    {
        SoundPlayer smak = new SoundPlayer(Properties.Resources.smak);
        SoundPlayer pistol = new SoundPlayer(Properties.Resources.pistol);
        public LastDialog()
        {
            InitializeComponent();
        }

        private void LastDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            SystemSounds.Hand.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smak.PlaySync();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pistol.PlaySync();
            Environment.Exit(0);
        }
    }
}
