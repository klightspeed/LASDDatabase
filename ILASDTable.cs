﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSVCEO.LASDDatabase
{
    public interface ILASDTable
    {
        string YearLevel { get; }
        string UnitName { get; set; }
        string UnitFocus { get; set; }

        bool AddKLA(string KLA);
        void RemoveKLA(string KLA);

        bool AddRow(Entry entry);
        Entry GetRow(Entry entry);
        bool UpdateRow(Entry entry);
        void RemoveRow(Entry entry);

        IEnumerable<string> GetKLAs();
        IEnumerable<string> GetEnabledKLAs();
        IEnumerable<string> GetAchievementLevels();

        IEnumerable<Term> GetTerms(string kla);

        IEnumerable<Entry> GetEntries(string kla);
        IEnumerable<Entry> GetEntries();

        Group GetKLAGroup(string kla);

        int GetMaxGroupDepth();
    }
}
