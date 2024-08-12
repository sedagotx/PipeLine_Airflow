using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Managers.Contracts;

public partial interface IAirflowServerManager
{
    Task<List<AirflowServerModel>> GetDataAsync();
    Task<AirflowServerModel> AddDataAsync(AirflowServerModel data);
    Task<AirflowServerModel> UpdateAsync(Guid airflowId, AirflowServerModel data);
    Task DeleteAsync(Guid airflowId);
}
