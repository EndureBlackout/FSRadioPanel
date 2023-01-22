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
            this.SuspendLayout();
            // 
            // stbyFreq
            // 
            this.stbyFreq.BackColor = System.Drawing.SystemColors.Window;
            this.stbyFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.stbyFreq.Location = new System.Drawing.Point(227, 51);
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
            this.stbyLabel.Location = new System.Drawing.Point(227, 20);
            this.stbyLabel.Name = "stbyLabel";
            this.stbyLabel.Size = new System.Drawing.Size(65, 28);
            this.stbyLabel.TabIndex = 1;
            this.stbyLabel.Text = "STBY:";
            // 
            // activeFreq
            // 
            this.activeFreq.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.activeFreq.Location = new System.Drawing.Point(12, 51);
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
            this.activeLabel.Location = new System.Drawing.Point(12, 20);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(77, 28);
            this.activeLabel.TabIndex = 3;
            this.activeLabel.Text = "Active:";
            // 
            // butSwap
            // 
            this.butSwap.ForeColor = System.Drawing.Color.Black;
            this.butSwap.Location = new System.Drawing.Point(154, 51);
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
            this.infoLabel.Location = new System.Drawing.Point(0, 367);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 15);
            this.infoLabel.TabIndex = 20;
            // 
            // butRecon
            // 
            this.butRecon.Location = new System.Drawing.Point(298, 356);
            this.butRecon.Name = "butRecon";
            this.butRecon.Size = new System.Drawing.Size(75, 23);
            this.butRecon.TabIndex = 21;
            this.butRecon.Text = "Reconnect";
            this.butRecon.UseVisualStyleBackColor = true;
            this.butRecon.Visible = false;
            this.butRecon.Click += new System.EventHandler(this.butRecon_Click);
            // 
            // ComPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 381);
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
    }
}

