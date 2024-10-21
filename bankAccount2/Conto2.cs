﻿using System;
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
        private decimal saldoAttuale;
        public Conto2()
        {
            InitializeComponent();
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
    }
}
