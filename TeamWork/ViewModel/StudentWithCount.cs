﻿using TeamWork.Models;

namespace TeamWork.ViewModel
{
    public class StudentWithCount
    {

        public IEnumerable<Student> students { get; set; }
        public int count { get; set; }
    }
}
