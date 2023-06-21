using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ts910.ChatBox
{
    [Serializable]
    public class SocketData
    {
        private int command;

        public int Command
        {
            get { return command; }
            set { command = value; }
        }

        private string message,image;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public SocketData(int command, string message, string image)
        {
            this.Command = command;
            this.Message = message;
            this.Image = image;
        }
    }

    public enum SocketCommand
    {
        QUIT,
        SEND_MESSAGE
    }
}
