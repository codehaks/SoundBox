using Microsoft.AspNetCore.Mvc;
using SoundBox.Infrastructure.Persistence.DataModel;

namespace SoundBox.Web.Controllers;

public class EmployeeController:ControllerBase
{
    private readonly ChinookDbContext _db;

    public EmployeeController(ChinookDbContext db)
    {
        _db = db;
    }

    [Route("api/employees")]
    public ActionResult GetEmployeeInfo()
    {
        return Ok(_db.Employees.Select(e=>new {e.FirstName, e.LastName}).ToList());
    }
}
