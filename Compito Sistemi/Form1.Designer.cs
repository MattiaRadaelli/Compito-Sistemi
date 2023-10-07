namespace Compito_Sistemi
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
            this.textHost = new System.Windows.Forms.TextBox();
            this.numerohost = new System.Windows.Forms.Label();
            this.textSot = new System.Windows.Forms.TextBox();
            this.numerosottoreti = new System.Windows.Forms.Label();
            this.butfaitut = new System.Windows.Forms.Button();
            this.classelabel = new System.Windows.Forms.Label();
            this.textclasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textHost
            // 
            this.textHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHost.Location = new System.Drawing.Point(12, 25);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(201, 20);
            this.textHost.TabIndex = 0;
            // 
            // numerohost
            // 
            this.numerohost.AutoSize = true;
            this.numerohost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerohost.Location = new System.Drawing.Point(9, 9);
            this.numerohost.Name = "numerohost";
            this.numerohost.Size = new System.Drawing.Size(149, 13);
            this.numerohost.TabIndex = 1;
            this.numerohost.Text = "Inserisci Numero di Host:";
            // 
            // textSot
            // 
            this.textSot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSot.Location = new System.Drawing.Point(12, 73);
            this.textSot.Name = "textSot";
            this.textSot.Size = new System.Drawing.Size(201, 20);
            this.textSot.TabIndex = 2;
            // 
            // numerosottoreti
            // 
            this.numerosottoreti.AutoSize = true;
            this.numerosottoreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosottoreti.Location = new System.Drawing.Point(9, 57);
            this.numerosottoreti.Name = "numerosottoreti";
            this.numerosottoreti.Size = new System.Drawing.Size(171, 13);
            this.numerosottoreti.TabIndex = 3;
            this.numerosottoreti.Text = "Inserisci Numero di Sottoreti:";
            // 
            // butfaitut
            // 
            this.butfaitut.Location = new System.Drawing.Point(230, 25);
            this.butfaitut.Name = "butfaitut";
            this.butfaitut.Size = new System.Drawing.Size(93, 68);
            this.butfaitut.TabIndex = 4;
            this.butfaitut.Text = "Calcola";
            this.butfaitut.UseVisualStyleBackColor = true;
            this.butfaitut.Click += new System.EventHandler(this.butfaitut_Click);
            // 
            // classelabel
            // 
            this.classelabel.AutoSize = true;
            this.classelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classelabel.Location = new System.Drawing.Point(366, 9);
            this.classelabel.Name = "classelabel";
            this.classelabel.Size = new System.Drawing.Size(91, 13);
            this.classelabel.TabIndex = 5;
            this.classelabel.Text = "Tipo di Classe:";
            // 
            // textclasse
            // 
            this.textclasse.Location = new System.Drawing.Point(369, 25);
            this.textclasse.Name = "textclasse";
            this.textclasse.Size = new System.Drawing.Size(100, 20);
            this.textclasse.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textclasse);
            this.Controls.Add(this.classelabel);
            this.Controls.Add(this.butfaitut);
            this.Controls.Add(this.numerosottoreti);
            this.Controls.Add(this.textSot);
            this.Controls.Add(this.numerohost);
            this.Controls.Add(this.textHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label numerohost;
        private System.Windows.Forms.TextBox textSot;
        private System.Windows.Forms.Label numerosottoreti;
        private System.Windows.Forms.Button butfaitut;
        private System.Windows.Forms.Label classelabel;
        private System.Windows.Forms.TextBox textclasse;
    }
}

