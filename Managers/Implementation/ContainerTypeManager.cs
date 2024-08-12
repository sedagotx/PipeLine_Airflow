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

public partial class ContainerTypeManager :IContainerTypeManager
{
    private readonly PiplineAirflowContext _context;
    public ContainerTypeManager(PiplineAirflowContext context) { _context = context; }

    /// <summary>
    /// POST
    /// </summary>
    public async Task<ContainerTypeModel> AddDataAsync(ContainerTypeModel data)
    {
        var addData = new tblContainerType()
        {
            ContainerTypeId = data.ContainerTypeId,
            ContainerTypeName = data.ContainerTypeName,
            IsActive = data.IsActive,
            CreatedAt = data.CreatedAt,
            CreatedBy = data.CreatedBy,
        };

        _context.tblContainerTypes.Add(addData);
        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }

    /// <summary>
    /// GET
    /// </summary>
    /// <returns></returns>
    public async Task<List<ContainerTypeModel>> GetDataAsync()
    {
        var response = new List<ContainerTypeModel>();
       
        var dataList = _context.tblContainerTypes.ToList();
        dataList.ForEach(row => response.Add(new ContainerTypeModel()
        {
            ContainerTypeId = row.ContainerTypeId,
            ContainerTypeName = row.ContainerTypeName,
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
    public Task DeleteAsync(Guid containerTypeId)
    {
        var data = _context.tblContainerTypes.Where(d => d.ContainerTypeId.Equals(containerTypeId)).FirstOrDefault();
        if (data != null)
        {
            _context.tblContainerTypes.Remove(data);
            _context.SaveChanges();
        }
        return Task.CompletedTask;
    }

    /// <summary>
    ///  PUT
    /// </summary>
    ///  <param name="Guid"></param>
    public async Task<ContainerTypeModel> UpdateAsync(Guid containerTypeId, ContainerTypeModel data)
    {
        var dbTable = new tblContainerType();

        //PUT
        dbTable = _context.tblContainerTypes.Where(d => d.ContainerTypeId.Equals(containerTypeId)).FirstOrDefault();
        if (dbTable != null)
        {
            dbTable.ContainerTypeName = data.ContainerTypeName;
            dbTable.IsActive = data.IsActive;
        }

        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }
}
