using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearn
{
    class SystemTime
    {
        private static DateTime? _now;
        public static DateTime Now()
        {
            if (!_now.HasValue)
            {
                return DateTime.Now;
            }
            else
            {
                return _now.Value;
            }
        }
        public void SetTime(DateTime now)
        {
           _now = now;
        }
    }
}
