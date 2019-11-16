﻿using System;

namespace JsonPlaceholderApp.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}