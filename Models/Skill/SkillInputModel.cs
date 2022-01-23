namespace TheRecrutmentTool.Models.Skill
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class SkillInputModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете умение на кандидата.")]
        [StringLength(20, ErrorMessage = "Полето трябва да е между {2} и {0} символа.", MinimumLength = 3)]
        public string Name { get; set; }
    }
}
