using System;
using System.ComponentModel.DataAnnotations;

namespace EFC.Models;

public class BookModel {
    // Properties
    public int Id { get; set; } 

    [Required]
    public string? Title { get; set; }

    [Required]
    public string?  Author { get; set; }
    public string?  Genre { get; set; }
    public int?  Pages { get; set; }
    public Boolean Finished { get; set; }
    public Boolean  Loaned { get; set; }
    public string?  Loaner { get; set; }
    public DateOnly?  LoanDate { get; set; }

}