using MentalHealthTracker.Shared.ViewModels;
using System;
using System.Collections.Generic;

namespace MentalHealthTracker.Web.Models
{
    public class EntryDisplayModel
    {
        public List<EntryViewModel> Entries { get; set; }

        /*public static implicit operator EntryDisplayModel(EntryDisplayModel v)
        {
            throw new NotImplementedException();
        }*/
    }
}