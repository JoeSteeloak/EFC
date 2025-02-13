using System;
using System.ComponentModel.DataAnnotations;

namespace EFC.Models;

public class UserModel {
    // Properties
    public int Id { get; set; } 

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string?  LastName { get; set; }

    public ICollection<BookModel>? Book { get; }

}