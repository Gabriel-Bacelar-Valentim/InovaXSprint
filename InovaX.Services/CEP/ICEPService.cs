namespace InovaX.Services.CEP
{
    public interface ICEPService
    {
        Task<AddressResponse?> FindCEP(string cep);
    }
}
