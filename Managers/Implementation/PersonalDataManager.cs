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

public partial class PersonalDataManager:IPersonalDataManager
{
    private readonly PiplineAirflowContext _context;

    public PersonalDataManager(PiplineAirflowContext context) { _context = context; }

    /// <summary>
    /// POST
    /// </summary>
    public async Task<PersonalDataModel> AddDataAsync(PersonalDataModel data)
    {
        var addData = new tblPersonalData()
        {
            PersonalDataId = data.PersonalDataId,
            PersonalDataName = data.PersonalDataName,
            IsActive = data.IsActive,
            CreatedAt = data.CreatedAt,
            CreatedBy = data.CreatedBy,
        };

        _context.tblPersonalDatas.Add(addData);
        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }

    /// <summary>
    /// GET
    /// </summary>
    /// <returns></returns>
    public async Task<List<PersonalDataModel>> GetDataAsync()
    {
        var response = new List<PersonalDataModel>();
        
        var dataList = _context.tblPersonalDatas.ToList();
        dataList.ForEach(row => response.Add(new PersonalDataModel()
        {
            PersonalDataId = row.PersonalDataId,
            PersonalDataName = row.PersonalDataName,
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
    public Task DeleteAsync(Guid personalTypeId)
    {
        var data = _context.tblPersonalDatas.Where(d => d.PersonalDataId.Equals(personalTypeId)).FirstOrDefault();
        if (data != null)
        {
            _context.tblPersonalDatas.Remove(data);
            _context.SaveChanges();
        }
        return Task.CompletedTask;
    }

    /// <summary>
    ///  PUT
    /// </summary>
    ///  <param name="Guid"></param>
    public async Task<PersonalDataModel> UpdateAsync(Guid personalTypeId, PersonalDataModel data)
    {
        var dbTable = new tblPersonalData();

        //PUT
        dbTable = _context.tblPersonalDatas.Where(d => d.PersonalDataId.Equals(personalTypeId)).FirstOrDefault();
        if (dbTable != null)
        {
            dbTable.PersonalDataName = data.PersonalDataName;
            dbTable.IsActive = data.IsActive;
        }

        var result = await _context.SaveChangesAsync();
        return result >= 0 ? data : null;
    }
}
