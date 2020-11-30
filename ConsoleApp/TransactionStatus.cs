using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    public enum TransactionStatus
    {
        [Display(Name = "Pending")]
        Pending = 0,
        [Display(Name = "In Progress")]
        InProgress = 1,
        [Display(Name = "Completed")]
        Completed = 2,
        [Display(Name = "Cancelled")]
        Cancelled = 3,
        [Display(Name = "For Approval")]
        ForApproval = 4
    }
}