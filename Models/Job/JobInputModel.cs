namespace TheRecrutmentTool.Models.Job
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Models.Skill;

    public class JobInputModel : IValidatableObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
        public ICollection<SkillInputModel> Skills { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(this.Title))
            {
                yield return new ValidationResult("Моля въведете наименование на работната позиция.");
            }

            if (this.Title.Length < 3 || this.Title.Length > 30)
            {
                yield return new ValidationResult("Полето 'Наименование' трябва да е между 3 и 30 символа.");
            }

            if (string.IsNullOrWhiteSpace(this.Description))
            {
                yield return new ValidationResult("Моля въведете наименование на работната позиция.");
            }

            if (this.Description.Length < 20 || this.Description.Length > 10000)
            {
                yield return new ValidationResult("Полето 'Описание' трябва да е между 20 и 10000 символа.");
            }

            if (double.IsNaN(this.Salary) || this.Salary <= 0)
            {
                yield return new ValidationResult("Моля въведете валидна стойност на заплатата.");
            }

            if (this.Skills.Count <= 0)
            {
                yield return new ValidationResult("Моля въведете валидна поне едно умение на кандидата.");
            }
        }
    }
}
