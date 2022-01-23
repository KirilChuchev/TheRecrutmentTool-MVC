using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRecrutmentTool.Data;

namespace TheRecrutmentTool.Services
{
    public class CandidatesServices
    {
        private readonly ApplicationDbContext dbContext;

        public CandidatesServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
