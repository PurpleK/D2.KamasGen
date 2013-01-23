namespace D2.KamasGen
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ColorKrypton = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.UserText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PassText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.RbCredit = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.RbPlayer = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.KamasNum = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.GenBt = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LogsText = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.FalseTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ColorKrypton
            // 
            this.ColorKrypton.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(106, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Nom de compte :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 38);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Mot de passe :";
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(124, 12);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(100, 20);
            this.UserText.TabIndex = 2;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(108, 38);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(116, 20);
            this.PassText.TabIndex = 3;
            // 
            // RbCredit
            // 
            this.RbCredit.Location = new System.Drawing.Point(22, 64);
            this.RbCredit.Name = "RbCredit";
            this.RbCredit.Size = new System.Drawing.Size(80, 20);
            this.RbCredit.TabIndex = 4;
            this.RbCredit.Values.Text = "En banque";
            // 
            // RbPlayer
            // 
            this.RbPlayer.Location = new System.Drawing.Point(108, 64);
            this.RbPlayer.Name = "RbPlayer";
            this.RbPlayer.Size = new System.Drawing.Size(121, 20);
            this.RbPlayer.TabIndex = 5;
            this.RbPlayer.Values.Text = "Sur le personnage";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 88);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Kamas :";
            // 
            // KamasNum
            // 
            this.KamasNum.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.KamasNum.Location = new System.Drawing.Point(104, 88);
            this.KamasNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.KamasNum.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.KamasNum.Name = "KamasNum";
            this.KamasNum.Size = new System.Drawing.Size(120, 22);
            this.KamasNum.TabIndex = 7;
            this.KamasNum.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // GenBt
            // 
            this.GenBt.Location = new System.Drawing.Point(12, 116);
            this.GenBt.Name = "GenBt";
            this.GenBt.Size = new System.Drawing.Size(212, 25);
            this.GenBt.TabIndex = 8;
            this.GenBt.Values.Text = "Générer";
            // 
            // LogsText
            // 
            this.LogsText.Location = new System.Drawing.Point(235, 45);
            this.LogsText.Name = "LogsText";
            this.LogsText.Size = new System.Drawing.Size(461, 96);
            this.LogsText.TabIndex = 9;
            this.LogsText.Text = "Données :";
            // 
            // FalseTimer
            // 
            this.FalseTimer.Interval = 3600;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(235, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(461, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 154);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LogsText);
            this.Controls.Add(this.GenBt);
            this.Controls.Add(this.KamasNum);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.RbPlayer);
            this.Controls.Add(this.RbCredit);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Dofus 2";
            this.TextExtra = "Générateur de kamas";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager ColorKrypton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox UserText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PassText;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbCredit;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RbPlayer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown KamasNum;
        private ComponentFactory.Krypton.Toolkit.KryptonButton GenBt;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox LogsText;
        private System.Windows.Forms.Timer FalseTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

