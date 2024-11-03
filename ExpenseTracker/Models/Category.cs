using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models;

public class Category
{
    [Key] public int Id { get; set; }
    [Column(TypeName = "nvarchar(50)")] public string Title { get; set; }
    [Column(TypeName = "nvarchar(5)")] public string Icon { get; set; }
    [Column(TypeName = "nvarchar(10)")] public string Type { get; set; } = "Expense";
}

public class Transaction
{
    [Key] public int Id { get; set; }
    [Column(TypeName = "nvarchar(50)")] public string Title { get; set; }
    public double Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    [Column(TypeName = "nvarchar(50)")] public double Note { get; set; }
}