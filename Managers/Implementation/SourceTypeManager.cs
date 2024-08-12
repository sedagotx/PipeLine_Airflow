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

public partial class SourceTypeManager :ISourceTypeManager
{
    private readonly PiplineAirflowContext _context;

    public SourceTypeManager(PiplineAirflowContext context) 
    {
        _context = context;
    }

    /// <summary>
    /// POST
    /// </summary>
    public async Task<SourceTypeModel> AddDataAsync(SourceTypeModel data)
    {
        var addData = new tblSourceType()
        {
            SourceTypeId = data.SourceTypeId,
            SourceTypeName = data.SourceTypeName,
            IsActive = data.IsActive,
            CreatedAt = data.CreatedAt,
            CreatedBy = data.CreatedBy,
        };

        _context.tblSourceTypes.Add(addData);
        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }

    /// <summary>
    /// GET
    /// </summary>
    /// <returns></returns>
    public async Task<List<SourceTypeModel>> GetDataAsync()
    {
        var response = new List<SourceTypeModel>();
       
        var dataList = _context.tblSourceTypes.ToList();
        dataList.ForEach(row => response.Add(new SourceTypeModel()
        {
            SourceTypeId = row.SourceTypeId,
            SourceTypeName = row.SourceTypeName,
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
    public Task DeleteAsync(Guid sourceTypeId)
    {
        var data = _context.tblSourceTypes.Where(d => d.SourceTypeId.Equals(sourceTypeId)).FirstOrDefault();
        if (data != null)
        {
            _context.tblSourceTypes.Remove(data);
            _context.SaveChanges();
        }
        return Task.CompletedTask;
    }

    /// <summary>
    ///  PUT
    /// </summary>
    ///  <param name="Guid"></param>
    public async Task<SourceTypeModel> UpdateAsync(Guid sourceTypeId, SourceTypeModel data)
    {
        var dbTable = new tblSourceType();

        //PUT
        dbTable = _context.tblSourceTypes.Where(d => d.SourceTypeId.Equals(sourceTypeId)).FirstOrDefault();
        if (dbTable != null)
        {
            dbTable.SourceTypeName = data.SourceTypeName;
            dbTable.IsActive = data.IsActive;
        }

        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }
}
