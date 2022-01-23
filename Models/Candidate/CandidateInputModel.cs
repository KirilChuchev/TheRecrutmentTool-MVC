namespace TheRecrutmentTool.Models.Candidate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Models.Recruiter;
    using TheRecrutmentTool.Models.Skill;

    public class CandidateInputModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете име на кандидата.")]
        [StringLength(20, ErrorMessage = "Полето трябва да е между {2} и {0} символа.", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете фамилия на кандидата.")]
        [StringLength(20, ErrorMessage = "Полето трябва да е между {2} и {0} символа.", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете email адрес на кандидата.")]
        [EmailAddress(ErrorMessage = "Моля въведете валиден email адрес.")]
        public string Email { get; set; }

        // TODO: Validate birthday as we need minimum 18 years old candidate
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете рожденна дата на кандидата.")]
        public DateTime Birthday { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете биография на кандидата")]
        [StringLength(10000, ErrorMessage = "Полето трябва да е между {2} и {0} символа.", MinimumLength = 20)]
        public string Bio { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете поне едно умение на кандидата.")]
        public SkillsInputModel Skills { get; set; }

        public RecruiterInputModel Recruiter { get; set; }
    }
}
