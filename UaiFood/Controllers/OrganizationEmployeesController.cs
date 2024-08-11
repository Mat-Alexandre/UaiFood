using UaiFood.Context;
using UaiFood.Models;

namespace UaiFood.Controllers;

public static class OrganizationEmployeesController 
{
    public static async Task<IResult> CreateEmployee(OrganizationEmployee organizationEmployee, OrganizationContext _context)
    {
        _context.Employees.Add(organizationEmployee);
        await _context.SaveChangesAsync();

        return Results.Created($"/api/organizationemployee", organizationEmployee);
    }
}
