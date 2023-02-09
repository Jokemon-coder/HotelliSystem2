
namespace HotelliSystem
{
    partial class VarauksetForm
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
            this.varausTB = new System.Windows.Forms.TextBox();
            this.varausLB = new System.Windows.Forms.Label();
            this.lahtoDTP = new System.Windows.Forms.DateTimePicker();
            this.lahtoLB = new System.Windows.Forms.Label();
            this.saapusmisDTP = new System.Windows.Forms.DateTimePicker();
            this.saapumisLB = new System.Windows.Forms.Label();
            this.huoneNumCB = new System.Windows.Forms.ComboBox();
            this.huoneNumLB = new System.Windows.Forms.Label();
            this.tyyppiCB = new System.Windows.Forms.ComboBox();
            this.tyhjBT = new System.Windows.Forms.Button();
            this.poistavarausBT = new System.Windows.Forms.Button();
            this.muovarausBT = new System.Windows.Forms.Button();
            this.lisvarausBT = new System.Windows.Forms.Button();
            this.varauksetDG = new System.Windows.Forms.DataGridView();
            this.asiakasTB = new System.Windows.Forms.TextBox();
            this.huoneTypLB = new System.Windows.Forms.Label();
            this.asiakasLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hallinnoiLB = new System.Windows.Forms.Label();
            this.asiakkaatPN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // asiakkaatPN1
            // 
            this.asiakkaatPN1.BackColor = System.Drawing.Color.Maroon;
            this.asiakkaatPN1.Controls.Add(this.varausTB);
            this.asiakkaatPN1.Controls.Add(this.varausLB);
            this.asiakkaatPN1.Controls.Add(this.lahtoDTP);
            this.asiakkaatPN1.Controls.Add(this.lahtoLB);
            this.asiakkaatPN1.Controls.Add(this.saapusmisDTP);
            this.asiakkaatPN1.Controls.Add(this.saapumisLB);
            this.asiakkaatPN1.Controls.Add(this.huoneNumCB);
            this.asiakkaatPN1.Controls.Add(this.huoneNumLB);
            this.asiakkaatPN1.Controls.Add(this.tyyppiCB);
            this.asiakkaatPN1.Controls.Add(this.tyhjBT);
            this.asiakkaatPN1.Controls.Add(this.poistavarausBT);
            this.asiakkaatPN1.Controls.Add(this.muovarausBT);
            this.asiakkaatPN1.Controls.Add(this.lisvarausBT);
            this.asiakkaatPN1.Controls.Add(this.varauksetDG);
            this.asiakkaatPN1.Controls.Add(this.asiakasTB);
            this.asiakkaatPN1.Controls.Add(this.huoneTypLB);
            this.asiakkaatPN1.Controls.Add(this.asiakasLB);
            this.asiakkaatPN1.Controls.Add(this.panel1);
            this.asiakkaatPN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asiakkaatPN1.Location = new System.Drawing.Point(0, 0);
            this.asiakkaatPN1.Name = "asiakkaatPN1";
            this.asiakkaatPN1.Size = new System.Drawing.Size(884, 511);
            this.asiakkaatPN1.TabIndex = 41;
            // 
            // varausTB
            // 
            this.varausTB.BackColor = System.Drawing.Color.White;
            this.varausTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varausTB.Location = new System.Drawing.Point(190, 90);
            this.varausTB.Name = "varausTB";
            this.varausTB.Size = new System.Drawing.Size(200, 29);
            this.varausTB.TabIndex = 28;
            // 
            // varausLB
            // 
            this.varausLB.AutoSize = true;
            this.varausLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varausLB.ForeColor = System.Drawing.Color.White;
            this.varausLB.Location = new System.Drawing.Point(88, 90);
            this.varausLB.Name = "varausLB";
            this.varausLB.Size = new System.Drawing.Size(96, 25);
            this.varausLB.TabIndex = 27;
            this.varausLB.Text = "Varaus ID:";
            // 
            // lahtoDTP
            // 
            this.lahtoDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lahtoDTP.CustomFormat = "";
            this.lahtoDTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lahtoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lahtoDTP.Location = new System.Drawing.Point(190, 265);
            this.lahtoDTP.Name = "lahtoDTP";
            this.lahtoDTP.Size = new System.Drawing.Size(200, 29);
            this.lahtoDTP.TabIndex = 26;
            // 
            // lahtoLB
            // 
            this.lahtoLB.AutoSize = true;
            this.lahtoLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lahtoLB.ForeColor = System.Drawing.Color.White;
            this.lahtoLB.Location = new System.Drawing.Point(87, 265);
            this.lahtoLB.Name = "lahtoLB";
            this.lahtoLB.Size = new System.Drawing.Size(97, 25);
            this.lahtoLB.TabIndex = 25;
            this.lahtoLB.Text = "Lähtöaika:";
            // 
            // saapusmisDTP
            // 
            this.saapusmisDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saapusmisDTP.CustomFormat = "";
            this.saapusmisDTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saapusmisDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saapusmisDTP.Location = new System.Drawing.Point(190, 230);
            this.saapusmisDTP.Name = "saapusmisDTP";
            this.saapusmisDTP.Size = new System.Drawing.Size(200, 29);
            this.saapusmisDTP.TabIndex = 24;
            // 
            // saapumisLB
            // 
            this.saapumisLB.AutoSize = true;
            this.saapumisLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saapumisLB.ForeColor = System.Drawing.Color.White;
            this.saapumisLB.Location = new System.Drawing.Point(53, 230);
            this.saapumisLB.Name = "saapumisLB";
            this.saapumisLB.Size = new System.Drawing.Size(131, 25);
            this.saapumisLB.TabIndex = 23;
            this.saapumisLB.Text = "Saapumisaika:";
            // 
            // huoneNumCB
            // 
            this.huoneNumCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.huoneNumCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huoneNumCB.FormattingEnabled = true;
            this.huoneNumCB.Location = new System.Drawing.Point(190, 195);
            this.huoneNumCB.Name = "huoneNumCB";
            this.huoneNumCB.Size = new System.Drawing.Size(200, 29);
            this.huoneNumCB.TabIndex = 22;
            // 
            // huoneNumLB
            // 
            this.huoneNumLB.AutoSize = true;
            this.huoneNumLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huoneNumLB.ForeColor = System.Drawing.Color.White;
            this.huoneNumLB.Location = new System.Drawing.Point(46, 195);
            this.huoneNumLB.Name = "huoneNumLB";
            this.huoneNumLB.Size = new System.Drawing.Size(138, 25);
            this.huoneNumLB.TabIndex = 21;
            this.huoneNumLB.Text = "Huonenumero:";
            // 
            // tyyppiCB
            // 
            this.tyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tyyppiCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tyyppiCB.FormattingEnabled = true;
            this.tyyppiCB.Location = new System.Drawing.Point(190, 160);
            this.tyyppiCB.Name = "tyyppiCB";
            this.tyyppiCB.Size = new System.Drawing.Size(200, 29);
            this.tyyppiCB.TabIndex = 20;
            this.tyyppiCB.SelectedIndexChanged += new System.EventHandler(this.tyyppiCB_SelectedIndexChanged);
            // 
            // tyhjBT
            // 
            this.tyhjBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tyhjBT.Location = new System.Drawing.Point(3, 431);
            this.tyhjBT.Name = "tyhjBT";
            this.tyhjBT.Size = new System.Drawing.Size(387, 40);
            this.tyhjBT.TabIndex = 19;
            this.tyhjBT.Text = "Tyhjennä kentät";
            this.tyhjBT.UseVisualStyleBackColor = true;
            this.tyhjBT.Click += new System.EventHandler(this.tyhjBT_Click);
            // 
            // poistavarausBT
            // 
            this.poistavarausBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.poistavarausBT.Location = new System.Drawing.Point(265, 385);
            this.poistavarausBT.Name = "poistavarausBT";
            this.poistavarausBT.Size = new System.Drawing.Size(125, 40);
            this.poistavarausBT.TabIndex = 18;
            this.poistavarausBT.Text = "Poista";
            this.poistavarausBT.UseVisualStyleBackColor = true;
            this.poistavarausBT.Click += new System.EventHandler(this.poistavarausBT_Click);
            // 
            // muovarausBT
            // 
            this.muovarausBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.muovarausBT.Location = new System.Drawing.Point(134, 385);
            this.muovarausBT.Name = "muovarausBT";
            this.muovarausBT.Size = new System.Drawing.Size(125, 40);
            this.muovarausBT.TabIndex = 17;
            this.muovarausBT.Text = "Muokkaa";
            this.muovarausBT.UseVisualStyleBackColor = true;
            this.muovarausBT.Click += new System.EventHandler(this.muovarausBT_Click);
            // 
            // lisvarausBT
            // 
            this.lisvarausBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lisvarausBT.Location = new System.Drawing.Point(3, 385);
            this.lisvarausBT.Name = "lisvarausBT";
            this.lisvarausBT.Size = new System.Drawing.Size(125, 40);
            this.lisvarausBT.TabIndex = 16;
            this.lisvarausBT.Text = "Lisää";
            this.lisvarausBT.UseVisualStyleBackColor = true;
            this.lisvarausBT.Click += new System.EventHandler(this.lisvarausBT_Click);
            // 
            // varauksetDG
            // 
            this.varauksetDG.AllowUserToAddRows = false;
            this.varauksetDG.AllowUserToDeleteRows = false;
            this.varauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDG.Location = new System.Drawing.Point(396, 74);
            this.varauksetDG.Name = "varauksetDG";
            this.varauksetDG.ReadOnly = true;
            this.varauksetDG.RowTemplate.Height = 25;
            this.varauksetDG.Size = new System.Drawing.Size(485, 435);
            this.varauksetDG.TabIndex = 15;
            this.varauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDG_CellClick);
            // 
            // asiakasTB
            // 
            this.asiakasTB.BackColor = System.Drawing.Color.White;
            this.asiakasTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asiakasTB.Location = new System.Drawing.Point(190, 125);
            this.asiakasTB.Name = "asiakasTB";
            this.asiakasTB.Size = new System.Drawing.Size(200, 29);
            this.asiakasTB.TabIndex = 8;
            // 
            // huoneTypLB
            // 
            this.huoneTypLB.AutoSize = true;
            this.huoneTypLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huoneTypLB.ForeColor = System.Drawing.Color.White;
            this.huoneTypLB.Location = new System.Drawing.Point(56, 160);
            this.huoneTypLB.Name = "huoneTypLB";
            this.huoneTypLB.Size = new System.Drawing.Size(128, 25);
            this.huoneTypLB.TabIndex = 2;
            this.huoneTypLB.Text = "Huone tyyppi:";
            // 
            // asiakasLB
            // 
            this.asiakasLB.AutoSize = true;
            this.asiakasLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asiakasLB.ForeColor = System.Drawing.Color.White;
            this.asiakasLB.Location = new System.Drawing.Point(34, 125);
            this.asiakasLB.Name = "asiakasLB";
            this.asiakasLB.Size = new System.Drawing.Size(150, 25);
            this.asiakasLB.TabIndex = 1;
            this.asiakasLB.Text = "Asiakas ktunnus:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.hallinnoiLB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 68);
            this.panel1.TabIndex = 0;
            // 
            // hallinnoiLB
            // 
            this.hallinnoiLB.AutoSize = true;
            this.hallinnoiLB.BackColor = System.Drawing.Color.NavajoWhite;
            this.hallinnoiLB.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hallinnoiLB.ForeColor = System.Drawing.Color.Black;
            this.hallinnoiLB.Location = new System.Drawing.Point(320, 15);
            this.hallinnoiLB.Name = "hallinnoiLB";
            this.hallinnoiLB.Size = new System.Drawing.Size(330, 42);
            this.hallinnoiLB.TabIndex = 0;
            this.hallinnoiLB.Text = "Hallinnoi varauksia";
            // 
            // VarauksetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.asiakkaatPN1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "VarauksetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VarauksetForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VarauksetForm_FormClosing);
            this.Load += new System.EventHandler(this.VarauksetForm_Load);
            this.asiakkaatPN1.ResumeLayout(false);
            this.asiakkaatPN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel asiakkaatPN1;
        private System.Windows.Forms.ComboBox tyyppiCB;
        private System.Windows.Forms.Button tyhjBT;
        private System.Windows.Forms.Button poistavarausBT;
        private System.Windows.Forms.Button muovarausBT;
        private System.Windows.Forms.Button lisvarausBT;
        private System.Windows.Forms.DataGridView varauksetDG;
        private System.Windows.Forms.TextBox asiakasTB;
        private System.Windows.Forms.Label huoneTypLB;
        private System.Windows.Forms.Label asiakasLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hallinnoiLB;
        private System.Windows.Forms.DateTimePicker lahtoDTP;
        private System.Windows.Forms.Label lahtoLB;
        private System.Windows.Forms.DateTimePicker saapusmisDTP;
        private System.Windows.Forms.Label saapumisLB;
        private System.Windows.Forms.ComboBox huoneNumCB;
        private System.Windows.Forms.Label huoneNumLB;
        private System.Windows.Forms.TextBox varausTB;
        private System.Windows.Forms.Label varausLB;
    }
}