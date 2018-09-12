using Artists.DAL.Entities;
using Artists.DAL.Entities.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Artists.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var artists = _unitOfWork.Artists.GetAll();

            return View(artists);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var details = _unitOfWork.Artists.GetArtistWithDetails(id);

            if (details == null)
                return NotFound();

            return View(details);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Country,City,Site,BirthDate")] Artist artist)
        {
            if (!ModelState.IsValid)
                return View(artist);

            _unitOfWork.Artists.Add(artist);
            _unitOfWork.Commit();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var artist = _unitOfWork.Artists.Get(id);
            if (artist == null)
                return NotFound();

            return View(artist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Country,City,Site,BirthDate")] Artist artist)
        {
            if (id != artist.Id)
                return NotFound();

            if (!ModelState.IsValid)
                return View(artist);

            try
            {
                _unitOfWork.Artists.Update(artist);
                _unitOfWork.Commit();
            }
            catch
            {
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var artist = _unitOfWork.Artists.Get(id);
            if (artist == null)
                return NotFound();

            return View(artist);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            var artist = _unitOfWork.Artists.Get(id);

            _unitOfWork.Artists.Remove(artist);
            _unitOfWork.Commit();

            return RedirectToAction(nameof(Index));
        }
    }
}