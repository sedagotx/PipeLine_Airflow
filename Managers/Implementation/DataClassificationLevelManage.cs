using DataLibrary.Context;
using DataLibrary.Models;
using Managers.Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Implementation;

public partial class DataClassificationLevelManage :IDataClassificationLevelManager
{
    private readonly PiplineAirflowContext _context;

    public DataClassificationLevelManage(PiplineAirflowContext context) { _context = context; }

    /// <summary>
    /// POST
    /// </summary>
    public async Task<DataClassificationLevelModel> AddDataAsync(DataClassificationLevelModel data)
    {
        var addData = new tblDataClassificationLevel()
        {
            DataClassificationLevelId = data.DataClassificationLevelId,
            DataClassificationLevelName = data.DataClassificationLevelName,
            IsActive = data.IsActive,
            CreatedAt = data.CreatedAt,
            CreatedBy = data.CreatedBy,
        };

        _context.tblDataClassificationLevels.Add(addData);
        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }

    /// <summary>
    /// GET
    /// </summary>
    /// <returns></returns>
    public async Task<List<DataClassificationLevelModel>> GetDataAsync()
    {
        var response = new List<DataClassificationLevelModel>();
        
        var dataList = _context.tblDataClassificationLevels.ToList();
        dataList.ForEach(row => response.Add(new DataClassificationLevelModel()
        {
            DataClassificationLevelId = row.DataClassificationLevelId,
            DataClassificationLevelName = row.DataClassificationLevelName,
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
    public Task DeleteAsync(Guid dataclssificationId)
    {
        var data = _context.tblDataClassificationLevels.Where(d => d.DataClassificationLevelId.Equals(dataclssificationId)).FirstOrDefault();
        if (data != null)
        {
            _context.tblDataClassificationLevels.Remove(data);
            _context.SaveChanges();
        }
        return Task.CompletedTask;
    }


    /// <summary>
    ///  PUT
    /// </summary>
    ///  <param name="Guid"></param>
    public async Task<DataClassificationLevelModel> UpdateAsync(Guid dataclssificationId, DataClassificationLevelModel data)
    {
        var dbTable = new tblDataClassificationLevel();

        //PUT
        dbTable = _context.tblDataClassificationLevels.Where(d => d.DataClassificationLevelId.Equals(dataclssificationId)).FirstOrDefault();
        if (dbTable != null)
        {
            dbTable.DataClassificationLevelName = data.DataClassificationLevelName;
            dbTable.IsActive = data.IsActive;
        }

        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }
}
