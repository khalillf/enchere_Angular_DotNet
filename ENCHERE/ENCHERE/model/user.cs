
using System;
using System.ComponentModel.DataAnnotations;
namespace ENCHERE.model;
public class User
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Date)]
    public DateTime RegistrationDate { get; set; }

    // You can add more properties as needed, such as user roles, profile information, etc.
}
