﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateStorage.Core.DTO
{
    public class CreateUserRequest
    {
        public string NickName { get; set;}
        public string Password { get; set;}
        public string Email { get; set;}
    }
}
