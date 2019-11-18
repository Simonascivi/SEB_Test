using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEB_Projektas
{
    public partial class IBANTikrinimas : Form
    {
         LinkedList<string> IBANList=new LinkedList<string>();
         LinkedList<string> IBANShortList = new LinkedList<string>();

        static void Klaida()
        {
            MessageBox.Show("Dėmesio! Programa susidūrė su problema.","Klaida");
        }

        public IBANTikrinimas()
        {
            InitializeComponent();
        }

        private void ivestiRankaButton_Click(object sender, EventArgs e)
        {
            string IBAN = inputIBAN.Text;
            if (IBAN == null)
            {
                Klaida();
            }

            else
            {
                bool tinkamas = TikrintiIBAN(IBAN);
                if (tinkamas)
                {
                    MessageBox.Show("IBAN numeris atitinka reikalavimus ir yra unikalus","IBAN tinkamas");
                }
            }

        }
        bool TikrintiIBAN(string IBAN)
        {
            //Struktūros tikrinimas
            if (IBAN[0] != 'L' || IBAN[1] != 'T'|| IBAN.Length != 18|| IBANShortList.Find(IBAN.Substring(4)) != null)
            {
                IBANList.AddLast(IBAN);
                IBANCheckList.Items.Add(IBAN, false);
                return false;
            }
            IBANList.AddLast(IBAN);
            IBANShortList.AddLast(IBAN.Substring(4));
            IBANCheckList.Items.Add(IBAN, true);
            return true;
        }

        private void PasirinktiButton_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                StreamReader reader = new StreamReader(fileToOpen);
                StreamWriter writer = new StreamWriter(Path.ChangeExtension(fileToOpen, ".out"));
                FailoTikrinimas(reader,writer);
            }
        }
        void FailoTikrinimas(StreamReader reader,StreamWriter writer)
        {
            int blogi = 0;
            int geri = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line != "")
                {
                    if (TikrintiIBAN(line))
                    {
                        writer.WriteLine(line + ";" + "true");
                        writer.Flush();
                        geri++;
                    }
                    else
                    {
                        writer.WriteLine(line + ";" + "false");
                        writer.Flush();
                        blogi++;
                    }
                }
            }
            writer.Close();
            MessageBox.Show("Failo tikrinimas baigtas \n Tinkamų IBAN: "+geri+"\n Netinkamų IBAN: "+blogi);
        }

        private void isvalytiButton_Click(object sender, EventArgs e)
        {
            IBANShortList.Clear();
            IBANList.Clear();
            IBANCheckList.Items.Clear();
        }
    }
}
