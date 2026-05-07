using Microsoft.AspNetCore.Mvc.Rendering;
using ShopNest.BLL.DTOs.Order;
using ShpoNest.Models.Enums;

public class OrderIndexViewModel
{
    public IEnumerable<OrderResultDto> Orders { get; set; } = new List<OrderResultDto>();

   
    public string? SearchTerm { get; set; }
    public OrderStatus? Status { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }

    
    public int CurrentPage { get; set; } = 1;
    public int TotalPages { get; set; }
    public int TotalCount { get; set; }
    public int PageSize { get; set; } = 10;

   
    public SelectList? Statuses { get; set; }
}