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

        private string message,image,time;

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

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public SocketData(int command, string message, string image, string time)
        {
            this.Command = command;
            this.Message = message;
            this.Image = image;
            this.Time = time;
        }
    }

    public enum SocketCommand
    {
        QUIT,
        SEND_MESSAGE
    }
}
