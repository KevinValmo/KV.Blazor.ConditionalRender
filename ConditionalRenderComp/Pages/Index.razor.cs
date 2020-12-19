using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConditionalRenderComp.Pages
{
    public partial class Index
    {
        private bool myBool;
        private async Task OnClick(MouseEventArgs args)
        {
            await InvokeAsync(
                () => {
                    myBool = !myBool;
                });
        }
    }
}
