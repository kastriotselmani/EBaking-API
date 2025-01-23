using EBaking_API.Interfaces;

namespace EBaking_API.Repositories
{
    public class InstallmentRepository : IInstallmentRepository
    {
        public async Task<string> RequestInstallmentAsync(int transactionId, int numberOfInstallments)
        {
            // Simulating installment request processing
            return $"Transaction {transactionId} has been converted to {numberOfInstallments} installments.";
        }
    }
}
