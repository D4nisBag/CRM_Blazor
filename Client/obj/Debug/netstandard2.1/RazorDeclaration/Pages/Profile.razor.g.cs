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
#line 1 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Crm_WASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\_Imports.razor"
using Crm_WASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\Pages\Profile.razor"
using Crm_WASM.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\Pages\Profile.razor"
using Crm_WASM.Shared.Models;

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
#line 51 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\THird\Client\Pages\Profile.razor"
       
    
    
    private ProfileViewModel _profileViewModel = new ProfileViewModel();
    protected override async Task OnInitializedAsync()
    {
        Customer customer = await HttpClient.GetFromJsonAsync<Customer>("customer/getprofile/3");
        _profileViewModel = customer;
        _profileViewModel.Message = "Профиль успешно загружен";
    }
    private async Task UpdateProfile()
    {
        Customer customer = _profileViewModel;
        await HttpClient.PutAsJsonAsync("customer/updateprofile/3", customer);
        _profileViewModel.Message = "Профиль успешно обновлен";
    }

    private async Task GetProfile()
    {
        Customer customer = await HttpClient.GetFromJsonAsync<Customer>("customer/getprofile/3");
        _profileViewModel = customer;
        _profileViewModel.Message = "Профиль успешно загружен";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
