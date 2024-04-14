using Microsoft.AspNetCore.Mvc;
using SrcASP.Services.Contracts;
using SrcASP.Services.Dto.Models;

namespace SrcASP.Controllers;

[Route("api/events")]
[ApiController]
public class EventController : ControllerBase
{
    private readonly EventService _eventService;

    public EventController(EventService eventService)
    {
        ArgumentNullException.ThrowIfNull(eventService);
        _eventService = eventService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EventDto>> GetById(int id)
    {
        try
        {
            var eventDto = await _eventService.GetById(id);
            return Ok(eventDto);
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EventDto>>> GetAll()
    {
        var events = await _eventService.GetAll();
        return Ok(events);
    }

    [HttpPost]
    public async Task<IActionResult> Create(EventDto eventDto)
    {
        await _eventService.Create(eventDto);
        return CreatedAtAction(nameof(GetById), new { id = eventDto.Id }, eventDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, EventDto eventDto)
    {
        try
        {
            await _eventService.Update(id, eventDto);
            return NoContent();
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _eventService.Delete(id);
            return NoContent();
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }
}