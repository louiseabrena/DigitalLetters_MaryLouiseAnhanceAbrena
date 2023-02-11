using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalLetters_MaryLouiseAnhanceAbrena.Models
{
    public class DigitalLetters
    {
        // THIS TABLE IS LIKE A VIEW TABLE, it summarizes all the letters sent and recieved between the users of the app
        /// <summary>
        /// foreign key of digital letters table
        /// </summary>
        /// <value>
        /// LetterId = number of exchange messages between senders and recievers
        /// </value>
        [Key]
        public int LetterId { get; set; }


        /// <summary>
        /// List of senders
        /// </summary>
        /// <value>
        /// sender of the letter
        /// </value>



        public string SenderName { get; set; }



        /// <summary>
        /// Message of the sender
        /// </summary>
        /// <value>
        /// SenderMessage = message that the sender have sent 
        /// </value>
        public string LetterMessage { get; set; }


        /// <summary>
        /// List of reciever
        /// </summary>
        /// <value>
        /// who got the letter
        /// </value>


        public string RecieverName { get; set; }


    }
}