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

            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Ankylosaurus", Period = "Cretaceous Period", Diet = "Herbivore (plant-eater)", ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61m274TrXSL._AC_SX522_.jpg" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Brachiosaurus", Period = "Late Jurassic", Diet = "Ginkgo", ImageUrl = "https://www.wildrepublic.com/wp-content/uploads/2018/07/Brachiosaurus-3025-xl.jpg" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Brontosaurus", Period = "Late Jurassic", Diet = "green algae, fungi, mosses, horsetails, cycads, ginkgoes, and several families of conifers", ImageUrl = "https://www.everythingdinosaur.com/wp-content/uploads/2018/01/CollectA_Brontosaurus2.jpg" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Deinonychus", Period = "Cretaceous Period", Diet = "Tenontosaurus, Zephyrosaurus", ImageUrl = "https://www.nhm.ac.uk/resources/nature-online/life/dinosaurs/dinosaur-directory/images/reconstruction/small/DeinonychusC.jpg" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Parasaurolophus", Period = "Late Cretaceous", Diet = "herbivore", ImageUrl = "https://static.wikia.nocookie.net/jurassicworld-evolution/images/f/f7/Parathumb.png" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Plesiosaurus", Period = "Early Jurassic", Diet = "fish, squids, mollusks and other small sea creatures", ImageUrl = "https://www.everythingdinosaur.com/wp-content/uploads/2016/10/Bullyland-Elasmosaurus-model.jpg" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Pterodactyl", Period = "Late Jurassic", Diet = "small animals", ImageUrl = "https://thumbs.dreamstime.com/b/pteranodon-pterodactyl-dinosaur-white-background-pteranodon-pterodactyl-dinosaur-white-background-139129966.jpg" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Stegosaurus", Period = "Late Jurassic", Diet = "Cycad, Moss", ImageUrl = "https://i.pinimg.com/originals/f4/4b/b8/f44bb8bd5e903cbaae19e421e06ccd8b.png" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Triceratops", Period = "Late Cretaceous", Diet = "Cycad, Palm trees", ImageUrl = "https://static.wikia.nocookie.net/jurassicworld-evolution/images/9/96/Trikethumb.png" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Tyrannosaurus", Period = "Late Cretaceous", Diet = "Triceratops, Santanaraptor, Corythosaurus, Edmontosaurus, Tyrannosaurus", ImageUrl = "https://static.wikia.nocookie.net/jurrassic-wolrd/images/f/f8/T-Rex.png" });
            await dbContext.Dinosaurs.AddAsync(new Dinosaur { Name = "Velociraptor", Period = "Cretaceous Period", Diet = "Protoceratops, Shuvuuia", ImageUrl = "https://static.wikia.nocookie.net/jurassicpark/images/b/b8/Velociraptor-info-graphic.png" });
        }
    }
}
