using DataLibrary.Context;
using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Service
{
    public class LoadDataService : ILoadDataService
    {
        private readonly PiplineAirflowContext _context;
        public LoadDataService(PiplineAirflowContext context) 
        {
            _context=context;
        }
        public async Task<LoadData?> AddLoadData(LoadData data)
        {
            var addData = new LoadData()
            {
                DataDescriptionId = data.DataDescriptionId,
                DataDescriptions = data.DataDescriptions,
                DataUploadStatus = data.DataUploadStatus,
                Status = data.Status,
                CreatedAt = data.CreatedAt,
                CreatedBy = data.CreatedBy,
                UpdatedBy = data.UpdatedBy,
                Title = data.Title,
            };

            _context.LoadDatas.Add(addData);
            var result = await _context.SaveChangesAsync();
            return result >= 0 ? addData : null;
        }

        public async Task<List<LoadData>> GetAllLoadData()
        {
            var data1 =  _context.LoadDatas.OrderBy(x => x.DataDescriptionId).Take(10).ToList();
            return data1;
        }
    }
}
