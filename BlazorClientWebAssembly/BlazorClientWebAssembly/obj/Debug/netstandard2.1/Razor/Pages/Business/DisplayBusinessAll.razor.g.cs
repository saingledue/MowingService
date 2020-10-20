#pragma checksum "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b7201f865eb292a741c94210cb4fe863733de2c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientWebAssembly.Pages.Business
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using BlazorClientWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using BlazorClientWebAssembly.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using BlazorClientWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using BlazorClientWebAssembly.Models.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
using System.ComponentModel.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Business/DisplayBusinessAll")]
    public partial class DisplayBusinessAll : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DisplayBusinessAll</h3>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h4>System Error</h4>\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#nullable restore
#line 13 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
        errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 14 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-striped");
            __builder.AddAttribute(9, "style", "margin-top: 25px");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<thead>\r\n            <tr>\r\n                <th>Location</th>\r\n                <th>Open Hours</th>\r\n                <th>Close Hours</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 28 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
             foreach (var business in businessInfo)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
                         business.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
                         business.OpenHours

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
                         business.CloseHours

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "colspan", "2");
            __builder.AddMarkupContent(28, "\r\n\r\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
                                                                   b => HandleDeleteRecord(business.BusinessId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n                            Delete\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 60 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddMarkupContent(39, "    \r\n");
            __builder.AddMarkupContent(40, "        \r\n");
#nullable restore
#line 79 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Business\DisplayBusinessAll.razor"
       

    public List<BusinessModel> businessInfo = new List<BusinessModel>();

    private string errorString;
    //private bool confirmDelete = false;

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response = await Http.GetAsync($"api/business");

        if (response.IsSuccessStatusCode)
        {
            businessInfo = await response.Content.ReadFromJsonAsync<List<BusinessModel>>();
        }
        else
        {
            errorString = response.ReasonPhrase;
        }
    }

    //private async Task HandleValidSubmit()
    //{
    //    try
    //    {
    //        HttpResponseMessage response = await Http.PutAsJsonAsync("api/business", updateModel);
    //    }
    //    catch (Exception ex)
    //    {
    //        errorString = ex.Message;
    //    }
    //}

    private async Task HandleDeleteRecord(int businessId)
    {
        HttpResponseMessage response = await Http.DeleteAsync($"api/business/{businessId}");

        if (response.IsSuccessStatusCode)
        {
            await OnInitializedAsync();
        }
        else
        {
            errorString = response.ReasonPhrase;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
