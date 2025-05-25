using Microsoft.AspNetCore.Identity;
using ToodList.Models;

namespace ToodList.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<ToodTask> CreatedToodTasks { get; set; } = [];
    public List<ToodTask> UpdatedToodTasks { get; set; } = [];
}

