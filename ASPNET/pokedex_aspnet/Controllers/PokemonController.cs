using Microsoft.AspNetCore.Mvc;
using PokedexApi.Models;
using PokedexApi.Services;

namespace PokedexApi.Controllers;

// CONTROLLER - Handles all HTTP requests and returns JSON responses
[ApiController]
[Route("api/pokemon")]
public class PokemonController : ControllerBase
{
    private readonly PokemonService _service;

    public PokemonController(PokemonService service)
    {
        _service = service;
    }

    // GET ALL - GET http://localhost:5000/api/pokemon
    [HttpGet]
    public IActionResult GetAll()
    {
        var list = _service.GetAll();
        return Ok(list);
    }

    // GET BY ID - GET http://localhost:5000/api/pokemon/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var pokemon = _service.GetById(id);
        if (pokemon == null)
            return NotFound($"Pokemon with ID {id} not found");
        return Ok(pokemon);
    }

    // ADD - POST http://localhost:5000/api/pokemon
    [HttpPost]
    public IActionResult Add([FromBody] Pokemon pokemon)
    {
        var saved = _service.Add(pokemon);
        return StatusCode(201, saved);
    }

    // UPDATE - PUT http://localhost:5000/api/pokemon/1
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Pokemon pokemon)
    {
        var updated = _service.Update(id, pokemon);
        if (updated == null)
            return NotFound($"Pokemon with ID {id} not found");
        return Ok(updated);
    }

    // DELETE - DELETE http://localhost:5000/api/pokemon/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        bool deleted = _service.Delete(id);
        if (!deleted)
            return NotFound($"Pokemon with ID {id} not found");
        return Ok($"Pokemon with ID {id} deleted successfully");
    }
}
