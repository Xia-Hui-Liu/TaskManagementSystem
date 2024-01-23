namespace TaskManagementServer.Models;

public class Assignment
{
    public int TaskId { get; set; }
    public string? TaskName { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public string? Status { get; set; }
    public int AssignedUserId { get; set; }
  
    // Navigation property to represent the assigned user
    public User? AssignedUser { get; set; }
   
}
