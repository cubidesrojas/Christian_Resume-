using System.ComponentModel.DataAnnotations;

namespace Christian_Resume_Web_API.models
{
    public class projects
    {

        public string Project_name { get; set; }
        public string Project_url { get; set; }
        [Key]
        public int Project_id { get; set; }
    }
}
