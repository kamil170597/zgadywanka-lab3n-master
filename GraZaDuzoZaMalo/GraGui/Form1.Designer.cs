namespace GraGui
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NowaGra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZakresOd = new System.Windows.Forms.Label();
            this.textBoxod = new System.Windows.Forms.TextBox();
            this.textBoxdo = new System.Windows.Forms.TextBox();
            this.ZakresDo = new System.Windows.Forms.Label();
            this.Losuj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(13, 13);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 23);
            this.NowaGra.TabIndex = 0;
            this.NowaGra.Text = "NowaGra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Losuj);
            this.groupBox1.Controls.Add(this.textBoxdo);
            this.groupBox1.Controls.Add(this.ZakresDo);
            this.groupBox1.Controls.Add(this.textBoxod);
            this.groupBox1.Controls.Add(this.ZakresOd);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // ZakresOd
            // 
            this.ZakresOd.AutoSize = true;
            this.ZakresOd.Location = new System.Drawing.Point(7, 20);
            this.ZakresOd.Name = "ZakresOd";
            this.ZakresOd.Size = new System.Drawing.Size(57, 13);
            this.ZakresOd.TabIndex = 0;
            this.ZakresOd.Text = "Zakres Od";
            // 
            // textBoxod
            // 
            this.textBoxod.Location = new System.Drawing.Point(70, 20);
            this.textBoxod.Name = "textBoxod";
            this.textBoxod.Size = new System.Drawing.Size(100, 20);
            this.textBoxod.TabIndex = 1;
            // 
            // textBoxdo
            // 
            this.textBoxdo.Location = new System.Drawing.Point(70, 59);
            this.textBoxdo.Name = "textBoxdo";
            this.textBoxdo.Size = new System.Drawing.Size(100, 20);
            this.textBoxdo.TabIndex = 3;
            // 
            // ZakresDo
            // 
            this.ZakresDo.AutoSize = true;
            this.ZakresDo.Location = new System.Drawing.Point(7, 59);
            this.ZakresDo.Name = "ZakresDo";
            this.ZakresDo.Size = new System.Drawing.Size(57, 13);
            this.ZakresDo.TabIndex = 2;
            this.ZakresDo.Text = "Zakres Do";
            // 
            // Losuj
            // 
            this.Losuj.Location = new System.Drawing.Point(205, 59);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(75, 23);
            this.Losuj.TabIndex = 2;
            this.Losuj.Text = "Wylosuj";
            this.Losuj.UseVisualStyleBackColor = true;
            this.Losuj.Click += new System.EventHandler(this.Losuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxdo;
        private System.Windows.Forms.Label ZakresDo;
        private System.Windows.Forms.TextBox textBoxod;
        private System.Windows.Forms.Label ZakresOd;
        private System.Windows.Forms.Button Losuj;
    }
}

