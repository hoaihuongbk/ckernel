using System.Collections.Generic;

// ReSharper disable InconsistentNaming
namespace cModel
{
    public class GCRequest
    {
        public string _a { get; set; }
        public Dictionary<string, object> _c { get; set; }
        public Dictionary<string, object> _d { get; set; } 
        public Dictionary<string, object>[] _mc { get; set; }
        public Dictionary<string, object>[] _md { get; set; }
        public string _f { get; set; }

        public Dictionary<string, string> _od { get; set; }
        public int? _lm { get; set; }
        public int? _os { get; set; }
    }
}
