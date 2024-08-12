using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Contracts;

public partial interface IContainerTypeManager
{
    Task<List<ContainerTypeModel>> GetDataAsync();
    Task<ContainerTypeModel> AddDataAsync(ContainerTypeModel data);

    Task<ContainerTypeModel> UpdateAsync(Guid containerTypeId, ContainerTypeModel data);
    Task DeleteAsync(Guid containerTypeId);
}
