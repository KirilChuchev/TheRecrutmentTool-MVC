namespace TheRecrutmentTool.Models.Skill
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class SkillsInputModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете поне едно умение на кандидата.")]
        IEnumerable<SkillInputModel> Skills { get; set; }

        public int Count => this.Skills.Count();
    }
}
