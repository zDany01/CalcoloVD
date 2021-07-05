
namespace CalcoloVelocitaDownload
{
    partial class GUIForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FormMenu = new System.Windows.Forms.MenuStrip();
            this.AppStripContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.ReimpostaDatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EsciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "TebiByte",
            "TeraByte",
            "GibiByte",
            "GigaByte",
            "MebiByte",
            "MegaByte"});
            this.comboBox1.Location = new System.Drawing.Point(126, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserire approsimatamente il numero\r\ndi dati da scaricare";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox1.Location = new System.Drawing.Point(6, 68);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox2.Location = new System.Drawing.Point(4, 145);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 21);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GibiByte(GiB/s)",
            "GigaByte(GB/s)",
            "Gigabit(Gb/s)",
            "MebiByte(MiB/s)",
            "MegaByte(MB/s)",
            "Megabit(Mb/s)",
            "KibiByte(KiB/s)",
            "KiloByte(KB/s)",
            "Kilobit(Kb/s)"});
            this.comboBox2.Location = new System.Drawing.Point(118, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inserire una media della velocità di\r\ndownload attuale";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(4, 203);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(220, 77);
            this.textBox3.TabIndex = 8;
            // 
            // FormMenu
            // 
            this.FormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppStripContainer,
            this.InfoToolStripMenuItem1});
            this.FormMenu.Location = new System.Drawing.Point(0, 0);
            this.FormMenu.Name = "FormMenu";
            this.FormMenu.Size = new System.Drawing.Size(231, 24);
            this.FormMenu.TabIndex = 9;
            this.FormMenu.Text = "menuStrip1";
            // 
            // AppStripContainer
            // 
            this.AppStripContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReimpostaDatiToolStripMenuItem,
            this.EsciToolStripMenuItem});
            this.AppStripContainer.Name = "AppStripContainer";
            this.AppStripContainer.Size = new System.Drawing.Size(41, 20);
            this.AppStripContainer.Text = "App";
            // 
            // ReimpostaDatiToolStripMenuItem
            // 
            this.ReimpostaDatiToolStripMenuItem.Name = "ReimpostaDatiToolStripMenuItem";
            this.ReimpostaDatiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ReimpostaDatiToolStripMenuItem.Text = "Reimposta Dati";
            this.ReimpostaDatiToolStripMenuItem.Click += new System.EventHandler(this.ReimpostaDatiToolStripMenuItem_Click);
            // 
            // EsciToolStripMenuItem
            // 
            this.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem";
            this.EsciToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EsciToolStripMenuItem.Text = "Esci";
            this.EsciToolStripMenuItem.Click += new System.EventHandler(this.EsciToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem1
            // 
            this.InfoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoAppToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1";
            this.InfoToolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.InfoToolStripMenuItem1.Text = "?";
            // 
            // infoAppToolStripMenuItem
            // 
            this.infoAppToolStripMenuItem.Name = "infoAppToolStripMenuItem";
            this.infoAppToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.infoAppToolStripMenuItem.Text = "Info App";
            this.infoAppToolStripMenuItem.Click += new System.EventHandler(this.InfoAppToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.LicenseToolStripMenuItem_Click);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 293);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FormMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.FormMenu;
            this.MaximizeBox = false;
            this.Name = "GUIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcolo velocità download";
            this.FormMenu.ResumeLayout(false);
            this.FormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem AppStripContainer;
        private System.Windows.Forms.ToolStripMenuItem ReimpostaDatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EsciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
    }
}

