namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;


    public class JobSkill : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        public string JobId { get; set; }

        public Job Job { get; set; }

        public string SkillId { get; set; }

        public Skill Skill { get; set; }
    }
}
