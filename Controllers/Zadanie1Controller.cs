using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace MicroserviceZadanie1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Zadanie1Controller : ControllerBase
    {
        private readonly ILogger<Zadanie1Controller> _logger;

        public Zadanie1Controller(ILogger<Zadanie1Controller> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ContentResult Post([FromBody] JsonElement data)
        {           
            BinaryTree d = new BinaryTree();
            d.root = BinaryTree.Deserialize(data.ToString());

            d.mirror();

            JObject obj = JObject.FromObject(d.root);

            return Content(obj.ToString(), "application/json");
        }
    }
}
