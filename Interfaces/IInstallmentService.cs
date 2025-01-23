namespace EBaking_API.Interfaces
{
    public interface IInstallmentService
    {
        Task<string> RequestInstallmentAsync(int transactionId, int numberOfInstallments);

    }
}
