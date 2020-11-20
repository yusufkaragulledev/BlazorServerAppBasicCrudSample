using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerAppBasicCrudSample.Data;
using BlazorServerAppBasicCrudSample.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAppBasicCrudSample.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly MyDbContext _dbContext;

        public CustomerService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer() => await _dbContext.Customer.ToListAsync();

        public async Task<Customer> GetByIdCustomer(Guid id) => await _dbContext.Customer.FirstOrDefaultAsync(x => x.Id == id);

        public async Task CreateCustomer(Customer customer)
        {
            await _dbContext.Customer.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            _dbContext.Customer.Update(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCustomer(Customer customer)
        {
            _dbContext.Customer.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}