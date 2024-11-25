using System.ComponentModel.DataAnnotations;

namespace FitnessHub.Data.Entities.Users
{
    public class MembershipDetails : IEntity
    {
        public int Id { get; set; }

        public bool Status { get; set; } = true;

        [Display(Name = "Date of Renewal")]
        public DateTime DateRenewal { get; set; }

        public Membership? Membership { get; set; }

        public DateTime SignUpDate { get; set; }
    }
}
