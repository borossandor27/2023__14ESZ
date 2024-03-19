
namespace _2024_01_09_Lakopark
{
    partial class Form_Lakopark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lakopark));
            this.pictureBox_Nevado = new System.Windows.Forms.PictureBox();
            this.panel_Epuletek = new System.Windows.Forms.Panel();
            this.button_balNyil = new System.Windows.Forms.Button();
            this.button_Jobbra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Nevado
            // 
            this.pictureBox_Nevado.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Nevado.Name = "pictureBox_Nevado";
            this.pictureBox_Nevado.Size = new System.Drawing.Size(116, 151);
            this.pictureBox_Nevado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Nevado.TabIndex = 0;
            this.pictureBox_Nevado.TabStop = false;
            // 
            // panel_Epuletek
            // 
            this.panel_Epuletek.Location = new System.Drawing.Point(155, 13);
            this.panel_Epuletek.Name = "panel_Epuletek";
            this.panel_Epuletek.Size = new System.Drawing.Size(633, 270);
            this.panel_Epuletek.TabIndex = 1;
            // 
            // button_balNyil
            // 
            this.button_balNyil.BackgroundImage = global::_2024_01_09_Lakopark.Properties.Resources.balnyil;
            this.button_balNyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_balNyil.Location = new System.Drawing.Point(33, 320);
            this.button_balNyil.Name = "button_balNyil";
            this.button_balNyil.Size = new System.Drawing.Size(115, 69);
            this.button_balNyil.TabIndex = 2;
            this.button_balNyil.UseVisualStyleBackColor = true;
            this.button_balNyil.Click += new System.EventHandler(this.button_balNyil_Click);
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackgroundImage = global::_2024_01_09_Lakopark.Properties.Resources.jobbnyil;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Jobbra.Location = new System.Drawing.Point(216, 320);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(115, 69);
            this.button_Jobbra.TabIndex = 2;
            this.button_Jobbra.UseVisualStyleBackColor = true;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // Form_Lakopark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.button_balNyil);
            this.Controls.Add(this.panel_Epuletek);
            this.Controls.Add(this.pictureBox_Nevado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Lakopark";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Lakopark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Nevado;
        private System.Windows.Forms.Panel panel_Epuletek;
        private System.Windows.Forms.Button button_balNyil;
        private System.Windows.Forms.Button button_Jobbra;
    }
}

