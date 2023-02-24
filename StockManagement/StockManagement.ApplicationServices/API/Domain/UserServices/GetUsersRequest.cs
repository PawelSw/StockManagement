using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ApplicationServices.API.Domain.UserServices
{
    public class GetUsersRequest :  IRequest<GetUsersResponse>
    {
        public string Username { get; set; }
    }
}
