using CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabApi.Core
{
    public class RestCalculator : ICalculator
    {

        private readonly CalculatorSoapClient _client;


        public RestCalculator()
        {
            _client = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
        }

        public async Task<int> AddCalcAsync(int a, int b)
        {
            return await _client.AddAsync(a, b);
        }

        public async Task<int> DivCalcAsync(int a, int b)
        {
            return await _client.DivideAsync(a, b);
        }

        public async Task<int> MulCalcAsync(int a, int b)
        {
            return await _client.MultiplyAsync(a, b);
        }

        public async Task<int> SubCalcAsync(int a, int b)
        {
            return await _client.SubtractAsync(a, b);
        }
    }
}
