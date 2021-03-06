﻿using EmailManager.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager.Service.Contracts
{
    public interface IUsersService
    {
        Task<UserDTO> GetUserByIdAsync(string userId);
        Task<UserDTO> CheckUserCredentialsAsync(string userName, string password);
    }
}
