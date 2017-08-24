using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFSDeleteWorkItems
{
    class Utilities
    {
        internal static string ReadException(Exception exception)
        {
            string msg = null;
            if (exception != null)
            {
                msg = "\n";
                msg += exception.GetType() + ": ";
                msg += exception.Message;
                msg += "\n";
                msg += ReadException((exception.InnerException));
            }
            return msg;
        }
    }
}
