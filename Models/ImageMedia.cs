using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chronos.Models
{
    public class ImageMedia
    {
        public Guid MediaId { get; set; }
        public DateTime LocalDateTime { get; set; }
        public string Path { get; set; }
        public FileImageSource Source => source ?? (source = new FileImageSource() { File = Path });

        private FileImageSource source = null;
    }
}
