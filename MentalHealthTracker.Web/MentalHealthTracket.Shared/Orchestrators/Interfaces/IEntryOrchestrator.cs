using MentalHealthTracker.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MentalHealthTracker.Shared.Orchestrators.Interfaces
{
    public interface IEntryOrchestrator
    {
        Task<List<EntryViewModel>> GetAllEntries();
        Task<int> CreateEntry(EntryViewModel entry);
    }
}
