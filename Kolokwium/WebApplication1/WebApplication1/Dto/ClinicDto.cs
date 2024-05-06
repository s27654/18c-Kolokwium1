using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Dto;

public class GetMedicamentInfoDTO
{
    [Required]
    public int? IdMedicament { get; set; }
}

public class DeletePatientDTO
{
    [Required]
    public int? IdPatient { get; set; }
}