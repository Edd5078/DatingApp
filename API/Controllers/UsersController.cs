
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;

[ApiController]
[Route("api/[Controller]")] //api/users
public class UsersController(DataContext context): ControllerBase
{

[HttpGet]
public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
{

var Users=await context.Users.ToListAsync();

return Users;
}

[HttpGet("{id:int}")]   //api/Users/3
public async Task<ActionResult<AppUser>> GetUser(int id)
{

var User=await context.Users.FindAsync(id);
if(User== null)
{
   return  NotFound();
}
return User;
}







}