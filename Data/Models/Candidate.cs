namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;

    public class Candidate : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        public Candidate()
        {
            this.Skills = new HashSet<CandidateSkill>();
        }

        [Required(ErrorMessage = nameof(FirstName) + " should not be empty or null.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = nameof(LastName) + " should not be empty or null.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = nameof(Birthdate) + " should not be empty or null.")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = nameof(Email) + " should not be empty or null.")]
        public string Email { get; set; }

        [Required(ErrorMessage = nameof(Bio) + " should not be empty or null.")]
        public string Bio { get; set; }

        public virtual ICollection<CandidateSkill> Skills { get; set; }

        [Required(ErrorMessage = nameof(Recruiter) + " should not be empty or null.")]
        public Recruiter Recruiter { get; set; }
    }
}
