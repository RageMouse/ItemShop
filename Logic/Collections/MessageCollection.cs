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
        private readonly IMessageContext _messageContext;

        public MessageCollection(IMessageContext messageContext)
        {
            _messageContext = messageContext;
        }

        public void CreateMessage(Message message)
        {
            _messageContext.CreateMessage(new MessageDTO(message.MessageId, message.Text));
        }
    }
}
