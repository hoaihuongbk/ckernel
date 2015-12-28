using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vidyano.Core.Extensions;
using Vidyano.Service;
using Vidyano.Service.Repository;

namespace gCoreManager.Service
{
    public class GCORE_001Web : CustomWebController
    {
        // NOTE: This class is used to customize the behavior of the Web client (http://www.vidyano.com/Documentation/customizing-the-web-client)

        public override void GetIndex(StringBuilder html)
        {
		    html.Replace("<title>Vidyano</title>", "<title>gCoreManager</title>");
        }

        public override void GetScripts(StringBuilder scripts)
        {
#if DEBUG
            scripts.Clear();
            scripts.AppendLine(DeveloperScripts);
#endif

            // NOTE: Can be used to append extra custom scripts (inline or embedded resources)
            //AppendEmbeddedResource(scripts, "GCORE_001Web.js");
        }

        public override void GetStyleSheets(StringBuilder styleSheets)
        {
            // NOTE: Can be used to append extra custom style sheets (inline or embedded resources)
            //AppendEmbeddedResource(styleSheets, "GCORE_001Web.css");
        }
    }
}