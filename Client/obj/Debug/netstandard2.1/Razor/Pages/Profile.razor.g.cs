#pragma checksum "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6000fedd749c456e4373f7ada5683b24ef9918"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "window__container new-order__container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"window__upper\">\r\n        <h2 class=\"auth__title\">\r\n            Мой профиль\r\n        </h2>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "window__lower new-order__lower");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"firstname\">\r\n                Имя\r\n            </label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "id", "firstname");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "new-order__input");
            __builder.AddAttribute(15, "placeholder", "Имя");
            __builder.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
                                _profileViewModel.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.Name = __value, _profileViewModel.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<label for=\"surname\">\r\n                Фамилия\r\n            </label>\r\n            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "id", "surname");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "new-order__input");
            __builder.AddAttribute(28, "placeholder", "Фамилия");
            __builder.AddAttribute(29, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
                                _profileViewModel.Surname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.Surname = __value, _profileViewModel.Surname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<label for=\"lastname\">\r\n                Отчество\r\n            </label>\r\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "id", "lastname");
            __builder.AddAttribute(39, "type", "text");
            __builder.AddAttribute(40, "class", "new-order__input");
            __builder.AddAttribute(41, "placeholder", "Отчество");
            __builder.AddAttribute(42, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
                                _profileViewModel.Lastname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.Lastname = __value, _profileViewModel.Lastname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.AddMarkupContent(49, "<label for=\"email\">\r\n                E-mail\r\n            </label>\r\n            ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "id", "email");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "class", "new-order__input");
            __builder.AddAttribute(54, "placeholder", "E-mail");
            __builder.AddAttribute(55, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
                                _profileViewModel.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.Email = __value, _profileViewModel.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.AddMarkupContent(62, "<label for=\"phone\">\r\n                Номер телефона\r\n            </label>\r\n            ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "id", "phone");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "new-order__input");
            __builder.AddAttribute(67, "placeholder", "Номер телефона");
            __builder.AddAttribute(68, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
                                _profileViewModel.PhoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.PhoneNumber = __value, _profileViewModel.PhoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
                          _profileViewModel.UpdateProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "class", "new-order btn");
            __builder.AddMarkupContent(75, "Изменить данные");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.AddMarkupContent(77, "<span>&nbsp;</span>\r\n        ");
#nullable restore
#line 48 "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Profile.razor"
__builder.AddContent(78, _profileViewModel.Message);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
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
