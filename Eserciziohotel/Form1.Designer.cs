namespace Eserciziohotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_n1 = new System.Windows.Forms.Button();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.pct_n1 = new System.Windows.Forms.PictureBox();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.cmb_n3 = new System.Windows.Forms.ComboBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_n1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(39, 301);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(110, 54);
            this.btn_n1.TabIndex = 0;
            this.btn_n1.Text = "PRENOTA";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // cmb_n1
            // 
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "Base (B)",
            "Media (M)",
            "Alta (A)"});
            this.cmb_n1.Location = new System.Drawing.Point(39, 133);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(110, 21);
            this.cmb_n1.TabIndex = 2;
            this.cmb_n1.Text = "Tipo stanza:";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_n1.Location = new System.Drawing.Point(33, 47);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(239, 33);
            this.lbl_n1.TabIndex = 3;
            this.lbl_n1.Text = "Hotel L\'Oasi della Luce";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_n2.Location = new System.Drawing.Point(111, 80);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(84, 22);
            this.lbl_n2.TabIndex = 4;
            this.lbl_n2.Text = "Benvenuto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenota una camera:";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(36, 216);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(147, 13);
            this.lbl_n4.TabIndex = 6;
            this.lbl_n4.Text = "Qanti giorni vuoi soggiornare?";
            // 
            // pct_n1
            // 
            this.pct_n1.Image = ((System.Drawing.Image)(resources.GetObject("pct_n1.Image")));
            this.pct_n1.Location = new System.Drawing.Point(228, 117);
            this.pct_n1.Name = "pct_n1";
            this.pct_n1.Size = new System.Drawing.Size(259, 165);
            this.pct_n1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_n1.TabIndex = 7;
            this.pct_n1.TabStop = false;
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Location = new System.Drawing.Point(39, 278);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(80, 17);
            this.chk_n1.TabIndex = 8;
            this.chk_n1.Text = "Parcheggio";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // cmb_n3
            // 
            this.cmb_n3.FormattingEnabled = true;
            this.cmb_n3.Items.AddRange(new object[] {
            "Bassa Stagione (BS)",
            "Media Stagione (MS)",
            "Alta Stagione (AS)"});
            this.cmb_n3.Location = new System.Drawing.Point(39, 183);
            this.cmb_n3.Name = "cmb_n3";
            this.cmb_n3.Size = new System.Drawing.Size(110, 21);
            this.cmb_n3.TabIndex = 9;
            this.cmb_n3.Text = "Stagione:";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Location = new System.Drawing.Point(36, 167);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(167, 13);
            this.lbl_n5.TabIndex = 10;
            this.lbl_n5.Text = "In che stagione vuoi soggiornare?";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(39, 232);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(110, 20);
            this.txt_n1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.cmb_n3);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.pct_n1);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.btn_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_n1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.ComboBox cmb_n1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.PictureBox pct_n1;
        private System.Windows.Forms.CheckBox chk_n1;
        private System.Windows.Forms.ComboBox cmb_n3;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.TextBox txt_n1;
    }
}

