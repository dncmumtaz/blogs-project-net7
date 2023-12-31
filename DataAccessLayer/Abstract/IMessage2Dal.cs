﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Dal: IGenericDal<Message2>
    {

        List<Message2> GetListWithMessageByWriter( int id );
    }
}
