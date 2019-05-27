using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;

namespace DAL.Interface.Interfaces
{
    public interface IMessageContext
    {
        void CreateMessage(MessageDTO message);
    }
}
