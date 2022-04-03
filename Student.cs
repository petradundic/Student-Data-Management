﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITsistemi
{
    class Student
    {
        public int studentId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string status { get; set; }
        public int godina { get; set; }

        public string getFullName()
        {
            return $"{ime} {prezime}";
        }
    }
}
