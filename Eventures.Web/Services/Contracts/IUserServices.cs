using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Web.ViewModels;

namespace Eventures.Web.Services.Contracts
{
    public interface IUserServices
    {
        UserViewModel GetUser(string id);
    }
}
