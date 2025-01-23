using EBaking_API.Interfaces;

namespace EBaking_API.Services
{
    public class InstallmentService : IInstallmentService
    {
        private readonly IInstallmentRepository _installmentRepository;

        public InstallmentService(IInstallmentRepository installmentRepository)
        {
            _installmentRepository = installmentRepository;
        }

        public async Task<string> RequestInstallmentAsync(int transactionId, int numberOfInstallments)
        {
            return await _installmentRepository.RequestInstallmentAsync(transactionId, numberOfInstallments);
        }
    }
}
