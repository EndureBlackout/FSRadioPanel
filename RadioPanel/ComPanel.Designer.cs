namespace RadioPanel
{
    partial class ComPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stbyFreq = new System.Windows.Forms.TextBox();
            this.stbyLabel = new System.Windows.Forms.Label();
            this.activeFreq = new System.Windows.Forms.TextBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.butSwap = new System.Windows.Forms.Button();
            this.butOne = new System.Windows.Forms.Button();
            this.butTwo = new System.Windows.Forms.Button();
            this.butThree = new System.Windows.Forms.Button();
            this.butFour = new System.Windows.Forms.Button();
            this.butFive = new System.Windows.Forms.Button();
            this.butSix = new System.Windows.Forms.Button();
            this.butSeven = new System.Windows.Forms.Button();
            this.butEight = new System.Windows.Forms.Button();
            this.butNine = new System.Windows.Forms.Button();
            this.butZero = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.inputFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.butRecon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.navLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navSwap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.navActivceFreq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.navStbyFreq = new System.Windows.Forms.TextBox();
            this.navInputFreq = new System.Windows.Forms.TextBox();
            this.navClear = new System.Windows.Forms.Button();
            this.navDel = new System.Windows.Forms.Button();
            this.navOk = new System.Windows.Forms.Button();
            this.navZero = new System.Windows.Forms.Button();
            this.navNine = new System.Windows.Forms.Button();
            this.navEight = new System.Windows.Forms.Button();
            this.navSeven = new System.Windows.Forms.Button();
            this.navSix = new System.Windows.Forms.Button();
            this.navFive = new System.Windows.Forms.Button();
            this.navFour = new System.Windows.Forms.Button();
            this.navThree = new System.Windows.Forms.Button();
            this.navTwo = new System.Windows.Forms.Button();
            this.navOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stbyFreq
            // 
            this.stbyFreq.BackColor = System.Drawing.SystemColors.Window;
            this.stbyFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.stbyFreq.Location = new System.Drawing.Point(227, 97);
            this.stbyFreq.MaxLength = 5;
            this.stbyFreq.Name = "stbyFreq";
            this.stbyFreq.ReadOnly = true;
            this.stbyFreq.Size = new System.Drawing.Size(135, 34);
            this.stbyFreq.TabIndex = 0;
            // 
            // stbyLabel
            // 
            this.stbyLabel.AutoSize = true;
            this.stbyLabel.BackColor = System.Drawing.Color.Black;
            this.stbyLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.stbyLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.stbyLabel.Location = new System.Drawing.Point(227, 66);
            this.stbyLabel.Name = "stbyLabel";
            this.stbyLabel.Size = new System.Drawing.Size(65, 28);
            this.stbyLabel.TabIndex = 1;
            this.stbyLabel.Text = "STBY:";
            // 
            // activeFreq
            // 
            this.activeFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.activeFreq.Location = new System.Drawing.Point(12, 97);
            this.activeFreq.MaxLength = 5;
            this.activeFreq.Name = "activeFreq";
            this.activeFreq.ReadOnly = true;
            this.activeFreq.Size = new System.Drawing.Size(136, 34);
            this.activeFreq.TabIndex = 2;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.BackColor = System.Drawing.Color.Black;
            this.activeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.activeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.activeLabel.Location = new System.Drawing.Point(12, 66);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(77, 28);
            this.activeLabel.TabIndex = 3;
            this.activeLabel.Text = "Active:";
            // 
            // butSwap
            // 
            this.butSwap.ForeColor = System.Drawing.Color.Black;
            this.butSwap.Location = new System.Drawing.Point(154, 97);
            this.butSwap.Name = "butSwap";
            this.butSwap.Size = new System.Drawing.Size(67, 34);
            this.butSwap.TabIndex = 4;
            this.butSwap.Text = "↔";
            this.butSwap.UseVisualStyleBackColor = true;
            this.butSwap.Click += new System.EventHandler(this.butSwap_Click);
            // 
            // butOne
            // 
            this.butOne.Location = new System.Drawing.Point(65, 205);
            this.butOne.Name = "butOne";
            this.butOne.Size = new System.Drawing.Size(75, 23);
            this.butOne.TabIndex = 5;
            this.butOne.Text = "1";
            this.butOne.UseVisualStyleBackColor = true;
            this.butOne.Click += new System.EventHandler(this.butOne_Click);
            // 
            // butTwo
            // 
            this.butTwo.Location = new System.Drawing.Point(146, 205);
            this.butTwo.Name = "butTwo";
            this.butTwo.Size = new System.Drawing.Size(75, 23);
            this.butTwo.TabIndex = 6;
            this.butTwo.Text = "2";
            this.butTwo.UseVisualStyleBackColor = true;
            this.butTwo.Click += new System.EventHandler(this.butTwo_Click);
            // 
            // butThree
            // 
            this.butThree.Location = new System.Drawing.Point(227, 205);
            this.butThree.Name = "butThree";
            this.butThree.Size = new System.Drawing.Size(75, 23);
            this.butThree.TabIndex = 7;
            this.butThree.Text = "3";
            this.butThree.UseVisualStyleBackColor = true;
            this.butThree.Click += new System.EventHandler(this.butThree_Click);
            // 
            // butFour
            // 
            this.butFour.Location = new System.Drawing.Point(65, 234);
            this.butFour.Name = "butFour";
            this.butFour.Size = new System.Drawing.Size(75, 23);
            this.butFour.TabIndex = 8;
            this.butFour.Text = "4";
            this.butFour.UseVisualStyleBackColor = true;
            this.butFour.Click += new System.EventHandler(this.butFour_Click);
            // 
            // butFive
            // 
            this.butFive.Location = new System.Drawing.Point(146, 234);
            this.butFive.Name = "butFive";
            this.butFive.Size = new System.Drawing.Size(75, 23);
            this.butFive.TabIndex = 9;
            this.butFive.Text = "5";
            this.butFive.UseVisualStyleBackColor = true;
            this.butFive.Click += new System.EventHandler(this.butFive_Click);
            // 
            // butSix
            // 
            this.butSix.Location = new System.Drawing.Point(227, 234);
            this.butSix.Name = "butSix";
            this.butSix.Size = new System.Drawing.Size(75, 23);
            this.butSix.TabIndex = 10;
            this.butSix.Text = "6";
            this.butSix.UseVisualStyleBackColor = true;
            this.butSix.Click += new System.EventHandler(this.butSix_Click);
            // 
            // butSeven
            // 
            this.butSeven.Location = new System.Drawing.Point(65, 263);
            this.butSeven.Name = "butSeven";
            this.butSeven.Size = new System.Drawing.Size(75, 23);
            this.butSeven.TabIndex = 11;
            this.butSeven.Text = "7";
            this.butSeven.UseVisualStyleBackColor = true;
            this.butSeven.Click += new System.EventHandler(this.butSeven_Click);
            // 
            // butEight
            // 
            this.butEight.Location = new System.Drawing.Point(146, 263);
            this.butEight.Name = "butEight";
            this.butEight.Size = new System.Drawing.Size(75, 23);
            this.butEight.TabIndex = 12;
            this.butEight.Text = "8";
            this.butEight.UseVisualStyleBackColor = true;
            this.butEight.Click += new System.EventHandler(this.butEight_Click);
            // 
            // butNine
            // 
            this.butNine.Location = new System.Drawing.Point(227, 263);
            this.butNine.Name = "butNine";
            this.butNine.Size = new System.Drawing.Size(75, 23);
            this.butNine.TabIndex = 13;
            this.butNine.Text = "9";
            this.butNine.UseVisualStyleBackColor = true;
            this.butNine.Click += new System.EventHandler(this.butNine_Click);
            // 
            // butZero
            // 
            this.butZero.Location = new System.Drawing.Point(146, 292);
            this.butZero.Name = "butZero";
            this.butZero.Size = new System.Drawing.Size(75, 23);
            this.butZero.TabIndex = 14;
            this.butZero.Text = "0";
            this.butZero.UseVisualStyleBackColor = true;
            this.butZero.Click += new System.EventHandler(this.butZero_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(227, 292);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 15;
            this.butOk.Text = "OK ✔";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(65, 292);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 16;
            this.butDel.Text = "DEL";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(146, 321);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 17;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // inputFreq
            // 
            this.inputFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.inputFreq.Location = new System.Drawing.Point(93, 165);
            this.inputFreq.Name = "inputFreq";
            this.inputFreq.Size = new System.Drawing.Size(176, 34);
            this.inputFreq.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(151, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Input:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.infoLabel.Location = new System.Drawing.Point(5, 672);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 15);
            this.infoLabel.TabIndex = 20;
            // 
            // butRecon
            // 
            this.butRecon.Location = new System.Drawing.Point(297, 668);
            this.butRecon.Name = "butRecon";
            this.butRecon.Size = new System.Drawing.Size(75, 23);
            this.butRecon.TabIndex = 21;
            this.butRecon.Text = "Reconnect";
            this.butRecon.UseVisualStyleBackColor = true;
            this.butRecon.Visible = false;
            this.butRecon.Click += new System.EventHandler(this.butRecon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "COM1:";
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.navLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.navLabel.Location = new System.Drawing.Point(12, 341);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(97, 37);
            this.navLabel.TabIndex = 23;
            this.navLabel.Text = "NAV1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(155, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Input:";
            // 
            // navSwap
            // 
            this.navSwap.ForeColor = System.Drawing.Color.Black;
            this.navSwap.Location = new System.Drawing.Point(154, 418);
            this.navSwap.Name = "navSwap";
            this.navSwap.Size = new System.Drawing.Size(67, 34);
            this.navSwap.TabIndex = 28;
            this.navSwap.Text = "↔";
            this.navSwap.UseVisualStyleBackColor = true;
            this.navSwap.Click += new System.EventHandler(this.navSwap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Active:";
            // 
            // navActivceFreq
            // 
            this.navActivceFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.navActivceFreq.Location = new System.Drawing.Point(12, 418);
            this.navActivceFreq.MaxLength = 5;
            this.navActivceFreq.Name = "navActivceFreq";
            this.navActivceFreq.ReadOnly = true;
            this.navActivceFreq.Size = new System.Drawing.Size(136, 34);
            this.navActivceFreq.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(227, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "STBY:";
            // 
            // navStbyFreq
            // 
            this.navStbyFreq.BackColor = System.Drawing.SystemColors.Window;
            this.navStbyFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.navStbyFreq.Location = new System.Drawing.Point(227, 418);
            this.navStbyFreq.MaxLength = 5;
            this.navStbyFreq.Name = "navStbyFreq";
            this.navStbyFreq.ReadOnly = true;
            this.navStbyFreq.Size = new System.Drawing.Size(135, 34);
            this.navStbyFreq.TabIndex = 24;
            // 
            // navInputFreq
            // 
            this.navInputFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.navInputFreq.Location = new System.Drawing.Point(93, 483);
            this.navInputFreq.Name = "navInputFreq";
            this.navInputFreq.Size = new System.Drawing.Size(176, 34);
            this.navInputFreq.TabIndex = 43;
            // 
            // navClear
            // 
            this.navClear.Location = new System.Drawing.Point(146, 639);
            this.navClear.Name = "navClear";
            this.navClear.Size = new System.Drawing.Size(75, 23);
            this.navClear.TabIndex = 42;
            this.navClear.Text = "Clear";
            this.navClear.UseVisualStyleBackColor = true;
            this.navClear.Click += new System.EventHandler(this.navClear_Click);
            // 
            // navDel
            // 
            this.navDel.Location = new System.Drawing.Point(65, 610);
            this.navDel.Name = "navDel";
            this.navDel.Size = new System.Drawing.Size(75, 23);
            this.navDel.TabIndex = 41;
            this.navDel.Text = "DEL";
            this.navDel.UseVisualStyleBackColor = true;
            this.navDel.Click += new System.EventHandler(this.navDel_Click);
            // 
            // navOk
            // 
            this.navOk.Location = new System.Drawing.Point(227, 610);
            this.navOk.Name = "navOk";
            this.navOk.Size = new System.Drawing.Size(75, 23);
            this.navOk.TabIndex = 40;
            this.navOk.Text = "OK ✔";
            this.navOk.UseVisualStyleBackColor = true;
            this.navOk.Click += new System.EventHandler(this.navOk_Click);
            // 
            // navZero
            // 
            this.navZero.Location = new System.Drawing.Point(146, 610);
            this.navZero.Name = "navZero";
            this.navZero.Size = new System.Drawing.Size(75, 23);
            this.navZero.TabIndex = 39;
            this.navZero.Text = "0";
            this.navZero.UseVisualStyleBackColor = true;
            this.navZero.Click += new System.EventHandler(this.navZero_Click);
            // 
            // navNine
            // 
            this.navNine.Location = new System.Drawing.Point(227, 581);
            this.navNine.Name = "navNine";
            this.navNine.Size = new System.Drawing.Size(75, 23);
            this.navNine.TabIndex = 38;
            this.navNine.Text = "9";
            this.navNine.UseVisualStyleBackColor = true;
            this.navNine.Click += new System.EventHandler(this.navNine_Click);
            // 
            // navEight
            // 
            this.navEight.Location = new System.Drawing.Point(146, 581);
            this.navEight.Name = "navEight";
            this.navEight.Size = new System.Drawing.Size(75, 23);
            this.navEight.TabIndex = 37;
            this.navEight.Text = "8";
            this.navEight.UseVisualStyleBackColor = true;
            this.navEight.Click += new System.EventHandler(this.navEight_Click);
            // 
            // navSeven
            // 
            this.navSeven.Location = new System.Drawing.Point(65, 581);
            this.navSeven.Name = "navSeven";
            this.navSeven.Size = new System.Drawing.Size(75, 23);
            this.navSeven.TabIndex = 36;
            this.navSeven.Text = "7";
            this.navSeven.UseVisualStyleBackColor = true;
            this.navSeven.Click += new System.EventHandler(this.navSeven_Click);
            // 
            // navSix
            // 
            this.navSix.Location = new System.Drawing.Point(227, 552);
            this.navSix.Name = "navSix";
            this.navSix.Size = new System.Drawing.Size(75, 23);
            this.navSix.TabIndex = 35;
            this.navSix.Text = "6";
            this.navSix.UseVisualStyleBackColor = true;
            this.navSix.Click += new System.EventHandler(this.navSix_Click);
            // 
            // navFive
            // 
            this.navFive.Location = new System.Drawing.Point(146, 552);
            this.navFive.Name = "navFive";
            this.navFive.Size = new System.Drawing.Size(75, 23);
            this.navFive.TabIndex = 34;
            this.navFive.Text = "5";
            this.navFive.UseVisualStyleBackColor = true;
            this.navFive.Click += new System.EventHandler(this.navFive_Click);
            // 
            // navFour
            // 
            this.navFour.Location = new System.Drawing.Point(65, 552);
            this.navFour.Name = "navFour";
            this.navFour.Size = new System.Drawing.Size(75, 23);
            this.navFour.TabIndex = 33;
            this.navFour.Text = "4";
            this.navFour.UseVisualStyleBackColor = true;
            this.navFour.Click += new System.EventHandler(this.navFour_Click);
            // 
            // navThree
            // 
            this.navThree.Location = new System.Drawing.Point(227, 523);
            this.navThree.Name = "navThree";
            this.navThree.Size = new System.Drawing.Size(75, 23);
            this.navThree.TabIndex = 32;
            this.navThree.Text = "3";
            this.navThree.UseVisualStyleBackColor = true;
            this.navThree.Click += new System.EventHandler(this.navThree_Click);
            // 
            // navTwo
            // 
            this.navTwo.Location = new System.Drawing.Point(146, 523);
            this.navTwo.Name = "navTwo";
            this.navTwo.Size = new System.Drawing.Size(75, 23);
            this.navTwo.TabIndex = 31;
            this.navTwo.Text = "2";
            this.navTwo.UseVisualStyleBackColor = true;
            this.navTwo.Click += new System.EventHandler(this.navTwo_Click);
            // 
            // navOne
            // 
            this.navOne.Location = new System.Drawing.Point(65, 523);
            this.navOne.Name = "navOne";
            this.navOne.Size = new System.Drawing.Size(75, 23);
            this.navOne.TabIndex = 30;
            this.navOne.Text = "1";
            this.navOne.UseVisualStyleBackColor = true;
            this.navOne.Click += new System.EventHandler(this.navOne_Click);
            // 
            // ComPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(372, 691);
            this.Controls.Add(this.navInputFreq);
            this.Controls.Add(this.navClear);
            this.Controls.Add(this.navDel);
            this.Controls.Add(this.navOk);
            this.Controls.Add(this.navZero);
            this.Controls.Add(this.navNine);
            this.Controls.Add(this.navEight);
            this.Controls.Add(this.navSeven);
            this.Controls.Add(this.navSix);
            this.Controls.Add(this.navFive);
            this.Controls.Add(this.navFour);
            this.Controls.Add(this.navThree);
            this.Controls.Add(this.navTwo);
            this.Controls.Add(this.navOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.navSwap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.navActivceFreq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.navStbyFreq);
            this.Controls.Add(this.navLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butRecon);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFreq);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butZero);
            this.Controls.Add(this.butNine);
            this.Controls.Add(this.butEight);
            this.Controls.Add(this.butSeven);
            this.Controls.Add(this.butSix);
            this.Controls.Add(this.butFive);
            this.Controls.Add(this.butFour);
            this.Controls.Add(this.butThree);
            this.Controls.Add(this.butTwo);
            this.Controls.Add(this.butOne);
            this.Controls.Add(this.butSwap);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.activeFreq);
            this.Controls.Add(this.stbyLabel);
            this.Controls.Add(this.stbyFreq);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "ComPanel";
            this.Text = "FSRadioPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stbyFreq;
        private System.Windows.Forms.Label stbyLabel;
        private System.Windows.Forms.TextBox activeFreq;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Button butSwap;
        private System.Windows.Forms.Button butOne;
        private System.Windows.Forms.Button butTwo;
        private System.Windows.Forms.Button butThree;
        private System.Windows.Forms.Button butFour;
        private System.Windows.Forms.Button butFive;
        private System.Windows.Forms.Button butSix;
        private System.Windows.Forms.Button butSeven;
        private System.Windows.Forms.Button butEight;
        private System.Windows.Forms.Button butNine;
        private System.Windows.Forms.Button butZero;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.TextBox inputFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button butRecon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button navSwap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox navActivceFreq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox navStbyFreq;
        private System.Windows.Forms.TextBox navInputFreq;
        private System.Windows.Forms.Button navClear;
        private System.Windows.Forms.Button navDel;
        private System.Windows.Forms.Button navOk;
        private System.Windows.Forms.Button navZero;
        private System.Windows.Forms.Button navNine;
        private System.Windows.Forms.Button navEight;
        private System.Windows.Forms.Button navSeven;
        private System.Windows.Forms.Button navSix;
        private System.Windows.Forms.Button navFive;
        private System.Windows.Forms.Button navFour;
        private System.Windows.Forms.Button navThree;
        private System.Windows.Forms.Button navTwo;
        private System.Windows.Forms.Button navOne;
    }
}

