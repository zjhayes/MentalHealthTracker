using MentalHealthTracker.Shared.Orchestrators.Interfaces;
using MentalHealthTracker.Shared.ViewModels;
using MentalHealthTracker.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MentalHealthTracker.Web.Controllers
{
    [Authorize]
    public class EntryController : Controller
    {
        private readonly IEntryOrchestrator _entryOrchestrator;

        public EntryController(IEntryOrchestrator entryOrchestrator)
        {
            _entryOrchestrator = entryOrchestrator;
        }

        // GET: Entry
        [HandleError]
        public async Task<ActionResult> Index()
        {
            var entryDisplayModel = new EntryDisplayModel
            {
                Entries = await _entryOrchestrator.GetAllEntries()
            };

            return View(entryDisplayModel);
        }
        [HandleError]
        public async Task<ActionResult> Create(CreateEntryModel entry)
        {
            if (entry.Mood == 0)
            {
                return View();
            }

            IdentityDbContext authContext = new IdentityDbContext();

            var updateCount = await _entryOrchestrator.CreateEntry(new EntryViewModel
            {
                Journal = entry.Journal == null ? "None" : entry.Journal,
                Medication = entry.Medication == null ? "None" : entry.Medication,
                Mood = entry.Mood,
                User = User.Identity.GetUserId()
            });

            return RedirectToAction("Index");
        }
        [HandleError]
        public async Task<ActionResult> Statistics()
        {
            var displayEntryModel = new EntryDisplayModel()
            {
                Entries = await _entryOrchestrator.GetAllEntries()
            };
            return View(displayEntryModel);
        }
    }
}