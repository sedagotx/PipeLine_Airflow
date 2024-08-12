using DataLibrary.Models;
using DataLibrary.Service;
using Managers.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace PipeLine_Airflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirflowController : ControllerBase
    {
        private readonly ILoadDataService _loadDataService;

        public AirflowController(ILoadDataService loadDataService )
        {
            _loadDataService = loadDataService;
            
        }

        [HttpPost]
        public IActionResult Create([FromBody] LoadData data)
        {
            Guid obj = Guid.NewGuid();
            data.DataDescriptionId = obj;
           _loadDataService.AddLoadData(data);
                return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
           var result= _loadDataService.GetAllLoadData();
            return Ok(result);
        }

       
    }
}
