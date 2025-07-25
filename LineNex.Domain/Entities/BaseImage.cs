using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace LineNex.Domain.Entity
{
    public class BaseImage : BaseEntity
    {
        [NotMapped]
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public string FilePath { get; set; }
    }
}