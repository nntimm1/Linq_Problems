using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class StringOrder
    {
        // -------------------------------- Member Variable -------------------------------



        // -------------------------------- Constructor -----------------------------------




        // -------------------------------- Member Method ---------------------------------
        public void StringInOrder()
        {
            string userInput = "Terrill";
            var letterOrder = userInput.ToList();
            var inOrder = letterOrder.OrderBy(c => c.ToString());
        }
    }
}
