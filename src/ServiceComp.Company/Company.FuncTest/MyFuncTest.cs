using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.FuncTest
{ 
    public static class MyFuncTest
    {
        
        
        [FunctionName("MyFuncTest")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req, ILogger log)
        {
            return new OkObjectResult($"{req.Headers["userid"]}");
            
            
            
            
            try
            {
                
                var myOb = JsonConvert.SerializeObject(req.Headers.ToList());
                return new OkObjectResult($"Hello, {myOb}");
            }
            catch (Exception e)
            {
                return new OkObjectResult(e.ToString());
            }
            
            

        }
    }
}