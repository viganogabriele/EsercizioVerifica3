namespace EsercizioVerifica3
{
    partial class Form1
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
            this.lst = new System.Windows.Forms.ListBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.btnFine = new System.Windows.Forms.Button();
            this.btnSorpasso = new System.Windows.Forms.Button();
            this.btnRitiro = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 24;
            this.lst.Location = new System.Drawing.Point(61, 42);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(168, 340);
            this.lst.TabIndex = 0;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(591, 135);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(187, 42);
            this.lblFine.TabIndex = 1;
            this.lblFine.Text = "Punteggio";
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(598, 42);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(123, 55);
            this.btnFine.TabIndex = 2;
            this.btnFine.Text = "Fine Gara";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnSorpasso
            // 
            this.btnSorpasso.Location = new System.Drawing.Point(383, 45);
            this.btnSorpasso.Name = "btnSorpasso";
            this.btnSorpasso.Size = new System.Drawing.Size(123, 48);
            this.btnSorpasso.TabIndex = 3;
            this.btnSorpasso.Text = "Sorpasso";
            this.btnSorpasso.UseVisualStyleBackColor = true;
            this.btnSorpasso.Click += new System.EventHandler(this.btnSorpasso_Click);
            // 
            // btnRitiro
            // 
            this.btnRitiro.Location = new System.Drawing.Point(383, 352);
            this.btnRitiro.Name = "btnRitiro";
            this.btnRitiro.Size = new System.Drawing.Size(123, 48);
            this.btnRitiro.TabIndex = 4;
            this.btnRitiro.Text = "Ritiro";
            this.btnRitiro.UseVisualStyleBackColor = true;
            this.btnRitiro.Click += new System.EventHandler(this.btnRitiro_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(383, 185);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(123, 48);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Pit Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRitiro);
            this.Controls.Add(this.btnSorpasso);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.lst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnSorpasso;
        private System.Windows.Forms.Button btnRitiro;
        private System.Windows.Forms.Button btnStop;
    }
}

