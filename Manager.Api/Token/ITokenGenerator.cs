using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.Api.Token
{
    public interface ITokenGenerator
    {
        string GenerateToken();
    }
}
