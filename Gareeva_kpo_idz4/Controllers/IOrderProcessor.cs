using Gareeva_kpo_idz4.Context;
using Gareeva_kpo_idz4.Tables;

namespace Gareeva_kpo_idz4.Controllers;

public interface IOrderProcessor
{
    void ProcessOrder(Order order);
}

public class OrderProcessor : IOrderProcessor
{
    private readonly DataBase _dbContext;

    public OrderProcessor(DataBase dbContext)
    {
        _dbContext = dbContext;
    }

    public void ProcessOrder(Order order)
    {
        Task.Delay(TimeSpan.FromSeconds(30));
        
        order.Status = "done";
        order.UpdatedAt = DateTime.Now;

        _dbContext.SaveChanges();
    }
}