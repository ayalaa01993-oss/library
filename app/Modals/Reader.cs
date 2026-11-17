using System;
using System.Collections.Generic;
using System.Text;

namespace App.Modals
{
    enum TypeEnum
    {
        student,
        teacher
    }
    internal class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fine { get; set; }

    }
}
