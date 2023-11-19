using System.Web.Http;

namespace WebApiDario
{
    [Route("[controller]")]
    public class MainController : ApiController
    {
        [HttpPost]
        public IHttpActionResult InviaMessaggio([FromBody] MessaggioModel model)
        {
            return Ok(model.Messaggio);

        }

    }
}
