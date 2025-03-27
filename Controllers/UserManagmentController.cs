using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
public class UserManagmentController : ControllerBase
{
    private IStorage storage;
    public UserManagmentController(IStorage storage)
    {
        this.storage = storage;
    }

    [HttpGet("Users")]
    public List<User> GetUsers()
    {
        return storage.GetUsers();
    }

    [HttpPut("Users")]
    public void AddUser(User user)
    {
        storage.AddUser(user);
    }

    [HttpDelete("Users/{id}")]
    public ActionResult DeleteUser(int id)
    {
        bool res = storage.DeleteUser(id);
        if(res) return Ok();
        return BadRequest("Ошибка удаления пользователя");
    }

    [HttpPut("Users/{id}")]
    public ActionResult UpdateUser(UserDto userDto, int id)
    {
        bool res = storage.UpdateUser(userDto, id);
        if(res) return Ok();
        return BadRequest("Ошибка обновления пользователя");
    }
}