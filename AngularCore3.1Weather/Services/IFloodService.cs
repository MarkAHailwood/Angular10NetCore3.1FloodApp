using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularCore3._1Weather.Models;

namespace AngularCore3._1Weather.Services
{
    public interface IFloodService
    {
        Task<List<FloodSummary>> GetFloodForecast(string location);
    }
}
