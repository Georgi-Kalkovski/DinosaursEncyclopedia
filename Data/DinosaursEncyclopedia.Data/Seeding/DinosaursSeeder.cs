namespace DinosaursEncyclopedia.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using DinosaursEncyclopedia.Data.Models;

    public class DinosaursSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Dinosaurs.Any())
            {
                return;
            }

            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Ankylosaurus", Period = "Cretaceous Period", Diet = "Herbivore (plant-eater)" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Brachiosaurus", Period = "Late Jurassic", Diet = "Ginkgo" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Brontosaurus", Period = "Late Jurassic", Diet = "green algae, fungi, mosses, horsetails, cycads, ginkgoes, and several families of conifers" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Deinonychus", Period = "Cretaceous Period", Diet = "Tenontosaurus, Zephyrosaurus" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Parasaurolophus", Period = "Late Cretaceous", Diet = "herbivore" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Plesiosaurus", Period = "Early Jurassic", Diet = "fish, squids, mollusks and other small sea creatures" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Pterodactyl", Period = "Late Jurassic", Diet = "small animals" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Stegosaurus", Period = "Late Jurassic", Diet = "Cycad, Moss" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Triceratops", Period = "Late Cretaceous", Diet = "Cycad, Palm trees" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Tyrannosaurus", Period = "Late Cretaceous", Diet = "Triceratops, Santanaraptor, Corythosaurus, Edmontosaurus, Tyrannosaurus" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Velociraptor", Period = "Cretaceous Period", Diet = "Protoceratops, Shuvuuia" });
        }
    }
}
