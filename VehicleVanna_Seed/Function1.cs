using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VehicleVanna_Test;

namespace VehicleVanna_Seed
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Queue("AutoQueue")] IAsyncCollector<AutoEnum> vehicleasync,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var myVar = JsonConvert.DeserializeObject<AutoEnum>(requestBody);
            log.LogInformation ("Log Stuff Here");

            string responseMessage = $"Hello, Buyer {myVar.FName} {myVar.LName}, purchased a {myVar.AutoType} of Make {myVar.AutoMake}, Model {myVar.AutoModel} " + 
                $"and Year {myVar.AutoYear}. The list price is: {myVar.listPrice.ToString()}." + 
                $"A discount will be applied whcih is {(myVar.listPrice * .085m)}, for a total of: {(myVar.listPrice - (myVar.listPrice * .085m)).ToString("C")}";

            return new OkObjectResult(responseMessage);
        }
    }
}
