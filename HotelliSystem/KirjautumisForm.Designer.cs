
namespace HotelliSystem
{
    partial class KirjautumisForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naytaBT = new System.Windows.Forms.Button();
            this.kirjauduBT = new System.Windows.Forms.Button();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelliSystem.Properties.Resources.kirjautumiskuva;
            this.pictureBox1.Location = new System.Drawing.Point(74, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.naytaBT);
            this.groupBox1.Controls.Add(this.kirjauduBT);
            this.groupBox1.Controls.Add(this.salasanaLB);
            this.groupBox1.Controls.Add(this.salasanaTB);
            this.groupBox1.Controls.Add(this.kayttajaTB);
            this.groupBox1.Controls.Add(this.kayttajaLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // naytaBT
            // 
            this.naytaBT.BackColor = System.Drawing.Color.NavajoWhite;
            this.naytaBT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.naytaBT.Location = new System.Drawing.Point(113, 66);
            this.naytaBT.Name = "naytaBT";
            this.naytaBT.Size = new System.Drawing.Size(40, 25);
            this.naytaBT.TabIndex = 5;
            this.naytaBT.Text = "Näy.";
            this.naytaBT.UseVisualStyleBackColor = false;
            this.naytaBT.Click += new System.EventHandler(this.naytaBT_Click);
            // 
            // kirjauduBT
            // 
            this.kirjauduBT.BackColor = System.Drawing.Color.NavajoWhite;
            this.kirjauduBT.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kirjauduBT.Location = new System.Drawing.Point(5, 106);
            this.kirjauduBT.Name = "kirjauduBT";
            this.kirjauduBT.Size = new System.Drawing.Size(384, 53);
            this.kirjauduBT.TabIndex = 4;
            this.kirjauduBT.Text = "Kirjaudu sisään";
            this.kirjauduBT.UseVisualStyleBackColor = false;
            this.kirjauduBT.Click += new System.EventHandler(this.kirjauduBT_Click);
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaLB.ForeColor = System.Drawing.Color.Black;
            this.salasanaLB.Location = new System.Drawing.Point(3, 60);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(110, 32);
            this.salasanaLB.TabIndex = 3;
            this.salasanaLB.Text = "Salasana:";
            // 
            // salasanaTB
            // 
            this.salasanaTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaTB.Location = new System.Drawing.Point(159, 63);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(225, 29);
            this.salasanaTB.TabIndex = 2;
            this.salasanaTB.UseSystemPasswordChar = true;
            this.salasanaTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salasanaTB_KeyDown);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayttajaTB.Location = new System.Drawing.Point(159, 31);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(225, 29);
            this.kayttajaTB.TabIndex = 1;
            this.kayttajaTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kayttajaTB_KeyDown);
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayttajaLB.ForeColor = System.Drawing.Color.Black;
            this.kayttajaLB.Location = new System.Drawing.Point(3, 28);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(150, 32);
            this.kayttajaLB.TabIndex = 0;
            this.kayttajaLB.Text = "Käyttäjänimi:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            this.tietojaToolStripMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // KirjautumisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(414, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 500);
            this.MinimumSize = new System.Drawing.Size(430, 500);
            this.Name = "KirjautumisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KirjautumisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KirjautumisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kayttajaLB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Button kirjauduBT;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.Button naytaBT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
    }
}