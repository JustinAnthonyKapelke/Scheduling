using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    public class PCB
    {
        #region properties
        /// <summary>
        /// ProcessName er en property i PCB
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// ProcessPriority er en property i PCB
        /// </summary>
        public int ProcessPriority { get; set; }
        #endregion 


        //Override ToString method
        public override string ToString()
        { 
            return $"{ProcessName}({ProcessPriority})";
        }

     
    }
}
