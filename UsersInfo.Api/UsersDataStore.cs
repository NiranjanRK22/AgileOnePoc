using UsersInfo.Api.Models;

namespace UsersInfo.Api
{
    public class UsersDataStore
    {
        public List<UserDto> Users { get; set; }

        public static UsersDataStore Current { get; } = new UsersDataStore();  
        public UsersDataStore()
        {
            Users = new List<UserDto>()
            {
                new UserDto() { Id = 1, UserName = "Virat"},
                new UserDto() { Id = 2, UserName = "Rohit"},
                new UserDto(){ Id = 3, UserName = "Shreyas"},
                new UserDto{ Id = 4, UserName = "MSD"}
            };

        }
    }
}
