using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wpf13
{
    class LongNameCheck: IDataErrorInfo
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;

            }
        }

        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                return GetErrorForProperty(propertyName);
            }
        }

        private string GetErrorForProperty(string propertyName)
        {
            
                    if (name.Length > 10)
                    return "Too long!";


                else return string.Empty;
                
               

            
        }

    }
}
