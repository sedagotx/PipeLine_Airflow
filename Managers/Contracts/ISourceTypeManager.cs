using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Contracts;

public partial interface ISourceTypeManager
{
    Task<List<SourceTypeModel>> GetDataAsync();
    Task<SourceTypeModel> AddDataAsync(SourceTypeModel data);
    Task<SourceTypeModel> UpdateAsync(Guid sourceTypeId, SourceTypeModel data);
    Task DeleteAsync(Guid sourceTypeId);
}
