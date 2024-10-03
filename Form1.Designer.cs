namespace sportolok_20241003
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txnev = new System.Windows.Forms.TextBox();
            this.txelet = new System.Windows.Forms.TextBox();
            this.bthozzad = new System.Windows.Forms.Button();
            this.btletszam = new System.Windows.Forms.Button();
            this.btatlag = new System.Windows.Forms.Button();
            this.btlgf = new System.Windows.Forms.Button();
            this.btlgi = new System.Windows.Forms.Button();
            this.btmentes = new System.Windows.Forms.Button();
            this.btkilep = new System.Windows.Forms.Button();
            this.rtxadat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Életkor: ";
            // 
            // txnev
            // 
            this.txnev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txnev.Location = new System.Drawing.Point(60, 34);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(152, 20);
            this.txnev.TabIndex = 2;
            // 
            // txelet
            // 
            this.txelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txelet.Location = new System.Drawing.Point(76, 76);
            this.txelet.Name = "txelet";
            this.txelet.Size = new System.Drawing.Size(100, 20);
            this.txelet.TabIndex = 3;
            // 
            // bthozzad
            // 
            this.bthozzad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bthozzad.Location = new System.Drawing.Point(32, 138);
            this.bthozzad.Name = "bthozzad";
            this.bthozzad.Size = new System.Drawing.Size(168, 66);
            this.bthozzad.TabIndex = 4;
            this.bthozzad.Text = "Hozzáadás";
            this.bthozzad.UseVisualStyleBackColor = false;
            this.bthozzad.Click += new System.EventHandler(this.bthozzad_Click);
            // 
            // btletszam
            // 
            this.btletszam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btletszam.Location = new System.Drawing.Point(18, 390);
            this.btletszam.Name = "btletszam";
            this.btletszam.Size = new System.Drawing.Size(144, 37);
            this.btletszam.TabIndex = 5;
            this.btletszam.Text = "Gyermek csapat létszáma";
            this.btletszam.UseVisualStyleBackColor = false;
            this.btletszam.Click += new System.EventHandler(this.btletszam_Click);
            // 
            // btatlag
            // 
            this.btatlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btatlag.Location = new System.Drawing.Point(18, 338);
            this.btatlag.Name = "btatlag";
            this.btatlag.Size = new System.Drawing.Size(144, 37);
            this.btatlag.TabIndex = 6;
            this.btatlag.Text = "Átlag életkor";
            this.btatlag.UseVisualStyleBackColor = false;
            this.btatlag.Click += new System.EventHandler(this.btatlag_Click);
            // 
            // btlgf
            // 
            this.btlgf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btlgf.Location = new System.Drawing.Point(179, 338);
            this.btlgf.Name = "btlgf";
            this.btlgf.Size = new System.Drawing.Size(144, 37);
            this.btlgf.TabIndex = 8;
            this.btlgf.Text = "Legfiatalabb játékos";
            this.btlgf.UseVisualStyleBackColor = false;
            this.btlgf.Click += new System.EventHandler(this.btlgf_Click);
            // 
            // btlgi
            // 
            this.btlgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btlgi.Location = new System.Drawing.Point(179, 390);
            this.btlgi.Name = "btlgi";
            this.btlgi.Size = new System.Drawing.Size(144, 37);
            this.btlgi.TabIndex = 7;
            this.btlgi.Text = "Legidősebb játékos";
            this.btlgi.UseVisualStyleBackColor = false;
            this.btlgi.Click += new System.EventHandler(this.btlgi_Click);
            // 
            // btmentes
            // 
            this.btmentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btmentes.Location = new System.Drawing.Point(340, 338);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(129, 89);
            this.btmentes.TabIndex = 9;
            this.btmentes.Text = "Szakosztály sportolóinak mentése";
            this.btmentes.UseVisualStyleBackColor = false;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // btkilep
            // 
            this.btkilep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btkilep.Location = new System.Drawing.Point(562, 338);
            this.btkilep.Name = "btkilep";
            this.btkilep.Size = new System.Drawing.Size(129, 89);
            this.btkilep.TabIndex = 10;
            this.btkilep.Text = "Kilépés";
            this.btkilep.UseVisualStyleBackColor = false;
            this.btkilep.Click += new System.EventHandler(this.btkilep_Click);
            // 
            // rtxadat
            // 
            this.rtxadat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtxadat.Enabled = false;
            this.rtxadat.Location = new System.Drawing.Point(260, 12);
            this.rtxadat.Name = "rtxadat";
            this.rtxadat.Size = new System.Drawing.Size(473, 301);
            this.rtxadat.TabIndex = 11;
            this.rtxadat.Text = "";
            this.rtxadat.TextChanged += new System.EventHandler(this.rtxadat_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(756, 452);
            this.Controls.Add(this.rtxadat);
            this.Controls.Add(this.btkilep);
            this.Controls.Add(this.btmentes);
            this.Controls.Add(this.btlgf);
            this.Controls.Add(this.btlgi);
            this.Controls.Add(this.btatlag);
            this.Controls.Add(this.btletszam);
            this.Controls.Add(this.bthozzad);
            this.Controls.Add(this.txelet);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sportolói jegyzék";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.TextBox txelet;
        private System.Windows.Forms.Button bthozzad;
        private System.Windows.Forms.Button btletszam;
        private System.Windows.Forms.Button btatlag;
        private System.Windows.Forms.Button btlgf;
        private System.Windows.Forms.Button btlgi;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.Button btkilep;
        private System.Windows.Forms.RichTextBox rtxadat;
    }
}

