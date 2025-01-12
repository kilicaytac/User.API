﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.Commands
{
    public class UpdateUserInfoCommand : IRequest<bool>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
