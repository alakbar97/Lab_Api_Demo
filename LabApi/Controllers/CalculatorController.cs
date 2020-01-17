using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorService;
using LabApi.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LabApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController( ICalculator calculator, ILogger<CalculatorController> logger)
        {
            _calculator = calculator;
            _logger = logger;
        }
        [HttpGet]
        [Route("Add")]
        public async Task<ActionResult<int>> AddCalcAsync(int a,int b)
        {
            try
            {
                var result = await _calculator.AddCalcAsync(a, b);
                _logger.LogInformation($"{a} + {b}= {result}");
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }
           
        }
        [HttpGet]
        [Route("Sub")]
        public async Task<ActionResult<int>> SubCalcAsync(int a, int b)
        {
            try
            {
                var result = await _calculator.SubCalcAsync(a, b);
                _logger.LogInformation($"{a} - {b}= {result}");
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }

           
        }
        [HttpGet]
        [Route("Div")]
        public async Task<ActionResult<int>> DivCalcAsync(int a, int b)
        {
            try
            {
                var result = await _calculator.DivCalcAsync(a, b);
                _logger.LogInformation($"{a} / {b}= {result}");
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }


           
        }
        [HttpGet]
        [Route("Mul")]
        public async Task<ActionResult<int>> MulCalcAsync(int a, int b)
        {
            try
            {
                var result = await _calculator.MulCalcAsync(a, b);
                _logger.LogInformation($"{a} * {b}= {result}");
                return Ok(result);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }

            return Ok(await _calculator.MulCalcAsync(a, b));
        }

    }
}