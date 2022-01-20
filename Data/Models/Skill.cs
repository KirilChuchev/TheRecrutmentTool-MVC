namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;

    public class Skill : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        public Skill()
        {
            this.Candidates = new HashSet<CandidateSkill>();
            this.Jobs = new HashSet<JobSkill>();
        }

        [Required(ErrorMessage = nameof(Name) + " should not be empty or null")]
        public string Name { get; set; }

        public virtual ICollection<CandidateSkill> Candidates { get; set; }
        public virtual ICollection<JobSkill> Jobs { get; set; }
    }
}
