﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leader.bank.domain.Commands
{
    public class InsertNewTransaction
    {
        public int Id_Account { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string TransactionState { get; set; }

    }
}