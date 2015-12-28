using System.Collections.Generic;
using Lang.Php;

namespace cKernel2PHP
{
    [Page("Index")]
    // ReSharper disable InconsistentNaming
    public class R : PhpDummy
    {
        public int _s { get; set; }
        public List<object[]> _d { get; set; }
        public int _t { get; set; }
        public bool _e { get { return _s.Equals(0); } }
        public string _m { get; set; }
    }
}
