using Client.Common;
using Client.Enums;
using Newtonsoft.Json;

namespace Client.Models
{
    public class File
    {
        // type	
        // string
        // Role of the file
        [JsonProperty("type")]
        public string Type { get; set; }

        // id	
        // integer
        // File ID
        [JsonProperty("id")]
        public int Id { get; set; }

        // url
        // required
        // string
        // Source URL where the file is downloaded from.
        // The use of .ai .psd and .tiff files have been depreciated,
        // if your application uses these file types or accepts these types from users you will need to add validation.
        [JsonProperty("url")]
        public string Url { get; set; }

        // options	
        // Array of objects (FileOption)
        // Array of additional options for this file See examples
        [JsonProperty("options")]
        public List<FileOption> Options { get; set; }

        // hash	
        // string
        // MD5 checksum of the file
        [JsonProperty("hash")]
        public string Hash { get; set; }

        // filename	
        // string
        // File name
        [JsonProperty("filename")]
        public string Filename { get; set; }

        // mime_type	
        // string
        // MIME type of the file
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        // size	
        // integer
        // Size in bytes
        [JsonProperty("size")]
        public int Size { get; set; }

        // width	
        // integer
        // Width in pixels
        [JsonProperty("width")]
        public int Width { get; set; }

        // height	
        // integer
        // Height in pixels
        [JsonProperty("height")]
        public int Height { get; set; }

        // dpi	
        // integer
        // Resolution DPI.
        // Note: for vector files this may be indicated as only 72dpi,
        // but it doesn't affect print quality since the vector files are resolution independent.
        [JsonProperty("dpi")]
        public int Dpi { get; set; }

        // status	
        // string
        // File processing status:
        // ok - file was processed successfuly
        // waiting - file is being processed
        // failed - file failed to be processed
        [JsonProperty("status")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public FileProcessingStatus Status { get; set; }

        // created	
        // integer
        // File creation timestamp
        [JsonProperty("created")]
        public int Created { get; set; }

        // thumbnail_url	
        // string
        // Small thumbnail URL
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        // preview_url	
        // string
        // Medium preview image URL
        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }
        
        // visible	
        // boolean
        // Show file in the Printfile Library (default true)
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        // is_temporary	
        // boolean
        // Whether it is a temporary printfile.
        [JsonProperty("is_temporary")]
        public bool IsTemporary { get; set; }


    }
}