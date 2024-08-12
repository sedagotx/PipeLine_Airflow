using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public interface ILoadDataService
    {
        Task<List<LoadData>> GetAllLoadData();
        Task<LoadData> AddLoadData(LoadData data);
    }
}
