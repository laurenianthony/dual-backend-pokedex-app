package com.pokedex.controller;

import com.pokedex.model.Pokemon;
import com.pokedex.service.PokemonService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/pokemon")
@CrossOrigin(origins = "*")
public class PokemonController {

    private final PokemonService service;

    public PokemonController(PokemonService service) {
        this.service = service;
    }

    // GET ALL - GET http://localhost:8080/api/pokemon
    @GetMapping
    public ResponseEntity<List<Pokemon>> getAll() {
        return ResponseEntity.ok(service.getAll());
    }

    // GET BY ID - GET http://localhost:8080/api/pokemon/1
    @GetMapping("/{id}")
    public ResponseEntity<?> getById(@PathVariable int id) {
        return service.getById(id)
            .map(p -> ResponseEntity.ok((Object) p))
            .orElse(ResponseEntity.status(HttpStatus.NOT_FOUND).body("Pokemon with ID " + id + " not found"));
    }

    // ADD - POST http://localhost:8080/api/pokemon
    @PostMapping
    public ResponseEntity<Pokemon> add(@RequestBody Pokemon pokemon) {
        return ResponseEntity.status(HttpStatus.CREATED).body(service.add(pokemon));
    }

    // UPDATE - PUT http://localhost:8080/api/pokemon/1
    @PutMapping("/{id}")
    public ResponseEntity<?> update(@PathVariable int id, @RequestBody Pokemon pokemon) {
        return service.update(id, pokemon)
            .map(p -> ResponseEntity.ok((Object) p))
            .orElse(ResponseEntity.status(HttpStatus.NOT_FOUND).body("Pokemon with ID " + id + " not found"));
    }

    // DELETE - DELETE http://localhost:8080/api/pokemon/1
    @DeleteMapping("/{id}")
    public ResponseEntity<String> delete(@PathVariable int id) {
        if (service.delete(id)) {
            return ResponseEntity.ok("Pokemon with ID " + id + " deleted successfully");
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Pokemon with ID " + id + " not found");
    }
}
