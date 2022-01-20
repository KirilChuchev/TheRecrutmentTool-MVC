namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;

    public class Job : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        public Job()
        {
            this.Skills = new HashSet<JobSkill>();
            this.Interviews = new HashSet<Interview>();
        }

        [Required(ErrorMessage = nameof(Title) + " should not be empty or null.")]
        public string Title { get; set; }

        [Required(ErrorMessage = nameof(Salary) + " should not be empty or null.")]
        public double Salary { get; set; }

        [Required(ErrorMessage = nameof(Description) + " should not be empty or null.")]
        public string Description { get; set; }

        public virtual ICollection<JobSkill> Skills { get; set; }

        public virtual ICollection<Interview> Interviews { get; set; }
    }
}
