using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Models.Enums
{
    public  class TransactionTypes
    {
        public enum TransactionType
        {
            [Display(Name = "CHECK_PAYMENT")]
            CHECK_PAYMENT,
            [Display(Name = "CASH_COLLECTION")]
            CASH_COLLECTION,
            [Display(Name = "CREDIT_CARD_PAYMENT")]
            CREDIT_CARD_PAYMENT,
            [Display(Name = "BANK_TRANSFER_COLLECTION")]
            BANK_TRANSFER_COLLECTION,
            [Display(Name = "BOND_PAYMENT")]
            BOND_PAYMENT,
            [Display(Name = "BOND_COLLECTION")]
            BOND_COLLECTION,
            [Display(Name = "CREDIT_CARD_COLLECTION")]
            CREDIT_CARD_COLLECTION,
            [Display(Name = "CHECK_COLLECTION")]
            CHECK_COLLECTION,
            [Display(Name = "BANK_TRANSFER_PAYMENT")]
            BANK_TRANSFER_PAYMENT,
            [Display(Name = "CASH_PAYMENT")]
            CASH_PAYMENT            


        }
    }
}
