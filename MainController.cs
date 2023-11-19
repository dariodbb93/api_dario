using System.Web.Http;

namespace WebApiDario
{
    [Route("[controller]")]
    public class MainController : ApiController
    {
        [HttpPost]
        public string InviaMessaggio([FromBody] MessaggioModel model)
        {
            return model.Messaggio;

        }

    }
}
