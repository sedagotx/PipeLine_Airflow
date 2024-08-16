using DataLibrary.Models;
using DataLibrary.Service;
using Managers.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace PipeLine_Airflow.Controllers
{
    [ApiController]
    public class AirflowController : ControllerBase
    {
        private readonly IAirflowServerManager _airflowServerManager;

        public AirflowController(IAirflowServerManager airflowServerManager )
        {
            _airflowServerManager = airflowServerManager;
        }

       
    }
}
