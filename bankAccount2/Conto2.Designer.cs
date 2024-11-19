namespace bankAccount2
{
    partial class Conto2
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
            this.listBoxTransazioni = new System.Windows.Forms.ListBox();
            this.lblTransazioniText = new System.Windows.Forms.Label();
            this.lblSaldoText = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblBenvenuto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnPreleva = new System.Windows.Forms.Button();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.txtInvia = new System.Windows.Forms.TextBox();
            this.txtPreleva = new System.Windows.Forms.TextBox();
            this.txtDeposita = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTransazioni
            // 
            this.listBoxTransazioni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBoxTransazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTransazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTransazioni.FormattingEnabled = true;
            this.listBoxTransazioni.ItemHeight = 16;
            this.listBoxTransazioni.Location = new System.Drawing.Point(25, 355);
            this.listBoxTransazioni.Name = "listBoxTransazioni";
            this.listBoxTransazioni.Size = new System.Drawing.Size(249, 80);
            this.listBoxTransazioni.TabIndex = 46;
            // 
            // lblTransazioniText
            // 
            this.lblTransazioniText.AutoSize = true;
            this.lblTransazioniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransazioniText.Location = new System.Drawing.Point(20, 326);
            this.lblTransazioniText.Name = "lblTransazioniText";
            this.lblTransazioniText.Size = new System.Drawing.Size(164, 20);
            this.lblTransazioniText.TabIndex = 45;
            this.lblTransazioniText.Text = "Transazioni di oggi:";
            // 
            // lblSaldoText
            // 
            this.lblSaldoText.AutoSize = true;
            this.lblSaldoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoText.Location = new System.Drawing.Point(158, 95);
            this.lblSaldoText.Name = "lblSaldoText";
            this.lblSaldoText.Size = new System.Drawing.Size(54, 20);
            this.lblSaldoText.TabIndex = 44;
            this.lblSaldoText.Text = "Saldo:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(158, 40);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 24);
            this.lblData.TabIndex = 43;
            this.lblData.Text = "dd/MM/yyyy";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(158, 115);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(66, 24);
            this.lblSaldo.TabIndex = 42;
            this.lblSaldo.Text = "0.00 €";
            // 
            // lblBenvenuto
            // 
            this.lblBenvenuto.AutoSize = true;
            this.lblBenvenuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenvenuto.Location = new System.Drawing.Point(158, 16);
            this.lblBenvenuto.Name = "lblBenvenuto";
            this.lblBenvenuto.Size = new System.Drawing.Size(116, 24);
            this.lblBenvenuto.TabIndex = 41;
            this.lblBenvenuto.Text = "Benvenuto!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bankAccount2.Properties.Resources.pfp1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 123);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(162, 264);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 39;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // btnPreleva
            // 
            this.btnPreleva.Location = new System.Drawing.Point(162, 224);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(75, 23);
            this.btnPreleva.TabIndex = 38;
            this.btnPreleva.Text = "Preleva";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(162, 182);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(75, 23);
            this.btnDeposita.TabIndex = 37;
            this.btnDeposita.Text = "Deposita";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // txtInvia
            // 
            this.txtInvia.Location = new System.Drawing.Point(31, 264);
            this.txtInvia.Name = "txtInvia";
            this.txtInvia.Size = new System.Drawing.Size(100, 20);
            this.txtInvia.TabIndex = 36;
            this.txtInvia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreleva
            // 
            this.txtPreleva.Location = new System.Drawing.Point(31, 224);
            this.txtPreleva.Name = "txtPreleva";
            this.txtPreleva.Size = new System.Drawing.Size(100, 20);
            this.txtPreleva.TabIndex = 35;
            this.txtPreleva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeposita
            // 
            this.txtDeposita.Location = new System.Drawing.Point(31, 182);
            this.txtDeposita.Name = "txtDeposita";
            this.txtDeposita.Size = new System.Drawing.Size(100, 20);
            this.txtDeposita.TabIndex = 34;
            this.txtDeposita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Conto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.listBoxTransazioni);
            this.Controls.Add(this.lblTransazioniText);
            this.Controls.Add(this.lblSaldoText);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblBenvenuto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.btnPreleva);
            this.Controls.Add(this.btnDeposita);
            this.Controls.Add(this.txtInvia);
            this.Controls.Add(this.txtPreleva);
            this.Controls.Add(this.txtDeposita);
            this.Name = "Conto2";
            this.Text = "Conto Api 2";
            this.Load += new System.EventHandler(this.Conto2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTransazioni;
        private System.Windows.Forms.Label lblTransazioniText;
        private System.Windows.Forms.Label lblSaldoText;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblBenvenuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnPreleva;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.TextBox txtInvia;
        private System.Windows.Forms.TextBox txtPreleva;
        private System.Windows.Forms.TextBox txtDeposita;
    }
}