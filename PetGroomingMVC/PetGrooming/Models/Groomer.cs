using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate
                */
                //Base Info for this class
                [Key]
                public int GroomerID { get; set; }
                public string GroomerFname { get; set; }
                public string GroomerLname { get; set; }
                public string GroomerPhone { get; set; }
                public double GroomerRate { get; set; }
                public int GroomerExperiene { get; set; }

           /* A booking must reference to a groomer
        */
    }
}