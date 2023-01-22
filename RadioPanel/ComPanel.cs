using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;
using CTrue.FsConnect;
using CTrue.FsConnect.Managers;

namespace RadioPanel
{
    public partial class ComPanel : Form
    {
        private FsConnect fsConnect;
        private RadioManager radioManager;
        public ComPanel()
        {
            InitializeComponent();
            fsConnect = new FsConnect();
            try
            {
                fsConnect.Connect("RadioManagerTest", 0);
                radioManager = new RadioManager(fsConnect);
            } catch (Exception e)
            {
                infoLabel.Text = "Could not connect to simulator.";
                butRecon.Visible = true;
            }
        }

        private void butOne_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "1" : ".1";
        }

        private void butTwo_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "2" : ".2";
        }

        private void butThree_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "3" : ".3";
        }

        private void butFour_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "4" : ".4";
        }

        private void butFive_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "5" : ".5";
        }

        private void butSix_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "6" : ".6";
        }

        private void butSeven_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "7" : ".7";
        }

        private void butEight_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "8" : ".8";
        }

        private void butNine_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "9" : ".9";
        }

        private void butZero_Click(object sender, EventArgs e)
        {
            inputFreq.Text += inputFreq.Text.Length != 3 ? "0" : ".0";
        }

        private void butSwap_Click(object sender, EventArgs e)
        {
            var activeText = activeFreq.Text;
            activeFreq.Text = stbyFreq.Text;
            stbyFreq.Text = activeText;

            radioManager.Com1Swap();
            radioManager.Update();

            if(stbyFreq.Text == string.Empty)
            {
                stbyFreq.Text = radioManager.Com1StandbyFrequency.ToString();
            }

            //radioManager.SetCom1ActiveFrequency(Double.Parse(activeFreq.Text));
            //radioManager.SetCom1StandbyFrequency(Double.Parse(stbyFreq.Text));
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            var startFreq = inputFreq.Text;
            inputFreq.Text = string.Empty;
            for(int i = 0; i < startFreq.Length-1; i++)
            {
                inputFreq.Text += startFreq[i].ToString();
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            inputFreq.Text = string.Empty;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            stbyFreq.Text = inputFreq.Text;
            inputFreq.Clear();
            radioManager.SetCom1StandbyFrequency(Double.Parse(stbyFreq.Text));
            radioManager.Update();
        }

        private void butRecon_Click(object sender, EventArgs e)
        {
            try
            {
                butRecon.Visible = false;
                infoLabel.Text = string.Empty;
                fsConnect.Connect("RadioManagerTest", 0);
                radioManager = new RadioManager(fsConnect);
            }
            catch (Exception ex)
            {
                infoLabel.Text = "Could not connect to simulator.";
                butRecon.Visible = true;
            }
        }
    }
}
