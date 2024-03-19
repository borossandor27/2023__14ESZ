
namespace Tarsashaz
{
    partial class FormNyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNyito));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.épületToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lakóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Epuletek = new System.Windows.Forms.ListBox();
            this.listBox_Lakok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_EpuletId = new System.Windows.Forms.TextBox();
            this.textBox_Utca = new System.Windows.Forms.TextBox();
            this.numericUpDown_hazSzam = new System.Windows.Forms.NumericUpDown();
            this.textBox_LakoId = new System.Windows.Forms.TextBox();
            this.textBox_LakoNev = new System.Windows.Forms.TextBox();
            this.numericUpDown_SzuletesiEv = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hazSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.épületToolStripMenuItem,
            this.lakóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // épületToolStripMenuItem
            // 
            this.épületToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.épületToolStripMenuItem.Name = "épületToolStripMenuItem";
            this.épületToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.épületToolStripMenuItem.Text = "Épület";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // lakóToolStripMenuItem
            // 
            this.lakóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.módosításToolStripMenuItem1,
            this.törlésToolStripMenuItem1});
            this.lakóToolStripMenuItem.Name = "lakóToolStripMenuItem";
            this.lakóToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lakóToolStripMenuItem.Text = "Lakó";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem1.Text = "Új";
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            // 
            // listBox_Epuletek
            // 
            this.listBox_Epuletek.FormattingEnabled = true;
            this.listBox_Epuletek.ItemHeight = 20;
            this.listBox_Epuletek.Location = new System.Drawing.Point(13, 55);
            this.listBox_Epuletek.Name = "listBox_Epuletek";
            this.listBox_Epuletek.Size = new System.Drawing.Size(208, 404);
            this.listBox_Epuletek.TabIndex = 1;
            this.listBox_Epuletek.SelectedIndexChanged += new System.EventHandler(this.listBox_Epuletek_SelectedIndexChanged);
            // 
            // listBox_Lakok
            // 
            this.listBox_Lakok.FormattingEnabled = true;
            this.listBox_Lakok.ItemHeight = 20;
            this.listBox_Lakok.Location = new System.Drawing.Point(522, 55);
            this.listBox_Lakok.Name = "listBox_Lakok";
            this.listBox_Lakok.Size = new System.Drawing.Size(218, 224);
            this.listBox_Lakok.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.numericUpDown_hazSzam);
            this.groupBox1.Controls.Add(this.textBox_Utca);
            this.groupBox1.Controls.Add(this.textBox_EpuletId);
            this.groupBox1.Location = new System.Drawing.Point(244, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott épület";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.numericUpDown_SzuletesiEv);
            this.groupBox2.Controls.Add(this.textBox_LakoNev);
            this.groupBox2.Controls.Add(this.textBox_LakoId);
            this.groupBox2.Location = new System.Drawing.Point(766, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiválasztott lakó";
            // 
            // textBox_EpuletId
            // 
            this.textBox_EpuletId.Location = new System.Drawing.Point(7, 26);
            this.textBox_EpuletId.Name = "textBox_EpuletId";
            this.textBox_EpuletId.ReadOnly = true;
            this.textBox_EpuletId.Size = new System.Drawing.Size(100, 26);
            this.textBox_EpuletId.TabIndex = 0;
            // 
            // textBox_Utca
            // 
            this.textBox_Utca.Location = new System.Drawing.Point(7, 59);
            this.textBox_Utca.Name = "textBox_Utca";
            this.textBox_Utca.Size = new System.Drawing.Size(203, 26);
            this.textBox_Utca.TabIndex = 1;
            // 
            // numericUpDown_hazSzam
            // 
            this.numericUpDown_hazSzam.Location = new System.Drawing.Point(7, 97);
            this.numericUpDown_hazSzam.Name = "numericUpDown_hazSzam";
            this.numericUpDown_hazSzam.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_hazSzam.TabIndex = 2;
            this.numericUpDown_hazSzam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_LakoId
            // 
            this.textBox_LakoId.Location = new System.Drawing.Point(18, 26);
            this.textBox_LakoId.Name = "textBox_LakoId";
            this.textBox_LakoId.ReadOnly = true;
            this.textBox_LakoId.Size = new System.Drawing.Size(100, 26);
            this.textBox_LakoId.TabIndex = 0;
            // 
            // textBox_LakoNev
            // 
            this.textBox_LakoNev.Location = new System.Drawing.Point(18, 64);
            this.textBox_LakoNev.Name = "textBox_LakoNev";
            this.textBox_LakoNev.Size = new System.Drawing.Size(224, 26);
            this.textBox_LakoNev.TabIndex = 1;
            // 
            // numericUpDown_SzuletesiEv
            // 
            this.numericUpDown_SzuletesiEv.Location = new System.Drawing.Point(18, 97);
            this.numericUpDown_SzuletesiEv.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_SzuletesiEv.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_SzuletesiEv.Name = "numericUpDown_SzuletesiEv";
            this.numericUpDown_SzuletesiEv.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_SzuletesiEv.TabIndex = 2;
            this.numericUpDown_SzuletesiEv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_SzuletesiEv.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Lakok);
            this.Controls.Add(this.listBox_Epuletek);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNyito";
            this.Text = "Lakók nyilvántartása";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hazSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem épületToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lakóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox_Lakok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_hazSzam;
        private System.Windows.Forms.TextBox textBox_Utca;
        private System.Windows.Forms.TextBox textBox_EpuletId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzuletesiEv;
        private System.Windows.Forms.TextBox textBox_LakoNev;
        private System.Windows.Forms.TextBox textBox_LakoId;
        public System.Windows.Forms.ListBox listBox_Epuletek;
    }
}

