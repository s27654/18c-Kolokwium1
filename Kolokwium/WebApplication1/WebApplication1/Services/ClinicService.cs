using WebApplication1.Dto;
using WebApplication1.Repositories;
namespace WebApplication1.Services;

public interface IClinicService
{
    public Task<int> GetMedicamentInfoDBAsync(GetMedicamentInfoDTO dto);
    public Task<int> DeletePatientAsync(DeletePatientDTO dto);
}

public class ClinicService : IClinicService
{
    private readonly IClinicRepository _clinicRepository;

    public ClinicService(IClinicRepository clinicRepository)
    {
        _clinicRepository = clinicRepository;
    }

    public async Task<int> GetMedicamentInfoDBAsync(GetMedicamentInfoDTO dto)
    {
        const int idOrder = 1;
        var idMecidamentList = await _clinicRepository.GetMedicamentInfoDBAsync(idMedicament: dto.IdMedicament!.Value);

        if (idMecidamentList.HasValue)
        {
            get
        }
    }

    public async Task<int> DeletePatientAsync(DeletePatientDTO dto)
    {
        var patientId = await _clinicRepository.DeletePatientAsync(idPatient: dto.IdPatient.Value);
        if (patientId.HasValue)
        {
            
        }
    }
}