using System;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Contexts;
using Microsoft.Ajax.Utilities;
using System.Reflection.Emit;

namespace WebApplication3.Models


{

    public class Register

    {

        [Required]

        [Key]

        public string FirstName { get; set; }

        [Required]

        public string Email { get; set; }

        public string Gender { get; set; }

        }

    }