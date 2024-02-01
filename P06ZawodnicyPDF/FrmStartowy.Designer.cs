namespace P06ZawodnicyPDF
{
    partial class FrmStartowy
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
            this.lblRaport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKraje = new System.Windows.Forms.ComboBox();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnPodglad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(13, 257);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 7;
            this.lblRaport.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kraj";
            // 
            // cbKraje
            // 
            this.cbKraje.FormattingEnabled = true;
            this.cbKraje.Location = new System.Drawing.Point(13, 32);
            this.cbKraje.Name = "cbKraje";
            this.cbKraje.Size = new System.Drawing.Size(241, 21);
            this.cbKraje.TabIndex = 5;
            this.cbKraje.SelectedIndexChanged += new System.EventHandler(this.cbKraje_SelectedIndexChanged);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(13, 59);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(242, 186);
            this.lbDane.TabIndex = 4;
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(261, 91);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 8;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(261, 62);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 9;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnPodglad
            // 
            this.btnPodglad.Location = new System.Drawing.Point(261, 120);
            this.btnPodglad.Name = "btnPodglad";
            this.btnPodglad.Size = new System.Drawing.Size(75, 23);
            this.btnPodglad.TabIndex = 10;
            this.btnPodglad.Text = "Podgląd";
            this.btnPodglad.UseVisualStyleBackColor = true;
            this.btnPodglad.Click += new System.EventHandler(this.btnPodglad_Click);
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 283);
            this.Controls.Add(this.btnPodglad);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKraje);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKraje;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnPodglad;
    }
}

