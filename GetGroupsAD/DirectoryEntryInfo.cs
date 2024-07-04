using System;
using System.Collections.Generic;

namespace GetGroupsAD
{
    public class DirectoryEntryInfo
    {
        public String ID { get; set; }
        public String Text { get; set; }
        public bool Checked { get; set; }
        public String Path { get; set; }

        public bool Expanded { get; set; }
        public DirectoryEntryInfo Parent { get; set; }
        public List<DirectoryEntryInfo> Items { get; set; }
    }
}
