﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigShool.Models;
using System.ComponentModel.DataAnnotations;

namespace BigShool.ViewModels
{
    public class CourseViewModel
    {
        [Required]

        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}, Date, Time"));
        }
    }
}