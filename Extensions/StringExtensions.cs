using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count)
        {

            if(thisObj.Count() <= count) 
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
