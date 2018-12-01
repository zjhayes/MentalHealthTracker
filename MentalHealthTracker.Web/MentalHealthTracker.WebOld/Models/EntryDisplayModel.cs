using MentalHealthTracker.Shared.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MentalHealthTracker.Web.Models
{
    [Authorize]
    public class EntryDisplayModel
    {
        public List<EntryViewModel> Entries { get; set; }

    }
}