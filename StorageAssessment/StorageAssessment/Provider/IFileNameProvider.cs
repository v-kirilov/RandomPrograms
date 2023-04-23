using StorageAssessment.Models;

namespace StorageAssessment.Provider
{
    public interface IFileNameProvider
    {
        Task<IEnumerable<FileModel>> Get();
    }
}