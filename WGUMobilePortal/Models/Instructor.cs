﻿using MvvmHelpers;

using SQLite;

namespace WGUMobilePortal.Models
{
    public class Instructor : ObservableObject
    {
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        [Ignore]
        public string FullName => $"{FirstName} {LastName}";

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}