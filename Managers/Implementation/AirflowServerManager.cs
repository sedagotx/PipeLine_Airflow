using DataLibrary.Context;
using DataLibrary.Models;
using Managers.Contracts;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Managers.Implementation;

public partial class AirflowServerManager : IAirflowServerManager
{
    private readonly PiplineAirflowContext _context;

    public AirflowServerManager(PiplineAirflowContext context)
    {
        _context = context;
    }
    /// <summary>
    /// POST
    /// </summary>
    public async Task<AirflowServerModel> AddDataAsync(AirflowServerModel data)
    {
        var addData = new tblAirflowServer()
        {
            AirflowServerId = data.AirflowServerId,
            AirflowServerName = data.AirflowServerName,
            IsActive = data.IsActive,
            CreatedAt = data.CreatedAt,
            CreatedBy = data.CreatedBy,
        };

        _context.tblAirflowServers.Add(addData);
        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }

    /// <summary>
    /// GET
    /// </summary>
    /// <returns></returns>
    public async Task<List<AirflowServerModel>> GetDataAsync()
    {
        var response = new List<AirflowServerModel>();
        //var allEntities = await _context.tblAirflowServers.ToListAsync();
        //var data1 = _context.tblAirflowServers.OrderBy(x => x.AirflowServerId).Take(10).ToList();

        //resp.Add(data1);
        var dataList = _context.tblAirflowServers.ToList();
        dataList.ForEach(row => response.Add(new AirflowServerModel()
        {
            AirflowServerId = row.AirflowServerId,
            AirflowServerName = row.AirflowServerName,
            IsActive = row.IsActive,
            CreatedBy = row.CreatedBy,
            CreatedAt = row.CreatedAt
        }));

        return response;
     
    }

    /// <summary>
    /// DELETE
    /// </summary>
    /// <param name="Guid"></param>
    public Task DeleteAsync(Guid airflowId)
    {
        var data = _context.tblAirflowServers.Where(d => d.AirflowServerId.Equals(airflowId)).FirstOrDefault();
        if (data != null)
        {
            _context.tblAirflowServers.Remove(data);
            var result = _context.SaveChanges();
            
        }
        return Task.CompletedTask;
    }

    /// <summary>
    ///  PUT
    /// </summary>
    ///  <param name="Guid"></param>
    public async Task<AirflowServerModel> UpdateAsync(Guid airflowId, AirflowServerModel data)
    {
        var dbTable = new tblAirflowServer();

            //PUT
            dbTable = _context.tblAirflowServers.Where(d => d.AirflowServerId.Equals(airflowId)).FirstOrDefault();
            if (dbTable != null)
            {
                dbTable.AirflowServerName = data.AirflowServerName;
                dbTable.IsActive = data.IsActive;
            }

         var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }
}
