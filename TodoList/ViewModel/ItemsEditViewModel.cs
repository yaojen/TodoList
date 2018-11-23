﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoList.ViewModel
{
    public class ItemsEditViewModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public bool? Finished { get; set; }
        public string Memo { get; set; }
    }
}