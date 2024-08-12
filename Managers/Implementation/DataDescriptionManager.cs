using DataLibrary.Context;
using DataLibrary.Models;
using Managers.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Managers.Implementation;

public partial class DataDescriptionManager : IDataDescriptionManager
{
    private readonly PiplineAirflowContext _context;
    public DataDescriptionManager(PiplineAirflowContext context) { _context = context;  }

    /// <summary>
    /// POST
    /// </summary>
    public async Task<DataDescriptionModel> AddDataAsync(DataDescriptionModel data)
    {
        var addData = new tblDataDescription()
        {
            DataDescriptionId = data.DataDescriptionId,
            DataDescriptions = data.DataDescriptions,
            DataUploadStatus =data.DataUploadStatus,
            Title=data.Title,
            IsActive = data.IsActive,
            CreatedAt = data.CreatedAt,
            CreatedBy = data.CreatedBy,
        };

        _context.tblDataDescriptions.Add(addData);
        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }

    /// <summary>
    /// GET
    /// </summary>
    /// <returns></returns>
    public async Task<List<DataDescriptionModel>> GetDataAsync()
    {
        var response = new List<DataDescriptionModel>();
       
        var dataList = _context.tblDataDescriptions.ToList();
        dataList.ForEach(row => response.Add(new DataDescriptionModel()
        {
            DataDescriptionId = row.DataDescriptionId,
            DataDescriptions = row.DataDescriptions,
            DataUploadStatus = row.DataUploadStatus,
            Title = row.Title,
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
    public Task DeleteAsync(Guid datadescritionId)
    {
        var data = _context.tblDataDescriptions.Where(d => d.DataDescriptionId.Equals(datadescritionId)).FirstOrDefault();
        if (data != null)
        {
            _context.tblDataDescriptions.Remove(data);
            _context.SaveChanges();
        }
        return Task.CompletedTask;
    }

    /// <summary>
    ///  PUT
    /// </summary>
    ///  <param name="Guid"></param>
    public async Task<DataDescriptionModel> UpdateAsync(Guid datadescritionId, DataDescriptionModel data)
    {
        var dbTable = new tblDataDescription();

        //PUT
        dbTable = _context.tblDataDescriptions.Where(d => d.DataDescriptionId.Equals(datadescritionId)).FirstOrDefault();
        if (dbTable != null)
        {
            dbTable.DataDescriptions = data.DataDescriptions;
            dbTable.IsActive = data.IsActive;
        }

        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }
}
