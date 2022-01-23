namespace TheRecrutmentTool.Models.Recruiter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class RecruiterInputModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете фамилия на рекрутера.")]
        [StringLength(20, ErrorMessage = "Полето трябва да е между {2} и {0} символа.", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете email адрес на рекрутера.")]
        [EmailAddress(ErrorMessage = "Моля въведете валиден email адрес.")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете държавата, в която се намира кандидата")]
        [StringLength(30, ErrorMessage = "Полето трябва да е поне {2} символа.", MinimumLength = 3)]
        public string Country { get; set; }
    }
}
