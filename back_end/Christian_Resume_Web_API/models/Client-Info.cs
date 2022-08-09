using System.ComponentModel.DataAnnotations;


namespace Christian_Resume_Web_API.models
{
    public class Client_Info
    {
        [Key]
        public int? Client_Id { get; set; }
        public string CLient_Name { get; set; }
        public string Client_Email { get; set; }
        public int? Client_PhoneNumber { get; set; }


    }
}
