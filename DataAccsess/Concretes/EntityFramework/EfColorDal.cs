﻿using DataAccsess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concretes.EntityFramework;

public class EfColorDal : IColorDal
{
    public void Add(Color entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Color entity)
    {
        throw new NotImplementedException();
    }

    public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void GetById(Color entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Color entity)
    {
        throw new NotImplementedException();
    }
}
