//***********************************************************************************
// This is the interface of the service to expose the mathods
//***********************************************************************************
namespace SeervisionTodo.Api.Interfaces
{
    public interface ITodoService
    {
        //GET the todos and returns a list of todos
        Task<List<Todo>> getTodos();

        //POST the new todo and returns the saved todo
        Task<Todo> postTodo(Todo todo);

        //PUT the edit todo and returns the saved todo
        Task<Todo> putTodo(Todo todo);
    }
}
