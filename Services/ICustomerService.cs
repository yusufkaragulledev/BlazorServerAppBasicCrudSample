using BlazorServerAppBasicCrudSample.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerAppBasicCrudSample.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task<Customer> GetByIdCustomer(Guid id);
        Task CreateCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(Customer customer);
    }
}