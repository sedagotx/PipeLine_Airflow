using DataLibrary.Models;
using DataLibrary.Service;
using Managers.Contracts;
using Managers.Implementation;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PipeLine_Airflow.Controllers;

[ApiController]
public class DataDescriptionController : ControllerBase
{

    private readonly IDataDescriptionManager _dataDescriptionManager;

    public DataDescriptionController(IDataDescriptionManager dataDescriptionManager) 
    {
        _dataDescriptionManager = dataDescriptionManager;
    }

    [HttpGet]
    [Route("api/[controller]/GetDataDescritions")]
    public IActionResult Get()
    {
        var result = _dataDescriptionManager.GetDataAsync().Result;
        return Ok(result);
    }
           

    [HttpGet("api/[controller]/Search")]
    public async Task<ActionResult<IEnumerable<DataDescriptionModel>>> Get( string title ,string description)
    {
        var result = _dataDescriptionManager.Search(title, description).Result;
        return Ok(result);
    }

    [HttpGet]
    [Route("api/[controller]/GetDataDescriptionById/{datadescritionId}")]
    public IActionResult Get(Guid datadescritionId)
    {
        var result = _dataDescriptionManager.GetDataDescriptionById(datadescritionId).Result;
        return Ok(result);
    }

    [HttpPost]
    [Route("api/[controller]/SaveDataDescritions")]
    public IActionResult Post([FromBody] DataDescriptionModel model)
    {
        Guid obj = Guid.NewGuid();
        model.DataDescriptionId = obj;
        model.DataUploadStatus = "in progress";
        var result = _dataDescriptionManager.AddDataAsync(model).Result;
        return Ok(result);
    }

    [HttpPut]
    [Route("api/[controller]/UpdateDataDescrition/{datadescritionId}")]
    public IActionResult Put(Guid datadescritionId, [FromBody] DataDescriptionModel model)
    {
        var result = _dataDescriptionManager.UpdateAsync(datadescritionId, model).Result;
        return Ok(result);
    }

    [HttpDelete]
    [Route("api/[controller]/DeleteDataDescription/{datadescritionId}")]
    public IActionResult Delete(Guid datadescritionId)
    {
        var result = _dataDescriptionManager.DeleteAsync(datadescritionId);
        return Ok(result);
    }

   
}
