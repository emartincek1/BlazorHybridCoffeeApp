namespace CoffeeBrowser.Maui.Data;

public class CoffeeService : ICoffeeService
{
    public async Task<IEnumerable<Coffee>> LoadCoffeesAsync()
    {
        var coffees = new[]
        {
            new Coffee("Cappuccino", "Coffee with milk foam"),
            new Coffee("Doppio", "Double espresso")
        };

        // Simulate some server work
        await Task.Delay(50);

        return coffees;
    }
}
