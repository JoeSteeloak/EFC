using System;
using System.ComponentModel.DataAnnotations;

namespace EFC.Models;

public class LoanModel
{
    // Properties
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
    public required UserModel User { get; set; }

    [Required]
    public int BookId { get; set; }
    public required BookModel Book { get; set; }

    public DateOnly LoanDate { get; set; }
}