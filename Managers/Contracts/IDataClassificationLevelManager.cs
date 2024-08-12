using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Contracts;

public partial interface IDataClassificationLevelManager
{
    Task<List<DataClassificationLevelModel>> GetDataAsync();
    Task<DataClassificationLevelModel> AddDataAsync(DataClassificationLevelModel data);

    Task<DataClassificationLevelModel> UpdateAsync(Guid dataclssificationId, DataClassificationLevelModel data);
    Task DeleteAsync(Guid dataclssificationId);
}
