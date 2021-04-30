//***********************************************************************************
// THIS IS THE SERVICE THAT EXPOSES THE METHODS BY THE INTERFACE & READ/WRITE THE DB
//***********************************************************************************
namespace SeervisionTodo.Api.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext _todoContext;

        public TodoService(TodoContext todoContext)
        {
            // this throw an error if the context is not init
            _todoContext = todoContext ?? throw new ArgumentNullException(nameof(todoContext));
        }

        //GET METHOD
        public async Task<List<Todo>> getTodos()
        {
            try
            {
                //Start the query to the context and return a list of todo
                //This is an example query with Entity Framework & Linq
                return await _todoContext.Todo
                            .Where((todo) => todo.deleted == null);
                            .OrderBy(todo => item.created)
                            .ToListAsync()
            }
            catch (Exception ex)
            {
                //Eventually log hthe error
                throw new Exception(ex.Message);
            }
        }

        //POST METHOD
        public async Task<Todo> postTodo(Todo todo)
        {
            // do stuff as in the get method and return the saved todo
        }

        //PUT METHOD
        public async Task<Todo> putTodo(Todo todo)
        {
            // do stuff as in the get method and return the updated todo
        }
        
    }
}
