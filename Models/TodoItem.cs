namespace TodoApi.Models
{
    public class TodoItem
    {
      //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long Id { get; set; }
      public string Name { get; set; }
      public string IsComplete { get; set; }
      public string test { get; set; }
    }
}