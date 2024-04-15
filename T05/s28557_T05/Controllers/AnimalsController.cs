using s28557_T05.Database;
using Microsoft.AspNetCore.Mvc;
using s28557_T05.Endpoints;

namespace s28557_T05.Controllers;

[ApiController]
[Route("/animals-controller")]

public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
}