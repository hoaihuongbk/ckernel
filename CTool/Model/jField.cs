using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTool.Model
{
    public class jField
    {
        public string Field { get; set; }
        public string Name { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool List { get; set; }
        public string Type { get; set; }
        public string Option { get; set; }
        public bool Sorting { get; set; }
        public bool Depend { get; set; }

        public jField()
        {
            Create = true;
            Edit = true;
            List = true;
            Sorting = true;
            Depend = false;
        }
    }
}