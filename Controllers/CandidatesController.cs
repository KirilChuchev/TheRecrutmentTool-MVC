namespace TheRecrutmentTool.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CandidatesController : Controller
    {
        private readonly ILogger<CandidatesController> _logger;

        public CandidatesController(ILogger<CandidatesController> logger)
        {
            this._logger = logger;
        }

        public async Task<IActionResult> All()
        {
            return this.View("dvcwe");
        }
    }
}
