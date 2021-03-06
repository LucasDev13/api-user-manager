using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.Service.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Quando o objeto for serializado(pegar o objeto e transformar e um json) esse propriedade vai ser ignorada 
        [JsonIgnore]
        public string Password { get; set; }

        public UserDTO()
        {
        }

        public UserDTO(long id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
