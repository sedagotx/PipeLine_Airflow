using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Contracts;

public partial interface IDataDescriptionManager
{
    Task<List<DataDescriptionModel>> GetDataAsync();
    Task<DataDescriptionModel> AddDataAsync(DataDescriptionModel data);
    Task<DataDescriptionModel> UpdateAsync(Guid datadescritionId, DataDescriptionModel data);
    Task DeleteAsync(Guid datadescritionId);
}
