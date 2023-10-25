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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.textHost = new System.Windows.Forms.TextBox();
            this.numerohost = new System.Windows.Forms.Label();
            this.textSot = new System.Windows.Forms.TextBox();
            this.numerosottoreti = new System.Windows.Forms.Label();
            this.butfaitut = new System.Windows.Forms.Button();
            this.classelabel = new System.Windows.Forms.Label();
            this.textclasse = new System.Windows.Forms.TextBox();
            this.BasePriv = new System.Windows.Forms.Label();
            this.BasePrivtext = new System.Windows.Forms.TextBox();
            this.labelsub = new System.Windows.Forms.Label();
            this.subnettext = new System.Windows.Forms.TextBox();
            this.CIDRtext = new System.Windows.Forms.TextBox();
            this.CIDR = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textHost
            // 
            this.textHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHost.Location = new System.Drawing.Point(16, 31);
            this.textHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(267, 23);
            this.textHost.TabIndex = 0;
            // 
            // numerohost
            // 
            this.numerohost.AutoSize = true;
            this.numerohost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerohost.Location = new System.Drawing.Point(12, 11);
            this.numerohost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numerohost.Name = "numerohost";
            this.numerohost.Size = new System.Drawing.Size(190, 17);
            this.numerohost.TabIndex = 1;
            this.numerohost.Text = "Inserisci Numero di Host:";
            // 
            // textSot
            // 
            this.textSot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSot.Location = new System.Drawing.Point(16, 93);
            this.textSot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSot.Name = "textSot";
            this.textSot.Size = new System.Drawing.Size(267, 23);
            this.textSot.TabIndex = 2;
            // 
            // numerosottoreti
            // 
            this.numerosottoreti.AutoSize = true;
            this.numerosottoreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerosottoreti.Location = new System.Drawing.Point(12, 70);
            this.numerosottoreti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numerosottoreti.Name = "numerosottoreti";
            this.numerosottoreti.Size = new System.Drawing.Size(219, 17);
            this.numerosottoreti.TabIndex = 3;
            this.numerosottoreti.Text = "Inserisci Numero di Sottoreti:";
            // 
            // butfaitut
            // 
            this.butfaitut.Location = new System.Drawing.Point(350, 13);
            this.butfaitut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butfaitut.Name = "butfaitut";
            this.butfaitut.Size = new System.Drawing.Size(177, 103);
            this.butfaitut.TabIndex = 4;
            this.butfaitut.Text = "Calcola";
            this.butfaitut.UseVisualStyleBackColor = true;
            this.butfaitut.Click += new System.EventHandler(this.butfaitut_Click);
            // 
            // classelabel
            // 
            this.classelabel.AutoSize = true;
            this.classelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classelabel.Location = new System.Drawing.Point(593, 11);
            this.classelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classelabel.Name = "classelabel";
            this.classelabel.Size = new System.Drawing.Size(116, 17);
            this.classelabel.TabIndex = 5;
            this.classelabel.Text = "Tipo di Classe:";
            // 
            // textclasse
            // 
            this.textclasse.Location = new System.Drawing.Point(596, 31);
            this.textclasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textclasse.Name = "textclasse";
            this.textclasse.Size = new System.Drawing.Size(192, 22);
            this.textclasse.TabIndex = 6;
            // 
            // BasePriv
            // 
            this.BasePriv.AutoSize = true;
            this.BasePriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriv.Location = new System.Drawing.Point(593, 72);
            this.BasePriv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasePriv.Name = "BasePriv";
            this.BasePriv.Size = new System.Drawing.Size(189, 17);
            this.BasePriv.TabIndex = 7;
            this.BasePriv.Text = "Indirizzo di Base Privato:";
            // 
            // BasePrivtext
            // 
            this.BasePrivtext.Location = new System.Drawing.Point(596, 93);
            this.BasePrivtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BasePrivtext.Name = "BasePrivtext";
            this.BasePrivtext.Size = new System.Drawing.Size(192, 22);
            this.BasePrivtext.TabIndex = 8;
            // 
            // labelsub
            // 
            this.labelsub.AutoSize = true;
            this.labelsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsub.Location = new System.Drawing.Point(860, 11);
            this.labelsub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsub.Name = "labelsub";
            this.labelsub.Size = new System.Drawing.Size(64, 17);
            this.labelsub.TabIndex = 9;
            this.labelsub.Text = "Subnet:";
            // 
            // subnettext
            // 
            this.subnettext.Location = new System.Drawing.Point(863, 32);
            this.subnettext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subnettext.Name = "subnettext";
            this.subnettext.Size = new System.Drawing.Size(192, 22);
            this.subnettext.TabIndex = 10;
            // 
            // CIDRtext
            // 
            this.CIDRtext.Location = new System.Drawing.Point(863, 94);
            this.CIDRtext.Margin = new System.Windows.Forms.Padding(4);
            this.CIDRtext.Name = "CIDRtext";
            this.CIDRtext.Size = new System.Drawing.Size(192, 22);
            this.CIDRtext.TabIndex = 11;
            // 
            // CIDR
            // 
            this.CIDR.AutoSize = true;
            this.CIDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIDR.Location = new System.Drawing.Point(860, 69);
            this.CIDR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CIDR.Name = "CIDR";
            this.CIDR.Size = new System.Drawing.Size(49, 17);
            this.CIDR.TabIndex = 12;
            this.CIDR.Text = "CIDR:";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(16, 123);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1039, 428);
            this.listView.TabIndex = 14;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.CIDR);
            this.Controls.Add(this.CIDRtext);
            this.Controls.Add(this.subnettext);
            this.Controls.Add(this.labelsub);
            this.Controls.Add(this.BasePrivtext);
            this.Controls.Add(this.BasePriv);
            this.Controls.Add(this.textclasse);
            this.Controls.Add(this.classelabel);
            this.Controls.Add(this.butfaitut);
            this.Controls.Add(this.numerosottoreti);
            this.Controls.Add(this.textSot);
            this.Controls.Add(this.numerohost);
            this.Controls.Add(this.textHost);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label BasePriv;
        private System.Windows.Forms.TextBox BasePrivtext;
        private System.Windows.Forms.Label labelsub;
        private System.Windows.Forms.TextBox subnettext;
        private System.Windows.Forms.TextBox CIDRtext;
        private System.Windows.Forms.Label CIDR;
        private System.Windows.Forms.ListView listView;
    }
}

