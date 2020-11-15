using System;

namespace BlazorServerAppBasicCrudSample.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
    }
}