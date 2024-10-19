namespace bankAccount
{
    partial class lblSaldoScritta
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
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnPreleva = new System.Windows.Forms.Button();
            this.btnDeposita = new System.Windows.Forms.Button();
            this.txtInvia = new System.Windows.Forms.TextBox();
            this.txtPreleva = new System.Windows.Forms.TextBox();
            this.txtDeposita = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBenvenuto = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSaldoText = new System.Windows.Forms.Label();
            this.lblSfondo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(155, 269);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 24;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            // 
            // btnPreleva
            // 
            this.btnPreleva.Location = new System.Drawing.Point(155, 229);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(75, 23);
            this.btnPreleva.TabIndex = 23;
            this.btnPreleva.Text = "Preleva";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // btnDeposita
            // 
            this.btnDeposita.Location = new System.Drawing.Point(155, 187);
            this.btnDeposita.Name = "btnDeposita";
            this.btnDeposita.Size = new System.Drawing.Size(75, 23);
            this.btnDeposita.TabIndex = 22;
            this.btnDeposita.Text = "Deposita";
            this.btnDeposita.UseVisualStyleBackColor = true;
            this.btnDeposita.Click += new System.EventHandler(this.btnDeposita_Click);
            // 
            // txtInvia
            // 
            this.txtInvia.Location = new System.Drawing.Point(24, 269);
            this.txtInvia.Name = "txtInvia";
            this.txtInvia.Size = new System.Drawing.Size(100, 20);
            this.txtInvia.TabIndex = 21;
            this.txtInvia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreleva
            // 
            this.txtPreleva.Location = new System.Drawing.Point(24, 229);
            this.txtPreleva.Name = "txtPreleva";
            this.txtPreleva.Size = new System.Drawing.Size(100, 20);
            this.txtPreleva.TabIndex = 20;
            this.txtPreleva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeposita
            // 
            this.txtDeposita.Location = new System.Drawing.Point(24, 187);
            this.txtDeposita.Name = "txtDeposita";
            this.txtDeposita.Size = new System.Drawing.Size(100, 20);
            this.txtDeposita.TabIndex = 19;
            this.txtDeposita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bankAccount.Properties.Resources.pfp1_removebg_preview;
            this.pictureBox1.InitialImage = global::bankAccount.Properties.Resources.pfp1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 123);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblBenvenuto
            // 
            this.lblBenvenuto.AutoSize = true;
            this.lblBenvenuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenvenuto.Location = new System.Drawing.Point(151, 21);
            this.lblBenvenuto.Name = "lblBenvenuto";
            this.lblBenvenuto.Size = new System.Drawing.Size(116, 24);
            this.lblBenvenuto.TabIndex = 26;
            this.lblBenvenuto.Text = "Benvenuto!";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(151, 120);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(66, 24);
            this.lblSaldo.TabIndex = 28;
            this.lblSaldo.Text = "0.00 €";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(151, 45);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 24);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "dd/MM/yyyy";
            // 
            // lblSaldoText
            // 
            this.lblSaldoText.AutoSize = true;
            this.lblSaldoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoText.Location = new System.Drawing.Point(151, 100);
            this.lblSaldoText.Name = "lblSaldoText";
            this.lblSaldoText.Size = new System.Drawing.Size(54, 20);
            this.lblSaldoText.TabIndex = 30;
            this.lblSaldoText.Text = "Saldo:";
            // 
            // lblSfondo
            // 
            this.lblSfondo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSfondo.Location = new System.Drawing.Point(21, 366);
            this.lblSfondo.Name = "lblSfondo";
            this.lblSfondo.Size = new System.Drawing.Size(236, 75);
            this.lblSfondo.TabIndex = 31;
            // 
            // lblSaldoScritta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.lblSfondo);
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
            this.Name = "lblSaldoScritta";
            this.Text = "Conto Api";
            this.Load += new System.EventHandler(this.Conto1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnPreleva;
        private System.Windows.Forms.Button btnDeposita;
        private System.Windows.Forms.TextBox txtInvia;
        private System.Windows.Forms.TextBox txtPreleva;
        private System.Windows.Forms.TextBox txtDeposita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBenvenuto;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSaldoText;
        private System.Windows.Forms.Label lblSfondo;
    }
}