using Microsoft.AspNetCore.Mvc;

namespace AdetsisV2._0.Components
{
    public class LeftbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
