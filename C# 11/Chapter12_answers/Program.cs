// See https://aka.ms/new-console-template for more information
// SQLite database provider-generated code
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Column(TypeName = "nvarchar (15)")]
public string CategoryName { get; set; } = null!;
// SQL Server database provider-generated code
[StringLength(15)]
public string CategoryName { get; set; } = null!;

public string CategoryName { get; set; } = null!;
// nullable property
public string? Description { get; set; }
// decorate with attribute to perform runtime validation
[Required]
public string CategoryName { get; set; } = null!;


