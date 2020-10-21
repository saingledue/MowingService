#pragma checksum "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd390128fa47161f422ffd80da7407d7a9555ab5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientWebAssembly.Pages.Employee
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
#line 12 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using BlazorClientWebAssembly.Models.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\_Imports.razor"
using BlazorClientWebAssembly.Models.Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
using System.ComponentModel.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employee/DisplayEmployee/{employeeId:int}")]
    public partial class DisplayEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Display Employee</h3>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
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
#line 13 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
        errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 14 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<td><strong>First Name</strong></td>\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 21 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                     employeeInfo.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<td><strong>Last Name</strong></td>\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 25 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                     employeeInfo.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<td><strong>Age</strong></td>\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 29 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                     employeeInfo.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, "<td><strong>Location</strong></td>\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 33 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                     businessInfo.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "colspan", "2");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 37 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                     if (confirmDelete)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-outline-danger");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                                                                         HandleDeleteRecord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "\r\n                            Confirm Delete\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.AddContent(51, "                        ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "btn btn-secondary");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                                                                    (() => confirmDelete = false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "\r\n                            Cancel\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 46 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                        ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                                                                 (() => confirmDelete = true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "\r\n                            Delete\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 52 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.AddContent(68, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(69);
            __builder.AddAttribute(70, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 61 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                      updateModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 61 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(74);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(76);
                __builder2.AddAttribute(77, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
                                   updateModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 75 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\saing\source\repos\BlazorClientWebAssembly\BlazorClientWebAssembly\Pages\Employee\DisplayEmployee.razor"
       

    [Parameter]
    public int employeeId { get; set; }

    public EmployeeModel employeeInfo = new EmployeeModel();
    private EmployeeModel updateModel = new EmployeeModel();

    public BusinessModel businessInfo = new BusinessModel();

    private string errorString;
    private bool confirmDelete = false;

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response = await Http.GetAsync($"api/employee/{employeeId}");

        if (response.IsSuccessStatusCode)
        {
            employeeInfo = await response.Content.ReadFromJsonAsync<EmployeeModel>();
        }
        else
        {
            errorString = response.ReasonPhrase;
        }
        HttpResponseMessage businessResponse = await Http.GetAsync($"api/business/{employeeInfo.BusinessId}");

        if (businessResponse.IsSuccessStatusCode)
        {
            businessInfo = await businessResponse.Content.ReadFromJsonAsync<BusinessModel>();
        }
        else
        {
            errorString = businessResponse.ReasonPhrase;
        }
    }

    private async Task HandleValidSubmit()
    {
        try
        {
            HttpResponseMessage response = await Http.PutAsJsonAsync("api/employee", updateModel);
        }
        catch (Exception ex)
        {
            errorString = ex.Message;
        }
    }

    //TODO: not implemented.
    private async Task HandleDeleteRecord()
    {
        HttpResponseMessage response = await Http.DeleteAsync($"api/employee/{employeeId}");

        if (response.IsSuccessStatusCode)
        {
            navigationManager.NavigateTo("employee/list");
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
