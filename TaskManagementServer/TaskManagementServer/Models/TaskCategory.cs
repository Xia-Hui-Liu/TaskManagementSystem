namespace TaskManagementServer.Models;

public class TaskCategory
{
    public int TaskCategoryId { get; set; }
    public int TaskId { get; set; }
    public int CategoryId { get; set; }
  
    // Navigation properties
    public Assignment? Task { get; set; }
    public Category? Category { get; set; }
}
