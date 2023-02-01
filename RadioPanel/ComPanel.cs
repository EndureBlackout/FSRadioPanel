﻿using System;
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
                radioManager.Update();
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

        private void navOne_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "1" : ".1";
        }

        private void navTwo_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "2" : ".2";
        }

        private void navThree_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "3" : ".3";
        }

        private void navFour_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "4" : ".4";
        }

        private void navFive_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "5" : ".5";
        }

        private void navSix_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "6" : ".6";
        }

        private void navSeven_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "7" : ".7";
        }

        private void navEight_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "8" : ".8";
        }

        private void navNine_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "9" : ".9";
        }

        private void navZero_Click(object sender, EventArgs e)
        {
            navInputFreq.Text += navInputFreq.Text.Length != 3 ? "0" : ".0";
        }

        private void navDel_Click(object sender, EventArgs e)
        {
            var startFreq = navInputFreq.Text;
            navInputFreq.Text = string.Empty;
            for (int i = 0; i < startFreq.Length - 1; i++)
            {
                navInputFreq.Text += startFreq[i].ToString();
            }
        }

        private void navOk_Click(object sender, EventArgs e)
        {
            navStbyFreq.Text = navInputFreq.Text;
            navInputFreq.Clear();
            radioManager.SetNav1StandbyFrequency(Double.Parse(navStbyFreq.Text));
            radioManager.Update();
        }

        private void navClear_Click(object sender, EventArgs e)
        {
            navInputFreq.Clear();
        }

        private void navSwap_Click(object sender, EventArgs e)
        {
            var activeText = navActivceFreq.Text;
            navActivceFreq.Text = navStbyFreq.Text;
            navStbyFreq.Text = activeText;

            radioManager.Nav1Swap();
            radioManager.Update();

            if (navStbyFreq.Text == string.Empty)
            {
                navStbyFreq.Text = radioManager.Nav1StandbyFrequency.ToString();
            }
        }

        private void squOne_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "1" : "";
        }

        private void squTwo_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "2" : "";
        }

        private void squThree_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "3" : "";
        }

        private void squFour_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "4" : "";
        }

        private void squFive_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "5" : "";
        }

        private void squSix_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "6" : "";
        }

        private void squSeven_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "7" : "";
        }

        private void squEight_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "8" : "";
        }

        private void squNine_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "9" : "";
        }

        private void squZero_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Text += txtSquawkIn.Text.Length != 4 ? "0" : "";
        }

        private void squDel_Click(object sender, EventArgs e)
        {
            var startSqua = txtSquawkIn.Text;
            txtSquawkIn.Text = string.Empty;
            for (int i = 0; i < txtSquawkIn.Text.Length - 1; i++)
            {
                txtSquawkIn.Text += startSqua[i].ToString();
            }
        }

        private void squOk_Click(object sender, EventArgs e)
        {
            txtSquawk.Text = txtSquawkIn.Text;
            txtSquawkIn.Clear();
            radioManager.SetTransponderCode(UInt32.Parse(txtSquawkIn.Text));
            radioManager.Update();
        }

        private void squClear_Click(object sender, EventArgs e)
        {
            txtSquawkIn.Clear();
        }
    }
}
