﻿using System.Collections.Generic;

namespace Coevery.Projections.ViewModels {
    public class BindingSelectViewModel {
        public IList<RecordEntry> Records { get; set; }
    }

    public class RecordEntry {
        public string FullName { get; set; }
        public IList<MemberEntry> Members { get; set; }
    }

    public class MemberEntry {
        public string Member { get; set; }
    }
}
