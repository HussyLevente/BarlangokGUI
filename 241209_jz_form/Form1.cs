using System;

namespace _241209_jz_form
{
    public partial class Form1 : Form
    {
        List<Barlang> lista = new List<Barlang>();
        void betoltes()
        {

            FileStream fs = new FileStream("barlangok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string sor = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Barlang b = new Barlang(sr.ReadLine());
                lista.Add(b);
            }

            sr.Close();
            fs.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btSave.Enabled = false;
            betoltes();
        }

        private void btkeres_Click(object sender, EventArgs e)
        {
            bool b = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (tbAzon.Text.ToString() == lista[i].Azon.ToString())
                {
                    b = true;
                    Nevlb.Text = lista[i].Nev;
                    tbHossz.Text = lista[i].Hossz.ToString();
                    tbMelyseg.Text = lista[i].Melyseg.ToString();
                    btSave.Enabled = true;
                }
            }
            if (b == false)
            {
                MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!", "Hiba!", MessageBoxButtons.OK);
                tbAzon.Clear();
                tbAzon.Focus();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("barlangok.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write($"\n{tbAzon.Text};{Nevlb.Text};{tbHossz.Text};{tbMelyseg};telepules;vedettseg");

            sw.Close();
            fs.Close();
        }

        private void tbHossz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
