using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace HelperLiabrary
{
    [Serializable]
    //This is how the client talks to the server
  public  class MessageDetails
    {
        private string messagetext;
        private DateTime nowTime;
       

        private string command;


        

        public string Messagetext
        {
            get
            {
                return messagetext;
            }

            set
            {
                messagetext = value;
            }
        }

        public DateTime NowTime
        {
            get
            {
                return nowTime;
            }

            set
            {
                nowTime = value;
            }
        }

        public string Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public MessageDetails(string messagep = "")
        {
            this.messagetext = messagep;
            this.nowTime = DateTime.Now;
        
        }


        public MessageDetails(string messagep = "", string commandp = "MessageSendRecieve")
        {
            this.messagetext = messagep;
            this.nowTime = DateTime.Now;
            this.command = commandp;
        }

        public override string ToString()
        {
            return string.Format("\n {0}, {1}",this.messagetext, this.nowTime);
        }




    }
}
