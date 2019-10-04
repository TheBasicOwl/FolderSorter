﻿namespace FolderSorterV2.Data.Models
{
    public class Rule
    {
        public string OutputFolder { get; set; }
        public string Regex { get; set; }
        public ushort Priority { get; set; } = 1;
    }
}
