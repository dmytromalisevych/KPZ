using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string Login { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }
}
