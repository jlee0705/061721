using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr.model
{
    class RepairItem
    {
        private int idx;
        private string repair;
        private int price;

        public RepairItem(int idx, string repair, int price)
        {
            this.idx = idx;
            this.repair = repair;
            this.price = price;
        }
    }
}
