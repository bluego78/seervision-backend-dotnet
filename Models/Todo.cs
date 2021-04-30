namespace SeervisionTodo.Api.Models.DataBase
{
    //***********************************************************************************
    // THE TODO Model from the DB Structure
    // (you can set it manually or get if by Entity Framework)
    //***********************************************************************************
    public class Todo
    {
        public int _id { get; set; }
        public string text { get; set; }
        public bool done { get; set; }
        public Date created { get; set; }
        public Date deleted { get; set; }
        public Date updated { get; set; }
    }
}
