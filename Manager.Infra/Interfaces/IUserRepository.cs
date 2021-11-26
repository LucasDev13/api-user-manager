using Manager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Infra.Interfaces
{
    public interface IUserRepository: IBaseRepository<User>
    {
        //busca um email específico. Get: pega/obtem. busca o usuário com este email.
        Task<User> GetByEmail(string email);
        //busca úma coleção de emails que tenham parte do email. search: busca
        Task<List<User>> SearchByEmail(string email);
        //Busca uma coleção de nomes.
        Task<List<User>> SearchByName(string name);
    }
}
