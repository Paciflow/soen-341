﻿using Infrastructure.Enums;

namespace Infrastructure.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType type { get; set; }
    }
}
