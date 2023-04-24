﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BARAZAIS.Data.Models;

public class UserModel : IdentityUser<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public override int Id { get; set; }

    public DateTime DateUpdated { get; private set; }
    public DateTime DateCreated { get; set; }

#nullable enable

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required]
    public string? Address { get; set; }

    public UserModel() 
    {
        this.DateUpdated = DateTime.Now;
        this.Address = null;
    }
}
