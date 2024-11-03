using Newtonsoft.Json;

namespace InovaX.Services.CEP
{
    public class CEPService : ICEPService
    {
        public async Task<AddressResponse?> FindCEP(string cep)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://viacep.com.br/");

            HttpResponseMessage response = await client.GetAsync($"ws/{cep}/json/");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<AddressResponse>(json);
            }
            else
            {
                return null;
            }
        }
    }
}