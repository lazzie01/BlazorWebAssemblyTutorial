#pragma checksum "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669922df1568ffce89751580c17624b3001dd53f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProject.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using BlazorProject.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/all")]
    public partial class AllEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width:1100px");
            __Blazor.BlazorProject.Client.Pages.AllEmployees.TypeInference.CreateSfGrid_0(__builder, 2, 3, 
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                              Employees

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                                                      true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(9);
                    __builder3.AddAttribute(10, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                nameof(Employee.EmployeeId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "HeaderText", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(13);
                    __builder3.AddAttribute(14, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                nameof(Employee.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "HeaderText", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(17);
                    __builder3.AddAttribute(18, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                nameof(Employee.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "HeaderText", "Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(21);
                    __builder3.AddAttribute(22, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                nameof(Employee.DateOfBirth)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "HeaderText", "Date of Birth");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(25);
                    __builder3.AddAttribute(26, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                nameof(Employee.Gender)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "HeaderText", "Gender");
                    __builder3.AddAttribute(28, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, DropDownListItem>>(29);
                        __builder4.AddAttribute(30, "Placeholder", "All");
                        __builder4.AddAttribute(31, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<DropDownListItem>>(
#nullable restore
#line 15 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                                                   genderDropDownSource

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(33);
                            __builder5.AddAttribute(34, "Value", "Value");
                            __builder5.AddAttribute(35, "Text", "Text");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                        ");
                            __builder5.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, DropDownListItem>>(37);
                            __builder5.AddAttribute(38, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownListItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownListItem>>(this, 
#nullable restore
#line 17 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                                                                                   GenderSelectionChange

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(40);
                    __builder3.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                                nameof(Employee.Email)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "HeaderText", "Email");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 43, (__value) => {
#nullable restore
#line 7 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
                   employeeGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Projects\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\AllEmployees.razor"
      

    public List<Employee> Employees { get; set; }

    public SfGrid<Employee> employeeGrid { get; set; }

    protected async void GenderSelectionChange(ChangeEventArgs<string, DropDownListItem> args)
    {
        if(args.Value == "All")
        {
           await employeeGrid.ClearFilteringAsync("Gender");
        }
        else
        {
            await employeeGrid.FilterByColumnAsync("Gender", "equal", args.Value);

        }
    }

    [Inject]
    public IEmployeeService EmployeeService { get; set; }

    public List<DropDownListItem> genderDropDownSource = EnumHelper.ConvertEnumToDropDownSource<Gender>("All", "All");

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeService.GetAllEmployees()).ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorProject.Client.Pages.AllEmployees
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowFiltering", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.AddComponentReferenceCapture(__seq4, (__value) => { __arg4((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
