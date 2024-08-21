using System;
using System.ComponentModel.DataAnnotations;
namespace EventHub.Models;


public class Event
{

    public int Id { get; set; }

    [Required(ErrorMessage = "The Title field is required")]
    [MaxLength(100)]
    public string? Title { get; set; } = null;
     [Required]
    public DateTime Date { get; set; } = DateTime.Now;

    [Required]
    [EmailAddress]
    public string? Email { get; set; } = null;



}


