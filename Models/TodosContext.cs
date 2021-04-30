namespace SeervisionTodo.Api.Models.DataBase
{
    //***********************************************************************************
    // THE CONTEXT to access data from Database
    //***********************************************************************************
    public class TodosContext : DbContext
    {
        public virtual DbSet<Todo> Todo { get; set; }
    }
}
