using System.Threading.Tasks;
using Abarnathy.DemographicsAPI.Data;

namespace Abarnathy.DemographicsAPI.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DemographicsDbContext _context;
        private IPatientRepository _patientRepository;

        public UnitOfWork(DemographicsDbContext context)
        {
            _context = context;
        }

        public IPatientRepository PatientRepository =>
            _patientRepository ??= new PatientRepository(_context);

        public async Task CommitAsync() =>
            await _context.SaveChangesAsync();

        public async Task RollbackAsync() =>
            await _context.DisposeAsync();
    }
}