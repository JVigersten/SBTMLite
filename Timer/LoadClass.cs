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
    class LoadClass
    {
        public static void LoadData(object Load)
        {

            //OpenFileDialog filechooser = new OpenFileDialog();

            //if (filechooser.ShowDialog() == DialogResult.OK)
            //{
            //    if (File.Exists(filechooser.FileName))
            //    {
            //        using (StreamReader fileReader = new StreamReader(filechooser.FileName))
            //        {
            //            while (fileReader.EndOfStream == false)
            //            {
            //                string inputrecord = fileReader.ReadLine().Trim(' ');

            //                if (inputrecord == "<Tester>")
            //                {
            //                    var data = fileReader.ReadLine().Trim(' ');
            //                    TesterInput.Text = data;
            //                }

            //                if (inputrecord == "<Project>")
            //                {
            //                    var data = fileReader.ReadLine().Trim(' ');
            //                    ProjectInput.Text = data;
            //                }

            //                if (inputrecord == "<Area>")
            //                {
            //                    var data = fileReader.ReadLine().Trim(' ');
            //                    AreaInput.Text = data;
            //                }

            //                if (inputrecord == "<Charter>")
            //                {
            //                    var data = fileReader.ReadLine().Trim(' ');
            //                    CharterInput.Text = data;
            //                }

            //                //if (inputrecord == "<Notes>")
            //                //{
            //                //    //int counter = 0;
            //                //    while ((inputrecord = fileReader.ReadLine()) != null)
            //                //    {

            //                //        var data = fileReader.ReadLine();
            //                //        NotesInput.Text = data;
            //                //        //counter++;

            //                //        if (inputrecord == "<Bugs>")
            //                //        {
            //                //            break;
            //                //        }
            //                //    }

            //                //}

            //                //if (inputrecord == "<Bugs>")
            //                //{
            //                //    var data = fileReader.ReadLine().Trim(' ');
            //                //    BugsInput.Text = data;
            //                //}

            //                if (inputrecord == "<Elapsed Time>")
            //                {
            //                    var data = fileReader.ReadLine().Trim(' ');
            //                    var timeParts = data.Split(':');

            //                    hour = int.Parse(timeParts[0]);
            //                    min = int.Parse(timeParts[1]);
            //                    sec = int.Parse(timeParts[2]);

            //                    Counter.Text = FormatNumber(hour) + ":" + FormatNumber(min) + ":" + FormatNumber(sec);
            //                }

            //            }

            //        }
            //    }

            //}
        }
    }
}
