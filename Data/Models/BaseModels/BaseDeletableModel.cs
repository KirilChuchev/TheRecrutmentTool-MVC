namespace TheRecrutmentTool.Data.Models.BaseModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseDeletableModel : BaseModel, IDeletableEntity, IAuditInfo
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
