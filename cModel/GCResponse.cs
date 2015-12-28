using System.Collections.Generic;

namespace cModel
{
    public class GCResponse
    {
        public int Result { get; set; }
        public List<object[]> Records { get; set; }
        public int TotalRecordCount { get; set; }
        public string Message { get; set; }
    }
}
