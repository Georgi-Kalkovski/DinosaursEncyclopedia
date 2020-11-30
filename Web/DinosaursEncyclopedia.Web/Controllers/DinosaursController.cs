namespace DinosaursEncyclopedia.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using DinosaursEncyclopedia.Data;
    using DinosaursEncyclopedia.Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class DinosaursController : Controller
    {
        private readonly ApplicationDbContext db;

        [BindProperty]
        public Dinosaur Dinosaur { get; set; }

        public DinosaursController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Upsert(int? id)
        {
            this.Dinosaur = new Dinosaur();
            if (id == null)
            {
                return this.View(this.Dinosaur);
            }

            this.Dinosaur = this.db.Dinosaurs.FirstOrDefault(d => d.Id == id);
            if (this.Dinosaur == null)
            {
                return this.NotFound();
            }

            return this.View(this.Dinosaur);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            // Dino = new Dino();
            if (this.ModelState.IsValid)
            {
                if (this.Dinosaur.Id == 0)
                {
                    this.db.Dinosaurs.Add(this.Dinosaur);
                }
                else
                {
                    this.db.Dinosaurs.Update(this.Dinosaur);
                }

                this.db.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return this.View(this.Dinosaur);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return this.Json(new { data = await this.db.Dinosaurs.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var dinosaurs = await this.db.Dinosaurs.FirstOrDefaultAsync(u => u.Id == id);
            if (dinosaurs != null)
            {
                this.db.Dinosaurs.Remove(dinosaurs);
                await this.db.SaveChangesAsync();
                return this.Json(new { success = true, message = "Delete successful" });
            }

            return this.Json(new { success = false, message = "Error while Deleting" });
        }
    }
}
