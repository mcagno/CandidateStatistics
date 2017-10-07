using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using CandidatesManager;
using CandidatesManager.Library;

namespace CandidatesManager.WebAPI.Controllers
{
    public class CandidateStatisticController : ApiController
    {
        public ICandidateStatisticManager Manager { get; set; }

        public CandidateStatisticController(ICandidateStatisticManager manager)
        {
            Manager = manager;
        }

        // GET: api/CandidateStatistic
        public JsonResult<CalendarStatisticResult> Get()
        {
            CalendarStatisticResult result = new CalendarStatisticResult()
            {
                StatisticResult = Manager.GetLetterStatistic(),
                InvalidEntries = Manager.GetInvalidEntries()
            };
            return Json(result);
        }

        
    }

    public class CalendarStatisticResult
    {
        public IEnumerable<Tuple<char, int>> StatisticResult { get; set; }
        public IEnumerable<string> InvalidEntries { get; set; }
    }
}
