public class UserStorage : IStorage
{
    private List<User> users;
    public UserStorage()
    {
        this.users = new List<User>();
        for(int i=1; i<5; i++)
        {
            Random random = new Random();
            this.users.Add(new User(){
                Id = i,
                Name = $"Имя {i}",
                Email = $"{Guid.NewGuid().ToString().Substring(0,5)}.gmail.com",
                PhoneNumber = "8985100" + $"{random.Next(10000)}",
                Age = random.Next(20, 100)
            });
        }
    }
    public void AddUser(User user)
    {
        users.Add(user);
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public bool UpdateUser(UserDto userDto, int id)
    {
        User user;
        foreach(var item in users)
        {
            if(item.Id == id)
            {
                user = item;
                user.Age = userDto.Age;
                user.Email = userDto.Email;
                user.Name = userDto.Name;
                user.PhoneNumber = userDto.PhoneNumber;
                return true;
            }
        }
        return false;
    }

    public bool DeleteUser(int id)
    {
        foreach(var item in users)
        {
            if(item.Id == id)
            {
                users.Remove(item);
                return true;
            }
        }
        return false;
    }

}