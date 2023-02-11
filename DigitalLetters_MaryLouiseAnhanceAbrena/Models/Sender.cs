using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalLetters_MaryLouiseAnhanceAbrena.Models
{
    public class Sender
    {
        /// <summary>
        /// foreign key of Sender table 
        /// </summary>
        /// <value>
        /// MessageSentId = number of sent message by senders
        /// </value>
        
        [Key]
        public int MessageSentId { get; set; }


        /// <summary>
        /// List of contacts that the sender can send message to
        /// </summary>
        /// <value>
        /// SenderContacts = all the contacts that the sender have which they can send a message to
        /// These contacts are the ones that have access to the this digital letters app
        /// </value>
        


        public string SenderContacts { get; set; }



        /// <summary>
        /// Message of the Sender
        /// </summary>
        /// <value>
        /// SenderMessage = message that the sender have sent 
        /// </value>
        public string SenderMessage { get; set; }

    }
}