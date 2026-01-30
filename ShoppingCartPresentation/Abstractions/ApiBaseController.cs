using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartPresentation.Abstractions
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public abstract class ApiBaseController : ControllerBase
    {
        protected readonly ISender Sender;

        protected ApiBaseController(ISender sender)
        {
            Sender = sender;
        }

    }
}
