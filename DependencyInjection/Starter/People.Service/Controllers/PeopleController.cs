using Common;
using Microsoft.AspNetCore.Mvc;
using Ninject.Activation;
using People.Service.Models;
using System.Collections.Generic;
using System.Linq;

namespace People.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        IPeopleProvider _provider;

        // TODO 9-1 : Déclarer un paramètre supplémentaire au contructeur de type IPeopleProvider
        // TODO 9-2 : Commenter la ligne de code qui créé le provider
        // TODO 9-3 : Et affecter à _provider, le nouveau paramètre du constructeur

        public PeopleController(IPeopleProvider _providerIOC)
        {
            //this._provider = new HardCodedPeopleProvider();
            _provider = _providerIOC;
        }

        // GET /people
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _provider.GetPeople();
        }

        // GET /people/5
        [HttpGet("{GivenName}")]
        public Person Get(string GivenName)
        {
            return _provider.GetPeople().FirstOrDefault(p => p.GivenName == GivenName);
        }
    }
}
