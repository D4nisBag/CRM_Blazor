// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Crm_WASM.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Crm_WASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Crm_WASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
using Crm_WASM.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
using Crm_WASM.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
       
    

        protected override async Task OnInitializedAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var customer = authState.User;

            if(customer.Identity.IsAuthenticated)
            {
                var claim = customer.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);
                _profileViewModel.Id = Convert.ToInt64(claim?.Value);
                await _profileViewModel.GetProfile();
            }
            else
            {

            }
        }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProfileViewModel _profileViewModel { get; set; }
    }
}
#pragma warning restore 1591
