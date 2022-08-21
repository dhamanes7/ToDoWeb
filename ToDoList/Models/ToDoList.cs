namespace ToDoList.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string IsCompleted { get; set; }

        public string Completed { get; set; }

        public ToDoList()
        {
            Id = 0;
            Title = "Default";
            IsCompleted = "NA";
            Completed = "NA";
        }

        public ToDoList(int id, string title, string isCompleted, string completed)
        {
            Id = id;
            Title = title;
            IsCompleted = isCompleted;
            Completed = completed;
        }
    }



}
