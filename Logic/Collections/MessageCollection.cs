using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Collections
{
    public class MessageCollection : IMessageInterface
    {
        private readonly IMessageContext _accountContext;

        public void CreateMessage(Message message)
        {
            _accountContext.CreateMessage(new MessageDTO(message.MessageId, message.Text));
        }
    }
}
