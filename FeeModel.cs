using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRANSACTION_FEE_CALCULATOR
{
    public class FeeModel
    {
        public decimal minAmount { get; set; }
        public decimal maxAmount { get; set; }
        public decimal feeAmount { get; set; }
    }
}