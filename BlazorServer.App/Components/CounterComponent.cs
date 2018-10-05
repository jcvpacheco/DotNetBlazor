using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorServer.App.Components
{
    public class CounterComponent : BlazorComponent
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
