﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager( IMessageDal messageDal )
        {
            _messageDal = messageDal;
        }

        public Message GetById( int id )
        {
            throw new NotImplementedException();
        }

        public List<Message> GetInboxListByWirter( string p )
        {
            return _messageDal.GetListAll(x => x.Reciever == p);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public void TAdd( Message t )
        {
            throw new NotImplementedException();
        }

        public void TDelete( Message t )
        {
            throw new NotImplementedException();
        }

        public void TUpdate( Message t )
        {
            throw new NotImplementedException();
        }
    }
}
