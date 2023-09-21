using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AdetsisV2._0.Components
{
    public class RightbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
