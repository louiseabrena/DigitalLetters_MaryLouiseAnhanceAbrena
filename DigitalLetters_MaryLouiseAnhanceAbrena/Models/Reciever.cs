using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalLetters_MaryLouiseAnhanceAbrena.Models
{
    public class Reciever
    {
        /// <summary>
        /// foreign key of receiver table
        /// </summary>
        /// <value>
        /// MessageReceiveId = number of received message by senders
        /// </value>

        [Key]
        public int MessageReceiveId { get; set; }


        /// <summary>
        /// List of the people that sent a message to the receiptient 
        /// </summary>
        /// <value>
        /// ReceiverContact = the name of the sender
        public string ReceiverContact { get; set; }



        /// <summary>
        /// Message of the Sender
        /// </summary>
        /// <value>
        /// RecievedMessage = message that the sender have sent 
        /// </value>
        public string ReceivedMessage { get; set; }

    }
}