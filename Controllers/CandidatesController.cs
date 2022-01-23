namespace TheRecrutmentTool.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TheRecrutmentTool.Models.Candidate;
    using TheRecrutmentTool.Models.Skill;

    [ApiController]
    [Route("[controller]")]
    public class CandidatesController : Controller
    {
        private readonly ILogger<CandidatesController> _logger;

        public CandidatesController(ILogger<CandidatesController> logger)
        {
            this._logger = logger;
        }

        [HttpPost, ActionName("/")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] CandidateInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.View();
        }

        [HttpPost, Route("all")]
        public async Task<IActionResult> All()
        {
            ;
            return this.View("dvcwe");
        }
    }
}
