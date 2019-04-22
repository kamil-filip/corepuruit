using CodePersuit.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePersuit.Core.Controllers
{

    //Installed Mvc.Core
    //Installed Mvc.Formatter Json

    [Route("api/{userName}/[controller]")]
    public class RepoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Repo> Get(string user)
        {
            return null;
        }

        [HttpGet("/{repoName}")]
        public Repo Get(string userName, string repoName)
        {
            return null;
        }


    }
}
