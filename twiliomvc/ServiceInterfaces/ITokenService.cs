using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twiliomvc.ServiceInterfaces
{
    public interface ITokenService
    {
        string GenerateRandomToken();
    }
}