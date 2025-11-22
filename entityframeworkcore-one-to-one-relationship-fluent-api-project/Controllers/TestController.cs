using entityframeworkcore_one_to_one_relationship_example_project.Models;
using entityframeworkcore_one_to_one_relationship_example_project.Repo;
using Microsoft.AspNetCore.Mvc;

namespace entityframeworkcore_one_to_one_relationship_example_project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly Repository _repository;

    public TestController(Repository repository)
    {
        this._repository = repository;
    }

    [HttpGet("get-companies")]
    public async Task<IActionResult> GetCarCompanies()
    {
        return Ok(await _repository.GetCarCompanies());
    }

    [HttpPost("add-company")]
    public async Task<IActionResult> AddCarCompany(CarCompany carCompany)
    {
        await _repository.AddCarCompany(carCompany);
        return Ok("Company Saved");
    }

    [HttpGet("get-models")]
    public async Task<IActionResult> GetCarModels()
    {
        return Ok(await _repository.GetCarModels());
    }

    [HttpPost("add-model")]
    public async Task<IActionResult> AddModel(CarModel carModel)
    {
        await _repository.AddCarModel(carModel);
        return Ok("Model Saved");
    }
}