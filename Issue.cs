using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE___Municipal_Services_Application
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaFilePath { get; set; }

        public Issue(string location, string category, string description, string mediaFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaFilePath = mediaFilePath;
        }
    }
}
