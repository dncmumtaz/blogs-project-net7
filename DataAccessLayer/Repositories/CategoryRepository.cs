﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository: ICategoryDal
    {
        Context c;

        public void AddCategory( Category category )
        {
            c.Add( category );
            c.SaveChanges();
        }

        public void Delete( Category item )
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory( Category category )
        {
            c.Remove( category );
            c.SaveChanges();
        }

        public Category GetById( int id )
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert( Category item )
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void Update( Category item )
        {
            throw new NotImplementedException();
        }

        public void Updatecategory( Category category )
        {
            c.Update( category );
            c.SaveChanges();
        }
    }
}