#pragma checksum "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f4632e8674da3d1af9d21bcc9a16203bfb59c7"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""window__container auth__container"">
    <div class=""window__upper auth__upper"">
        <h2 class=""auth__title"">
            Авторизация
        </h2>
    </div>
    <div class=""window__lower auth__lower"">
        <p class=""auth__lower-par"">
            Введите данные для доступа к системе.
        </p>
        <input type=""text"" class=""auth__input"" placeholder=""E-Mail"">
        <input type=""text"" class=""auth__input"" placeholder=""Password"">
        <button class=""auth__login btn"">Войти</button>
        <p class=""auth__register-par"">Нет аккаунта?<a href=""register"" class=""auth__press-here"">Нажмите сюда</a></p>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
