using LeaveManagemnet.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagemnet.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Display(Name = "Start Date")]
        [Required]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime? EndDate { get; set; }
        [Display(Name = "Leave Types")]

        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Required Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must Be Before End Date ", new[] { nameof(StartDate), nameof(EndDate) });
            }
            if (RequestComments?.Length > 250)
            {
                yield return new ValidationResult("The Comments is Too Long ", new[] { nameof(RequestComments) });

            }
        }
    }
}
