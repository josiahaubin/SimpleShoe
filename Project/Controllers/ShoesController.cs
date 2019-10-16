using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simpleshoe.Models;
using simpleshoe.Project.Services;

namespace simpleshoe.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ShoesController : ControllerBase
  {
    private readonly ShoesService _ss;
    public ShoesController(ShoesService ss)
    {
      _ss = ss;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Shoe>> Get()
    {
      try
      {
        return Ok(_ss.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Shoe> Get(string id)
    {
      try
      {
        return Ok(_ss.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Shoe> Post([FromBody] Shoe newShoe)
    {
      try
      {
        return Ok(_ss.Create(newShoe));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Shoe> Put(string id, [FromBody] Shoe editShoe)
    {
      try
      {
        editShoe.Id = id;
        return Ok(_ss.Edit(editShoe));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(string id)
    {
      try
      {
        return Ok(_ss.Remove(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}