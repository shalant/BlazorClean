using ApplicationLayer.Contracts;
using ApplicationLayer.DTOs;
using DomainLayer.Entities;
using InfrastructureLayer.Data;

namespace InfrastructureLayer.Implementation;

public class EmployeeRepo : IEmployee
{
    private readonly AppDbContext _appDbContext;

    public EmployeeRepo(AppDbContext appDbContext)
    {
        appDbContext = _appDbContext;
    }

    public async Task<ServiceResponse> AddAsync(Employee employee)
    {
        _appDbContext.Employees.Add(employee);
        await SaveChangesAsync();
    }

    public async Task<ServiceResponse> DeleteAsync(int id)
    {
        var employee = await _appDbContext.Employees.FindAsync(id);
        if(employee == null)
        {
            return new ServiceResponse(false, "User not found");
        }

        _appDbContext.Employees.Remove(employee);
        await SaveChangesAsync();
    }

    public Task<List<ServiceResponse>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse> UpdateAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    private async Task SaveChangesAsync() => await _appDbContext.SaveChangesAsync();
}
