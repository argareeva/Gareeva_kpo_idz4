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

    public async void ProcessOrder(Order order)
    {
        await Task.Delay(TimeSpan.FromSeconds(30));
        
        order.Status = "выполнен";
        order.UpdatedAt = DateTime.Now;

        _dbContext.SaveChanges();
    }
}