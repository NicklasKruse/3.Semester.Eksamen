﻿namespace WebAppFront.Services.Models.Addresses
{
    public class ForeningsMedlemQueryResultDto
    {
        public int Id { get; set; }
        public AddressQueryResultDto Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}