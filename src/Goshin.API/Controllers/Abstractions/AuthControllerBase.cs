using Microsoft.AspNetCore.Authorization;

namespace Goshin.API.Controllers.Abstractions;

[Authorize]
public class AuthControllerBase : ApiControllerBase
{ }