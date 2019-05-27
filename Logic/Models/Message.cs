using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Message
    {
        public int MessageId { get; }
        public string Text { get; }

        public Message(int messageId, string text)
        {
            MessageId = messageId;
            Text = text;
        }
    }
}
