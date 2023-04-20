using happy0420.Properties;
using System.Runtime.Versioning;

namespace happy0420
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnRogzitClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNev.Text))
            {
                MessageBox.Show(
                   caption: "HIBA!",
                   text: "Nem írtál a névhez semmit..",
                   icon: MessageBoxIcon.Error,
                   buttons: MessageBoxButtons.OK);
            }
            else
            {
                lsbNevek.Items.Add(txtNev.Text);
                txtNev.Clear();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using StreamWriter sw = new($"{Resources.SaveFolder}prg.log");
            {
                foreach (string nev in lsbNevek.Items)
                {
                    sw.WriteLine(nev);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using StreamReader sr = new($"{Resources.SaveFolder}prg.log");
            while (!sr.EndOfStream)
            {
                lsbNevek.Items.Add(sr.ReadLine()!);
            }
        }
    }
}