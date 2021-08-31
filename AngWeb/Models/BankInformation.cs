using System.ComponentModel.DataAnnotations;

namespace AngWeb.Models
{
  public class BankInformation
  {
    [Required]
    public string state { get; set; }
    public string institution_status_code { get; set; }
    public string office_code { get; set; }
    public string data_view_code { get; set; }
    public string message { get; set; }
    public string new_routing_number { get; set; }
    public string rn { get; set; }
    public string telephone { get; set; }
    [Required]
    public string city { get; set; }
    public string change_date { get; set; }
    [Required]
    public string zip { get; set; }
    public string customer_name { get; set; }
    public int code { get; set; }
    [Required(ErrorMessage = "{0} is a mandatory field")]
    [Range(000000000, 999999999)]
    [MinLength(9, ErrorMessage = "The {0} can not have less than {1} characters")]
    [MaxLength(10, ErrorMessage = "The {0} can not have more than {1} characters")]
    public string routing_number { get; set; }
    public string record_type_code { get; set; }
    public string address { get; set; }
  }
}

