﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginReportTools
{
    [Serializable]
    public class HackData
    {

        public int Key { get; set; }
        public string Game { get; set; }
        public string HackName { get; set; }
        public string HackEAID { get; set; }
        public string PlayerEAID { get; set; }
        public string PlayerName { get; set; }
        public DateTime ReportTime { get; set; }
        public string UUID { get; set; }
        public List<string> HackCheckType { get; set; }
        public string Map { get; set; }
        public string Class { get; set; }
        public string Weapon { get; set; }
        public string K { get; set; }
        public string D { get; set; }
        public string IsBan { get; set; }
        public string IsUpToServer { get; set; }

        public string SaveInfo { get; set; }
        public List<string> NameList{get;set;}
        public string HackFirstName { get; set; }

        public HackData()
        {
            NameList = new List<string>();
            HackCheckType = new List<string>();
        }
    }

}
