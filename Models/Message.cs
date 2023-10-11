﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueProject.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}