using System.Collections.Generic;
using Lang.Php;

namespace cKernel2PHP
{
    [Page("Index")]
    public class GCResponse : PhpDummy
    {
        public int Result { get; set; }
        public List<object[]> Records { get; set; }
        public int TotalRecordCount { get; set; }
        public string Message { get; set; }
    }
}
