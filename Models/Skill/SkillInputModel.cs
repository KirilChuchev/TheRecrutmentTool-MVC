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
        [StringLength(20, ErrorMessage = "Полето 'Умение' трябва да е между {2} и {1} символа.", MinimumLength = 2)]
        public string Name { get; set; }
    }
}
