﻿using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using MovieTutorial.Web.Modules.MovieDB.Person;

namespace MovieTutorial.MovieDB.Forms
{
    [FormScript("MovieDB.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonForm
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
       // public Int32 Gender { get; set; }
        public Gender Gender { get; set; }

        public Int32 Height { get; set; }
    }
}