using StorageAssessment.Models;

namespace StorageAssessment.Repository
{
    public interface IFileRepository
    {
        Task Create(FileModel fileModel);
        Task<bool> EntryExists(string name, string location);
    }
}