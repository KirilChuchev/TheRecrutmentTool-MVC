namespace TheRecrutmentTool.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Data.Models.BaseModels;

    public class Interview : BaseDeletableModel, IDeletableEntity, IAuditInfo
    {
        [Required(ErrorMessage = nameof(SuitableCandidateId) + " should not be empty or null.")]
        public string SuitableCandidateId { get; set; }

        [Required(ErrorMessage = nameof(SuitableCandidate) + " should not be empty or null.")]
        public Candidate SuitableCandidate  { get; set; }

        [Required(ErrorMessage = nameof(JobId) + " should not be empty or null.")]
        public string JobId { get; set; }

        [Required(ErrorMessage = nameof(Job) + " should not be empty or null.")]
        public Job Job { get; set; }
    }
}
