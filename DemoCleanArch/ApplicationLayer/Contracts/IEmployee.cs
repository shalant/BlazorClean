using ApplicationLayer.DTOs;
using DomainLayer.Entities;

namespace ApplicationLayer.Contracts;

public interface IEmployee
{
    Task<ServiceResponse> AddAsync(Employee employee);
    Task<ServiceResponse> UpdateAsync(Employee employee);
    Task<ServiceResponse> DeleteAsync(int id);
    Task<List<ServiceResponse>> GetAsync();
    Task<ServiceResponse> GetByIdAsync(int id);
}

