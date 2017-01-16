using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GSN
{
    class GSN_Search
    {
        private string query;
        private string field;
        private DateTime startDate;
        private List<int> profileIDResults;
        private List<string> profileXMLStrings;
        private bool useLive;
        private GSN_Class GSNObject;
        
        public GSN_Search(string query, string field, DateTime startDate, bool useLive)
        {
            this.query = query;
            this.field = field;
            this.startDate = startDate;
            this.profileIDResults = new List<int>();
            this.profileXMLStrings = new List<string>();
            this.useLive = useLive;
            this.GSNObject = new GSN_Class();
        }

        private string apiInterface()
        {
            if (this.useLive)
            {
            }
            return "test";
        }

        
           
    }
}
