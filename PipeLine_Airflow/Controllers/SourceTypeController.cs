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
public class SourceTypeController : ControllerBase
{
    private readonly ISourceTypeManager _sourceTypeManager;

    public SourceTypeController(ISourceTypeManager sourceTypeManager)
    {
        _sourceTypeManager = sourceTypeManager;
    }

    [HttpGet]
    [Route("api/[controller]/GetSourceTypes")]
    public IActionResult Get()
    {
        var result = _sourceTypeManager.GetDataAsync().Result;
        return Ok(result);
    }

    [HttpPost]
    [Route("api/[controller]/SaveSourcetype")]
    public IActionResult Post([FromBody] SourceTypeModel model)
    {
        Guid obj = Guid.NewGuid();
        model.SourceTypeId = obj;
        var result = _sourceTypeManager.AddDataAsync(model).Result;
        return Ok(result);
    }

    [HttpPut]
    [Route("api/[controller]/UpdateSourceType/{sourceTypeId}")]
    public IActionResult Put(Guid sourcsTypeId, [FromBody] SourceTypeModel model)
    {
        var result = _sourceTypeManager.UpdateAsync(sourcsTypeId, model).Result;
        return Ok(result);
    }

    [HttpDelete]
    [Route("api/[controller]/DeleteSourceType/{sourceType}")]
    public IActionResult Delete(Guid datadescritionId)
    {
        var result = _sourceTypeManager.DeleteAsync(datadescritionId);
        return Ok(result);
    }
}
