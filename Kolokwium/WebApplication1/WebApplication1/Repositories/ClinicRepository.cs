using System.Data;
using System.Data.SqlClient;
namespace WebApplication1.Repositories;

public interface IClinicRepository
{
    public async Task<int?> GetMedicamentInfoDBAsync(int idMedicament);
    public async Task<int?> DeletePatientAsync(int idPatient);

}

public class ClinicRepository : IClinicRepository
{
    private readonly IConfiguration _configuration;

    public ClinicRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<int?> GetMedicamentInfoDBAsync(int idMedicament)
    {
        await using var connection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        await connection.OpenAsync();
        await using var transaction = await connection.BeginTransactionAsync();
        try
        {
            var query = "UPDATE \"Order\"
        }
    }
    public async Task<int?> DeletePatientAsync(int idPatient
    {
        await using var connection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        await connection.OpenAsync();
        await using var transaction = await connection.BeginTransactionAsync();
        try
        {
            var query = "Delete "
        }
    }
    )
}