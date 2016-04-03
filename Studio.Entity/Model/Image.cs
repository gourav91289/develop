using System;
using System.ComponentModel.DataAnnotations;

namespace com.boutique.Entity
{
    public class Image : Audit
    {
        public int Id { get; set; }      
        public string FileType { get; set; }
        public byte[] ImageItem { get; set; }
        public string FileSize { get; set; }
        public string FileName { get; set; }
    }
}
