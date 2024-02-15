using System.ComponentModel.DataAnnotations;

namespace SArtIntegration.qb.Models.Enums
{
    public class InvoiceTypes
    {
        public enum InvoiceType
        {
            [Display(Name = "SELLING")]
            SELLING,
            [Display(Name = "BUYING")]
            BUYING,
            [Display(Name = "SELLING_RETURN")]
            SELLING_RETURN,
            [Display(Name = "BUYING_RETURN")]
            BUYING_RETURN,
            [Display(Name = "DAMAGED_SELLING_RETURN")]
            DAMAGED_SELLING_RETURN,
            [Display(Name = "DAMAGED_BUYING_RETURN")]
            DAMAGED_BUYING_RETURN,
            [Display(Name = "SELLING_SERVICE")]
            SELLING_SERVICE,
            [Display(Name = "BUYING_SERVICE")]
            BUYING_SERVICE,

        }
    }
}
