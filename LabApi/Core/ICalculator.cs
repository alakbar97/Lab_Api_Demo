using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabApi.Core
{
    public  interface ICalculator
    {

        Task<int> AddCalcAsync(int a, int b);
        Task<int> SubCalcAsync(int a, int b);
        Task<int> DivCalcAsync(int a, int b);
        Task<int> MulCalcAsync(int a, int b);
    }
}
