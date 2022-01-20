namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;

    public class CandidateSkill : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        public string CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public string SkillId { get; set; }

        public Skill Skill { get; set; }
    }
}
