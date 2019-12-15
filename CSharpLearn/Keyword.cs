using CSHARPLearn;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
     public   class Keyword
    {
        public string Content { get; set; }
        public int Used { get; set; }
        public Keyword Upper { get; set; }
        internal List<Article> Articles { get; set; }

    }
}
