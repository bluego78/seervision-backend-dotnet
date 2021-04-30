//***********************************************************************************
// This is the controller that manages the HTTP Calls using the service injected
//***********************************************************************************
namespace SeervisionTodo.Api.Controllers
{
    [ApiController]
	//The root of the controller
    [Route("[controller]")]
	//Request authorization for all methods (azure oAuth2 authorization token)
    [Authorize]
    public class TodoController : ControllerBase
    {
        // IMPORT the interface as an injection, to use all its methods to retrieve data
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService) //Dependency Injection
        {
            _todoService = todoService ?? throw new ArgumentNullException(nameof(todoService));
        }

        //***********************************************************************************
        // GET THE TODOS
        //***********************************************************************************
        //No special permissions required, you can get the data just after authorization
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //DO THE REQUEST TO THE SERVICE TO GET THE TODOS
            var response = await _todoService.getTodos();
            //RETURNS A JSON RESPONSE
            return Ok(response);
        }

        //***********************************************************************************
        // ADD THE TODO
        //***********************************************************************************
        [HttpPost]
        //permission required, you need to have a policy in you cookie
        [Authorize(Policy = "HasPermissionsToWrite")]
        public async Task<IActionResult> PostAsync([FromBody] Todo todo)
        {
            //DO THE REQUEST TO THE SERVICE TO POST THE TODO
            var ret = await _todoService.postTodo(todo);
            //RETURNS A JSON RESPONSE
            return Ok(ret);
        }

        //***********************************************************************************
        // EDIT THE TODO
        //***********************************************************************************
        [HttpPut]
        //permission required, you need to have a policy in you cookie
        [Authorize(Policy = "HasPermissionsToWrite")]
        public async Task<IActionResult> PutAsync([FromBody] Todo todo)
        {
            //DO THE REQUEST TO THE SERVICE TO PUT THE TODO
            var ret = await _todoService.putTodo(req);
            //RETURNS A JSON RESPONSE
            return Ok(ret);
        }

        //***********************************************************************************
        // DELETE THE TODO
        //***********************************************************************************
        [HttpDelete]
        //permission required, you need to have a policy in you cookie
        [Authorize(Policy = "HasPermissionsToWrite")]
        public async Task<IActionResult> DeleteAsync([FromBody] Todo todo)
        {
            //Calls the put operation because DELETE is a logic cancellation
            //so it updates the deleted date of the object
            var ret = await _todoService.putTodo(req);
            //RETURNS A JSON RESPONSE
            return Ok(ret);
        }
    }
}