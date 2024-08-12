using DataLibrary.Models;
using DataLibrary.Service;
using Managers.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace PipeLine_Airflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerDataController : ControllerBase
    {
        private readonly IAirflowServerManager _airflowServerManager;

        public ServerDataController(IAirflowServerManager airflowServerManager) 
        {
            _airflowServerManager = airflowServerManager;
        }

        [HttpPost]
        public IActionResult AddAirflowServer([FromBody] AirflowServerModel data)
        {
            Guid obj = Guid.NewGuid();
            data.AirflowServerId = obj;
           var result = _airflowServerManager.AddDataAsync(data).Result;
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _airflowServerManager.GetDataAsync().Result;
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult delete(Guid id)
        {
            var result = _airflowServerManager.DeleteAsync(id);
            return Ok(result);
        }
    }
}
