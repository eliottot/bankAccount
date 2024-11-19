using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankAccount2
{
    public partial class Conto2 : Form
    {
        public string percorsoFileDati = @"..\dati2.txt";
        public string percorsoFileScambio = @"..\scambio.txt";
        private decimal saldoAttuale;
        private Timer timer2;
        public Conto2()
        {
            InitializeComponent();
            timer2 = new Timer();

            timer2.Interval = 5000;
            timer2.Tick += checkInvio;
            timer2.Enabled = true;
        }
        private void checkInvio(Object sender, EventArgs e)
        {
            if (File.Exists(percorsoFileScambio))
            {
                try
                {
                    string saldoInviato = File.ReadAllText(percorsoFileScambio);
                    bool contains = saldoInviato.Contains("saldo1");
                    string sRicevuti = saldoInviato.Remove(0, 6);

                    decimal importoRicevuto = 0;
                    if (contains == true) importoRicevuto = Convert.ToDecimal(sRicevuti);
                    else return;

                    saldoAttuale += importoRicevuto;
                    lblSaldo.Text = saldoAttuale.ToString() + " €";
                    DateTime orarioCorrente = DateTime.Now;
                    string orario = orarioCorrente.ToString("HH:mm:ss");
                    listBoxTransazioni.Items.Add($"Hai ricevuto {importoRicevuto}€! ({orario})");

                    File.Delete(percorsoFileScambio);
                    MessageBox.Show("Denaro ricevuto con successo.", "Operazione Avvenuta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nella ricezione: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AggiungiSoldi(decimal importo)
        {
            saldoAttuale += importo;
            AggiornaSaldoFile();
            lblSaldo.Text = saldoAttuale.ToString() + " €";
            MessageBox.Show($"Hai aggiunto {importo}€! Il nuovo saldo è: {saldoAttuale}€", "Saldo Aggiornato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDeposita.Text = null;
            DateTime orarioCorrente = DateTime.Now;
            string orario = orarioCorrente.ToString("HH:mm:ss");
            listBoxTransazioni.Items.Add($"Hai depositato {importo}€! ({orario})");
        }
        private void RimuoviSoldi(decimal importo)
        {
            if (importo <= saldoAttuale)
            {
                saldoAttuale -= importo;
                AggiornaSaldoFile();
                lblSaldo.Text = saldoAttuale.ToString() + " €";
                MessageBox.Show($"Hai rimosso {importo}€! Il nuovo saldo è: {saldoAttuale}€", "Saldo Aggiornato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPreleva.Text = null;
                DateTime orarioCorrente = DateTime.Now;
                string orario = orarioCorrente.ToString("HH:mm:ss");
                listBoxTransazioni.Items.Add($"Hai prelevato {importo}€! ({orario})");
            }
            else
            {
                MessageBox.Show("Non hai abbastanza soldi per questa operazione!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreleva.Text = null;
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
                //MessageBox.Show("Errore durante l'aggiornamento del file: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeposita_Click(object sender, EventArgs e)
        {
            decimal importoDaDepositare = Convert.ToDecimal(txtDeposita.Text);
            AggiungiSoldi(importoDaDepositare);
        }

        private void btnPreleva_Click(object sender, EventArgs e)
        {
            decimal importoDaPrelevare = Convert.ToDecimal(txtPreleva.Text);
            RimuoviSoldi(importoDaPrelevare);
        }

        private void Conto2_Load(object sender, EventArgs e)
        {
            DateTime dataCorrente = DateTime.Now;
            lblData.Text = dataCorrente.ToString("dd/MM/yyyy");
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (File.Exists(percorsoFileScambio))
            {
                MessageBox.Show("File di scambio già esistente. Attendi la prossima operazione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    decimal importoDaInviare = Convert.ToDecimal(txtInvia.Text);

                    if (saldoAttuale < importoDaInviare)
                    {
                        MessageBox.Show("Saldo insufficiente per completare l'operazione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvia.Text = string.Empty;
                    }
                    else
                    {
                        File.WriteAllText(percorsoFileScambio, "saldo2" + importoDaInviare.ToString());

                        saldoAttuale -= importoDaInviare;
                        lblSaldo.Text = saldoAttuale.ToString() + " €";
                        DateTime orarioCorrente = DateTime.Now;
                        string orario = orarioCorrente.ToString("HH:mm:ss");
                        listBoxTransazioni.Items.Add($"Hai inviato {importoDaInviare}€! ({orario})");

                        MessageBox.Show("Denaro inviato con successo.", "Operazione Avvenuta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInvia.Text = string.Empty;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Per favore, inserisci un importo valido.", "Errore di Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInvia.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Si è verificato un errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
