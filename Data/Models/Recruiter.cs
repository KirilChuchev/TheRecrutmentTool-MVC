namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;

    public class Recruiter : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        [Required(ErrorMessage = nameof(LastName) + " should not be empty or null.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = nameof(Email) + " should not be empty or null.")]
        public string Email { get; set; }

        [Required(ErrorMessage = nameof(Country) + " should not be empty or null.")]
        public string Country { get; set; }

        public int InterviewSlots { get; set; } = 5;

        public int ExperienceLevel { get; set; } = 1;
    }
}
