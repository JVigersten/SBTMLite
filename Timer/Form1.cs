using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace SBTMLite
{
    public partial class SBTMLite : Form
    {
        public SBTMLite()
        {
            InitializeComponent();
        }

        int hour, min, sec = 0;

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            Timer1_Tick(null, null);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sec++;

            Counter.Text = FormatNumber(hour) + ":" + FormatNumber(min) + ":" + FormatNumber(sec);
            
            if (sec > 59)
            {
                min++;
                sec = 0;
            }

            if (min > 59)
            {
                hour++;
                min = 0;
            }
            
        }

        private string FormatNumber (int x)
        {
            if (x < 10) return "0" + x;
            return x.ToString();
                
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            sec = 0;
            min = 0;
            hour = 0;
            Counter.Text = "00:00:00";
            TesterInput.Text = "".ToString();
            ProjectInput.Text = "".ToString();
            AreaInput.Text = "".ToString();
            CharterInput.Text = "".ToString();
            NotesInput.Text = "".ToString();
            BugsInput.Text = "".ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AreaInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TesterInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharterInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotesInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BugsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Counter_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            timer1.Stop();

            try
            {

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = {
                        "Tester: " + Environment.NewLine + TesterInput.Text + Environment.NewLine,
                        "Project: " + Environment.NewLine + ProjectInput.Text + Environment.NewLine,
                        "Area: " + Environment.NewLine + AreaInput.Text + Environment.NewLine,
                        "Charter: " + Environment.NewLine + CharterInput.Text + Environment.NewLine,
                        "Notes: " + Environment.NewLine + NotesInput.Text.Replace("\n", Environment.NewLine) + Environment.NewLine,
                        "Bugs: " + Environment.NewLine + BugsInput.Text.Replace("\n", Environment.NewLine) + Environment.NewLine,
                        "Counter: " + Environment.NewLine + Counter.Text + Environment.NewLine };

                File.WriteAllLines(saveFileDialog1.FileName, lines);
            };


        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}
    }
}