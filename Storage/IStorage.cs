public interface IStorage
{
    public void AddUser(User user);
    public List<User> GetUsers();
    public bool UpdateUser(UserDto userDto, int id);
    public bool DeleteUser(int id);
}