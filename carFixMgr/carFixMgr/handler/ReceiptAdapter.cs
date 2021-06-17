using carFixMgr.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr.handler
{
    class ReceiptAdapter
    {
        private List<Receipt> receiptList = new List<Receipt>();

        public Receipt receipt { get; private set; }

        public void addReceipt()
        {
            receiptList.Add(receipt);
        }

        public void viewReceipt()
        {

        }
    }

    
}
