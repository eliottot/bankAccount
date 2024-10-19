using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bankAccount
{
    public partial class Login1 : Form
    {
        public string percorsoFileDati = @"C:\Users\eliad\source\repos\bankAccount\dati.txt";
        private decimal saldoAttuale;
        public Login1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            StreamReader reader = new StreamReader(percorsoFileDati);

            string saldo = LoginAndSaldo(username, password);
            if (saldo != null)
            {
                MessageBox.Show($"Login effettuato! Benvenuto!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saldoAttuale = decimal.Parse(saldo);
                Conto1 Conto1 = new Conto1();
                this.Hide();
                Conto1.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Credenziali errate, riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = null;
                txtPassword.Text = null;
            }
        }
        private string LoginAndSaldo(string username, string password)
        {
            try
            {
                if (File.Exists(percorsoFileDati))
                {
                    string[] lines = File.ReadAllLines(percorsoFileDati);

                    if (lines.Length >= 3)
                    {
                        string datiUsername = lines[0];
                        string datiPassword = lines[1];
                        string datiSaldo = lines[2];

                        if (datiUsername == username && datiPassword == password)
                        {
                            return datiSaldo;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File delle credenziali non trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la lettura del file: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        private void AggiungiSoldi(decimal importo)
        {
            saldoAttuale += importo;
            AggiornaSaldoFile();
            MessageBox.Show($"Hai aggiunto {importo}€! Il nuovo saldo è: {saldoAttuale}€", "Saldo Aggiornato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RimuoviSoldi(decimal importo)
        {
            if (importo <= saldoAttuale)
            {
                saldoAttuale -= importo;
                AggiornaSaldoFile();
                MessageBox.Show($"Hai rimosso {importo}€! Il nuovo saldo è: {saldoAttuale}€", "Saldo Aggiornato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non hai abbastanza soldi per questa operazione!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AggiornaSaldoFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(percorsoFileDati);
                if (lines.Length >= 3)
                {
                    lines[2] = saldoAttuale.ToString();
                    File.WriteAllLines(percorsoFileDati, lines);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiornamento del file: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}