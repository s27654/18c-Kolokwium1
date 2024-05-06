using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;
using WebApplication1.Exceptions;
using WebApplication1.Services;
namespace WebApplication1.Controllers;
[ApiController]
[Route("/api/[controller]")]
public class DBController : ControllerBase
{
    private readonly IClinicService _clinicService;

    public DBController(IClinicService clinicService)
    {
        _clinicService = clinicService;
    }

    [HttpGet]

    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetMedicamentInfo([FromBody] GetMedicamentInfoDTO dto)
    {
        try
        {
            var medicamentId = _clinicService.GetMedicamentInfoDBAsync(dto);
            return Ok(medicamentId);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePatient([FromBody] DeletePatientDTO dto)
    {
        try
        {

        }
        catch(NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}