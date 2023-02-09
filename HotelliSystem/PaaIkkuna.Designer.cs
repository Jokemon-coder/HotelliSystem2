
namespace HotelliSystem
{
    partial class PaaIkkuna
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
            this.paaikkunaMS = new System.Windows.Forms.MenuStrip();
            this.asiakkaatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huoneetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paaikkunaLB = new System.Windows.Forms.Label();
            this.paaikkunaMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // paaikkunaMS
            // 
            this.paaikkunaMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asiakkaatToolStripMenuItem,
            this.huoneetToolStripMenuItem,
            this.varauksetToolStripMenuItem});
            this.paaikkunaMS.Location = new System.Drawing.Point(0, 0);
            this.paaikkunaMS.Name = "paaikkunaMS";
            this.paaikkunaMS.Size = new System.Drawing.Size(784, 24);
            this.paaikkunaMS.TabIndex = 0;
            this.paaikkunaMS.Text = "menuStrip1";
            // 
            // asiakkaatToolStripMenuItem
            // 
            this.asiakkaatToolStripMenuItem.Name = "asiakkaatToolStripMenuItem";
            this.asiakkaatToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.asiakkaatToolStripMenuItem.Text = "Asiakkaat";
            this.asiakkaatToolStripMenuItem.Click += new System.EventHandler(this.asiakkaatToolStripMenuItem_Click);
            // 
            // huoneetToolStripMenuItem
            // 
            this.huoneetToolStripMenuItem.Name = "huoneetToolStripMenuItem";
            this.huoneetToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.huoneetToolStripMenuItem.Text = "Huoneet";
            this.huoneetToolStripMenuItem.Click += new System.EventHandler(this.huoneetToolStripMenuItem_Click);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.varauksetToolStripMenuItem.Text = "Varaukset";
            this.varauksetToolStripMenuItem.Click += new System.EventHandler(this.varauksetToolStripMenuItem_Click);
            // 
            // paaikkunaLB
            // 
            this.paaikkunaLB.AutoSize = true;
            this.paaikkunaLB.BackColor = System.Drawing.Color.NavajoWhite;
            this.paaikkunaLB.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.paaikkunaLB.ForeColor = System.Drawing.Color.Black;
            this.paaikkunaLB.Location = new System.Drawing.Point(214, 44);
            this.paaikkunaLB.Name = "paaikkunaLB";
            this.paaikkunaLB.Size = new System.Drawing.Size(562, 62);
            this.paaikkunaLB.TabIndex = 1;
            this.paaikkunaLB.Text = "Tervetuloa hotellijärjestelmän huolto-ohjelmaan.\r\nVoit valikosta valita, mitä hal" +
    "uat tehdä.";
            // 
            // PaaIkkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelliSystem.Properties.Resources.paaikkunakuva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.paaikkunaLB);
            this.Controls.Add(this.paaikkunaMS);
            this.MainMenuStrip = this.paaikkunaMS;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 530);
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "PaaIkkuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaaIkkuna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaaIkkuna_FormClosing);
            this.paaikkunaMS.ResumeLayout(false);
            this.paaikkunaMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip paaikkunaMS;
        private System.Windows.Forms.ToolStripMenuItem asiakkaatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huoneetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varauksetToolStripMenuItem;
        private System.Windows.Forms.Label paaikkunaLB;
    }
}