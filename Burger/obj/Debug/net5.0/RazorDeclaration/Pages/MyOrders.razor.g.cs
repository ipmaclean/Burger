// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BurgerStore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using BurgerStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\iainp\OneDrive\Github\Burger\Burger\_Imports.razor"
using BurgerStore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iainp\OneDrive\Github\Burger\Burger\Pages\MyOrders.razor"
using BurgerStore.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders")]
    public partial class MyOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\iainp\OneDrive\Github\Burger\Burger\Pages\MyOrders.razor"
       
    List<Order> orders;

    protected override async Task OnParametersSetAsync()
    {

        orders = await OrderController.GetOrders();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderController OrderController { get; set; }
    }
}
#pragma warning restore 1591