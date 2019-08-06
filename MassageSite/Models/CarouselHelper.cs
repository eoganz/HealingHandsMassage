using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MassageSite.Models
{
    public class CarouselHelper
    {
        //Haven't integrated yet. Need to make sure I don't need more fields
        
        public virtual DbSet<Image> Images { get; set; }


        public void RotateCarousel(int currNum, string href)
        {
            throw new NotImplementedException();
        }


    }

    public class Image
    {
        string Link;
        string ErrorText;
        string Caption;

        public Image(string link, string errorText, string caption)
        {
            this.Link = link;
            this.ErrorText = errorText;
            this.Caption = caption;
            
        }
    }

}