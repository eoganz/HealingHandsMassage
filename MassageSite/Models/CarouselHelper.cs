using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MassageSite.Models
{
    public class CarouselHelper
    {
        //Haven't integrated yet. Need to make sure I don't need more fields
        [Key]
        int number;
        string link;
        string errorText;
        

        public CarouselHelper(string link, string errorText)
        {
            this.link = link;
            this.errorText = errorText;
        }


    }
}