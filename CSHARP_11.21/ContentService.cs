using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    class ContentService
    {
        public virtual void Publish(Content content)
        {
            content.Publish();

        }
    }
}
