﻿using System.Threading.Tasks;

namespace BecketLee.Services
{
    public interface IEmailService
    {
        void SendEmail( string to, string from, string subject, string body );
    }
}