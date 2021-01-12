namespace TodoApp.Models
{
    public class TodoModel
    {
        public Guid Id {get;set;}
        public string Title {get;set;}
        public bool Isdone {get; set;}
        public DateTimeOffSet? DueAt {get;set;}
    }
}