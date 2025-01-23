namespace EBaking_API.Interfaces
{
    public interface IInstallmentRepository
    {
        Task<string> RequestInstallmentAsync(int transactionId, int numberOfInstallments);
    }
}
