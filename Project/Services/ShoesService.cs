using System;
using System.Collections.Generic;
using simpleshoe.Models;
using simpleshoe.Project.Repositories;

namespace simpleshoe.Project.Services
{
  public class ShoesService
  {
    private readonly ShoesRepository _repo;

    public ShoesService(ShoesRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Shoe> Get()
    {
      return _repo.Get();
    }

    public Shoe Get(string id)
    {
      Shoe exists = _repo.Get(id);
      if (exists == null) { throw new Exception("Invalid ID"); }
      return exists;
    }

    public Shoe Create(Shoe newShoe)
    {
      throw new NotImplementedException();
    }

    public Shoe Edit(Shoe editShoe)
    {
      throw new NotImplementedException();
    }

    public string Remove(string id)
    {
      throw new NotImplementedException();
    }
  }
}