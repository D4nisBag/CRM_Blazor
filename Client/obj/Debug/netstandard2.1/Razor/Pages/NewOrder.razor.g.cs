#pragma checksum "C:\Users\danes\OneDrive\Рабочий стол\Обучение\Практика\Практики\CRM_Blazor\Client\Pages\NewOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1d3526552fb272851a28b20fda0dfa1ed5b374"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/new-order")]
    public partial class NewOrder : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"window__container new-order__container\">\r\n    <div class=\"window__upper\">\r\n        <h2 class=\"auth__title\">\r\n            Оставить заявку\r\n        </h2>\r\n    </div>\r\n    <div class=\"window__lower new-order__lower\">\r\n        <p class=\"auth__lower-par\">\r\n            Оставьте заявку, мы с вами свяжемся\r\n        </p>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">\r\n                Название\r\n            </label>\r\n            <input id=\"name\" type=\"text\" class=\"new-order__input\" placeholder=\"Введите название заявки\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"message\">\r\n                Сообщение*\r\n            </label>\r\n            <input id=\"message\" type=\"text\" class=\"new-order__input\" placeholder=\"Сообщение*\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"dispatch\">\r\n                Адрес отправления\r\n            </label>\r\n            <input id=\"dispatch\" type=\"text\" class=\"new-order__input\" placeholder=\"Адрес отправления\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"target\">\r\n                Адрес прибытия\r\n            </label>\r\n            <input id=\"target\" type=\"text\" class=\"new-order__input\" placeholder=\"Адрес прибытия\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"weight\">\r\n                Общий вес\r\n            </label>\r\n            <input id=\"weight\" type=\"text\" class=\"new-order__input\" placeholder=\"Общий вес товара\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"products\">\r\n                Отправляемый товар\r\n            </label>\r\n            <input id=\"products\" type=\"text\" class=\"new-order__input\" placeholder=\"Перечислите отправляемый товар\">\r\n        </div>\r\n        \r\n        <button class=\"new-order btn\">Отправить</button>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
