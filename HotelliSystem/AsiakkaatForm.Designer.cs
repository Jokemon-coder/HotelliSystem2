
namespace HotelliSystem
{
    partial class AsiakkaatForm
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
            this.asiakkaatPN1 = new System.Windows.Forms.Panel();
            this.naytaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.asiakkaatDG = new System.Windows.Forms.DataGridView();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.ktunnusTB = new System.Windows.Forms.TextBox();
            this.ptoimipaikkaTB = new System.Windows.Forms.TextBox();
            this.pnumeroTB = new System.Windows.Forms.TextBox();
            this.osoiteTB = new System.Windows.Forms.TextBox();
            this.sukunimiTB = new System.Windows.Forms.TextBox();
            this.etunimiTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.ktunnusLB = new System.Windows.Forms.Label();
            this.ptoimipaikkaLB = new System.Windows.Forms.Label();
            this.pnumeroLB = new System.Windows.Forms.Label();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.sukunimiLB = new System.Windows.Forms.Label();
            this.etunimiLB = new System.Windows.Forms.Label();
            this.asiakkaatPN2 = new System.Windows.Forms.Panel();
            this.AsiakkaatLB1 = new System.Windows.Forms.Label();
            this.asiakkaatPN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDG)).BeginInit();
            this.asiakkaatPN2.SuspendLayout();
            this.SuspendLayout();
            // 
            // asiakkaatPN1
            // 
            this.asiakkaatPN1.BackColor = System.Drawing.Color.Maroon;
            this.asiakkaatPN1.Controls.Add(this.naytaBT);
            this.asiakkaatPN1.Controls.Add(this.tyhjennaBT);
            this.asiakkaatPN1.Controls.Add(this.poistaBT);
            this.asiakkaatPN1.Controls.Add(this.muokkaaBT);
            this.asiakkaatPN1.Controls.Add(this.lisaaBT);
            this.asiakkaatPN1.Controls.Add(this.asiakkaatDG);
            this.asiakkaatPN1.Controls.Add(this.salasanaTB);
            this.asiakkaatPN1.Controls.Add(this.ktunnusTB);
            this.asiakkaatPN1.Controls.Add(this.ptoimipaikkaTB);
            this.asiakkaatPN1.Controls.Add(this.pnumeroTB);
            this.asiakkaatPN1.Controls.Add(this.osoiteTB);
            this.asiakkaatPN1.Controls.Add(this.sukunimiTB);
            this.asiakkaatPN1.Controls.Add(this.etunimiTB);
            this.asiakkaatPN1.Controls.Add(this.salasanaLB);
            this.asiakkaatPN1.Controls.Add(this.ktunnusLB);
            this.asiakkaatPN1.Controls.Add(this.ptoimipaikkaLB);
            this.asiakkaatPN1.Controls.Add(this.pnumeroLB);
            this.asiakkaatPN1.Controls.Add(this.osoiteLB);
            this.asiakkaatPN1.Controls.Add(this.sukunimiLB);
            this.asiakkaatPN1.Controls.Add(this.etunimiLB);
            this.asiakkaatPN1.Controls.Add(this.asiakkaatPN2);
            this.asiakkaatPN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asiakkaatPN1.Location = new System.Drawing.Point(0, 0);
            this.asiakkaatPN1.Name = "asiakkaatPN1";
            this.asiakkaatPN1.Size = new System.Drawing.Size(984, 511);
            this.asiakkaatPN1.TabIndex = 0;
            // 
            // naytaBT
            // 
            this.naytaBT.BackColor = System.Drawing.Color.LightCoral;
            this.naytaBT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.naytaBT.Location = new System.Drawing.Point(131, 317);
            this.naytaBT.Name = "naytaBT";
            this.naytaBT.Size = new System.Drawing.Size(40, 25);
            this.naytaBT.TabIndex = 20;
            this.naytaBT.Text = "Näy.";
            this.naytaBT.UseVisualStyleBackColor = false;
            this.naytaBT.Click += new System.EventHandler(this.naytaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tyhjennaBT.Location = new System.Drawing.Point(3, 431);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(387, 40);
            this.tyhjennaBT.TabIndex = 19;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.poistaBT.Location = new System.Drawing.Point(265, 385);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(125, 40);
            this.poistaBT.TabIndex = 18;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.muokkaaBT.Location = new System.Drawing.Point(134, 385);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(125, 40);
            this.muokkaaBT.TabIndex = 17;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // lisaaBT
            // 
            this.lisaaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lisaaBT.Location = new System.Drawing.Point(3, 385);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(125, 40);
            this.lisaaBT.TabIndex = 16;
            this.lisaaBT.Text = "Lisää";
            this.lisaaBT.UseVisualStyleBackColor = true;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // asiakkaatDG
            // 
            this.asiakkaatDG.AllowUserToAddRows = false;
            this.asiakkaatDG.AllowUserToDeleteRows = false;
            this.asiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakkaatDG.Location = new System.Drawing.Point(396, 74);
            this.asiakkaatDG.Name = "asiakkaatDG";
            this.asiakkaatDG.ReadOnly = true;
            this.asiakkaatDG.RowTemplate.Height = 25;
            this.asiakkaatDG.Size = new System.Drawing.Size(585, 434);
            this.asiakkaatDG.TabIndex = 15;
            this.asiakkaatDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakkaatDG_CellClick);
            // 
            // salasanaTB
            // 
            this.salasanaTB.BackColor = System.Drawing.Color.White;
            this.salasanaTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaTB.Location = new System.Drawing.Point(177, 317);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(200, 29);
            this.salasanaTB.TabIndex = 14;
            this.salasanaTB.UseSystemPasswordChar = true;
            // 
            // ktunnusTB
            // 
            this.ktunnusTB.BackColor = System.Drawing.Color.White;
            this.ktunnusTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ktunnusTB.Location = new System.Drawing.Point(177, 282);
            this.ktunnusTB.Name = "ktunnusTB";
            this.ktunnusTB.Size = new System.Drawing.Size(200, 29);
            this.ktunnusTB.TabIndex = 13;
            // 
            // ptoimipaikkaTB
            // 
            this.ptoimipaikkaTB.BackColor = System.Drawing.Color.White;
            this.ptoimipaikkaTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ptoimipaikkaTB.Location = new System.Drawing.Point(177, 247);
            this.ptoimipaikkaTB.Name = "ptoimipaikkaTB";
            this.ptoimipaikkaTB.Size = new System.Drawing.Size(200, 29);
            this.ptoimipaikkaTB.TabIndex = 12;
            // 
            // pnumeroTB
            // 
            this.pnumeroTB.BackColor = System.Drawing.Color.White;
            this.pnumeroTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnumeroTB.Location = new System.Drawing.Point(177, 212);
            this.pnumeroTB.Name = "pnumeroTB";
            this.pnumeroTB.Size = new System.Drawing.Size(200, 29);
            this.pnumeroTB.TabIndex = 11;
            // 
            // osoiteTB
            // 
            this.osoiteTB.BackColor = System.Drawing.Color.White;
            this.osoiteTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osoiteTB.Location = new System.Drawing.Point(177, 177);
            this.osoiteTB.Name = "osoiteTB";
            this.osoiteTB.Size = new System.Drawing.Size(200, 29);
            this.osoiteTB.TabIndex = 10;
            // 
            // sukunimiTB
            // 
            this.sukunimiTB.BackColor = System.Drawing.Color.White;
            this.sukunimiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sukunimiTB.Location = new System.Drawing.Point(177, 142);
            this.sukunimiTB.Name = "sukunimiTB";
            this.sukunimiTB.Size = new System.Drawing.Size(200, 29);
            this.sukunimiTB.TabIndex = 9;
            // 
            // etunimiTB
            // 
            this.etunimiTB.BackColor = System.Drawing.Color.White;
            this.etunimiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etunimiTB.Location = new System.Drawing.Point(177, 107);
            this.etunimiTB.Name = "etunimiTB";
            this.etunimiTB.Size = new System.Drawing.Size(200, 29);
            this.etunimiTB.TabIndex = 8;
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaLB.ForeColor = System.Drawing.Color.White;
            this.salasanaLB.Location = new System.Drawing.Point(35, 317);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(90, 25);
            this.salasanaLB.TabIndex = 7;
            this.salasanaLB.Text = "Salasana:";
            // 
            // ktunnusLB
            // 
            this.ktunnusLB.AutoSize = true;
            this.ktunnusLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ktunnusLB.ForeColor = System.Drawing.Color.White;
            this.ktunnusLB.Location = new System.Drawing.Point(30, 282);
            this.ktunnusLB.Name = "ktunnusLB";
            this.ktunnusLB.Size = new System.Drawing.Size(141, 25);
            this.ktunnusLB.TabIndex = 6;
            this.ktunnusLB.Text = "Käyttäjätunnus:";
            // 
            // ptoimipaikkaLB
            // 
            this.ptoimipaikkaLB.AutoSize = true;
            this.ptoimipaikkaLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ptoimipaikkaLB.ForeColor = System.Drawing.Color.White;
            this.ptoimipaikkaLB.Location = new System.Drawing.Point(18, 247);
            this.ptoimipaikkaLB.Name = "ptoimipaikkaLB";
            this.ptoimipaikkaLB.Size = new System.Drawing.Size(153, 25);
            this.ptoimipaikkaLB.TabIndex = 5;
            this.ptoimipaikkaLB.Text = "Postitoimipaikka:";
            // 
            // pnumeroLB
            // 
            this.pnumeroLB.AutoSize = true;
            this.pnumeroLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnumeroLB.ForeColor = System.Drawing.Color.White;
            this.pnumeroLB.Location = new System.Drawing.Point(49, 212);
            this.pnumeroLB.Name = "pnumeroLB";
            this.pnumeroLB.Size = new System.Drawing.Size(122, 25);
            this.pnumeroLB.TabIndex = 4;
            this.pnumeroLB.Text = "Postinumero:";
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osoiteLB.ForeColor = System.Drawing.Color.White;
            this.osoiteLB.Location = new System.Drawing.Point(74, 177);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(98, 25);
            this.osoiteLB.TabIndex = 3;
            this.osoiteLB.Text = "Lähiosoite";
            // 
            // sukunimiLB
            // 
            this.sukunimiLB.AutoSize = true;
            this.sukunimiLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sukunimiLB.ForeColor = System.Drawing.Color.White;
            this.sukunimiLB.Location = new System.Drawing.Point(78, 142);
            this.sukunimiLB.Name = "sukunimiLB";
            this.sukunimiLB.Size = new System.Drawing.Size(94, 25);
            this.sukunimiLB.TabIndex = 2;
            this.sukunimiLB.Text = "Sukunimi:";
            // 
            // etunimiLB
            // 
            this.etunimiLB.AutoSize = true;
            this.etunimiLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.etunimiLB.ForeColor = System.Drawing.Color.White;
            this.etunimiLB.Location = new System.Drawing.Point(92, 107);
            this.etunimiLB.Name = "etunimiLB";
            this.etunimiLB.Size = new System.Drawing.Size(80, 25);
            this.etunimiLB.TabIndex = 1;
            this.etunimiLB.Text = "Etunimi:";
            // 
            // asiakkaatPN2
            // 
            this.asiakkaatPN2.BackColor = System.Drawing.Color.NavajoWhite;
            this.asiakkaatPN2.Controls.Add(this.AsiakkaatLB1);
            this.asiakkaatPN2.Location = new System.Drawing.Point(0, 0);
            this.asiakkaatPN2.Name = "asiakkaatPN2";
            this.asiakkaatPN2.Size = new System.Drawing.Size(984, 68);
            this.asiakkaatPN2.TabIndex = 0;
            // 
            // AsiakkaatLB1
            // 
            this.AsiakkaatLB1.AutoSize = true;
            this.AsiakkaatLB1.BackColor = System.Drawing.Color.NavajoWhite;
            this.AsiakkaatLB1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AsiakkaatLB1.ForeColor = System.Drawing.Color.Black;
            this.AsiakkaatLB1.Location = new System.Drawing.Point(340, 10);
            this.AsiakkaatLB1.Name = "AsiakkaatLB1";
            this.AsiakkaatLB1.Size = new System.Drawing.Size(335, 42);
            this.AsiakkaatLB1.TabIndex = 0;
            this.AsiakkaatLB1.Text = "Hallinnoi asiakkaita";
            // 
            // AsiakkaatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.asiakkaatPN1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "AsiakkaatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsiakkaatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsiakkaatForm_FormClosing);
            this.Load += new System.EventHandler(this.AsiakkaatForm_Load);
            this.asiakkaatPN1.ResumeLayout(false);
            this.asiakkaatPN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDG)).EndInit();
            this.asiakkaatPN2.ResumeLayout(false);
            this.asiakkaatPN2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel asiakkaatPN1;
        private System.Windows.Forms.Panel asiakkaatPN2;
        private System.Windows.Forms.Label AsiakkaatLB1;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button lisaaBT;
        private System.Windows.Forms.DataGridView asiakkaatDG;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox ktunnusTB;
        private System.Windows.Forms.TextBox ptoimipaikkaTB;
        private System.Windows.Forms.TextBox pnumeroTB;
        private System.Windows.Forms.TextBox osoiteTB;
        private System.Windows.Forms.TextBox sukunimiTB;
        private System.Windows.Forms.TextBox etunimiTB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label ktunnusLB;
        private System.Windows.Forms.Label ptoimipaikkaLB;
        private System.Windows.Forms.Label pnumeroLB;
        private System.Windows.Forms.Label osoiteLB;
        private System.Windows.Forms.Label sukunimiLB;
        private System.Windows.Forms.Label etunimiLB;
        private System.Windows.Forms.Button naytaBT;
    }
}