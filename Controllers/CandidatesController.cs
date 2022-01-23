namespace TheRecrutmentTool.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Models.Candidate;

    public class CandidatesController : Controller
    {
        private readonly ILogger<CandidatesController> _logger;

        public CandidatesController(ILogger<CandidatesController> logger)
        {
            this._logger = logger;
        }

        public async Task<IActionResult> Create([FromForm] CandidateInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.View();
        }

        public async Task<IActionResult> All()
        {
            return this.View("dvcwe");
        }
    }
}
