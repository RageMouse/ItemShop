using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct MessageDTO
    {
        public readonly int MessageId;
        public readonly string Text;

        public MessageDTO(int messageId, string text)
        {
            MessageId = messageId;
            Text = text;
        }
    }
}
