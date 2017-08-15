using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBTMLite
{
    public class Information
    {
        private string TesterData;
        private string ProjectData;
        private string AreaData;
        private string CharterData;
        private string NotesData;
        private string BugsData;
        private string CounterData;

        public string Tester
        {
            get { return TesterData; }
            set { TesterData = value; }
        }

        public string Project
        {
            get { return ProjectData; }
            set { ProjectData = value; }
        }

        public string Area
        {
            get { return AreaData; }
            set { AreaData = value; }
        }

        public string Charter
        {
            get { return CharterData; }
            set { CharterData = value; }
        }

        public string Notes
        {
            get { return NotesData; }
            set { NotesData = value; }
        }

        public string Bugs
        {
            get { return BugsData; }
            set { BugsData = value; }
        }

        public string Elapsed_Time
        {
            get { return CounterData; }
            set { CounterData = value; }
        }

    }
}
