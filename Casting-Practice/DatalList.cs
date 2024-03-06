using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Practice
{
    internal class DatalList
    {
        public string[] datas=new string[10];
        public string this[int index]
        {
            get
            {
                return datas[index];
            }
            set
            {
                datas[index] = value;
            }
        }
    }
}
