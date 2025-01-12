﻿using MediatR;
using UserService.Domain.Kernel;

namespace UserService.Domain.UserAggregate
{
    public class UserInfoUpdatedDomainEvent : IDomainEvent, INotification
    {
        public string AggregateId { get; }
        public string FirstName { get; }
        public string LastName { get; set; }
        public UserInfoUpdatedDomainEvent(int userId, string firstName, string lastName)
        {
            AggregateId = userId.ToString();
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
