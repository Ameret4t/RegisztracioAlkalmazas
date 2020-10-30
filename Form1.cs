using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHozzaAd_Click(object sender, EventArgs e)
        {
            string szoveg = textBoxUjHobbi.Text;
            if (String.IsNullOrWhiteSpace(szoveg))
            {
                MessageBox.Show("Üres beviteli mező");
                return;
            }
            if (listBoxHobbik.Items.Contains(szoveg))
            {
                MessageBox.Show("Ez már szerepel");
                return;
            }

            listBoxHobbik.Items.Add(szoveg.Trim());
            textBoxUjHobbi.Text = "";
            textBoxUjHobbi.Focus();
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            string fileName = saveFileDialog1.FileName;

            if (String.IsNullOrWhiteSpace(textBoxNev.Text)){
                MessageBox.Show("Érvénytelen név!");
                return;
            }
            else if (DateTime.Today < dateTimePickerSzulDat.Value){
                MessageBox.Show("Érvénytelen születési dátum!");
                return;
            }
            else if (!(radioButtonNemF.Checked || radioButtonNemN.Checked)){
                MessageBox.Show("Válasszon ki egy nemet!");
                return;
            }
            else if (listBoxHobbik.SelectedIndex<0){
                MessageBox.Show("Válasszon kedvenc hobbit!");
                return;
            }

            try
            {
                using (var sw = new StreamWriter(fileName))
                {
                    foreach (var item in listBoxHobbik.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a mentés során");
            }
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            string fileName = openFileDialog1.FileName;
            try
            {
                using (var sr = new StreamReader(fileName))
                {
                    listBoxHobbik.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        listBoxHobbik.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a betöltés során");
            }
        }
    }
}

