using System;
namespace CommonModel.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime Released { get; set; }
    }
}