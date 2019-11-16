using System;

namespace JsonPlaceholderApp.Models
{
    //public class Item
    //{
    //    public Guid Id { get; set; }
    //    public string Text { get; set; }
    //    public string Description { get; set; }
    //    public byte[] Image { get; set; }
    //}

    public class Item
    {
        //public Guid Id { get; set; } = Guid.NewGuid();
        public string Image { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Thumbnail_image { get; set; }
        public string Url { get; set; }
    }
}