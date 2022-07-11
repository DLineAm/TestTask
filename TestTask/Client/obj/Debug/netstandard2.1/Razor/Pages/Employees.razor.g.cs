#pragma checksum "G:\TestTask\TestTask\Client\Pages\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a3e4ead4a359b39fd23c3fd1a13beeefde9702"
// <auto-generated/>
#pragma warning disable 1591
namespace TestTask.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\TestTask\TestTask\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TestTask\TestTask\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\TestTask\TestTask\Client\_Imports.razor"
using TestTask.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\TestTask\TestTask\Client\_Imports.razor"
using TestTask.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
using TestTask.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees/{Id:int}")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"info__title\">Сотрудники</h1>\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddAttribute(2, "class", "info__title");
#nullable restore
#line 10 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder.AddContent(3, AppData.CurrentDivision.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                  EmployeeAddButton_OnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "main--btn inverted");
            __builder.AddMarkupContent(8, "Добавить");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 15 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<span>Загрузка</span>\r\n");
#nullable restore
#line 18 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "subdiv__wrapper");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 22 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
     foreach (var employee in employees)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "subdiv__item");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "span");
            __builder.AddAttribute(20, "style", "font-size: 20px; font-weight: 700");
#nullable restore
#line 25 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder.AddContent(21, employee.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "style", "width: 20px; cursor: pointer");
            __builder.AddAttribute(27, "src", "css/edit--green.svg");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                                                              () => EmployeeChangeButton_OnClick(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "style", "width: 20px; cursor: pointer");
            __builder.AddAttribute(33, "src", "css/delete--green.svg");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                                                                () => DeleteButton_OnClick(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 33 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 35 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
 if (modalOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.OpenComponent<TestTask.Client.Shared.Modal>(42);
            __builder.AddAttribute(43, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                   modalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                  modalText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 39 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                    Modal_OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 40 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
       
    [Parameter]
    public int Id { get; set; }

    private List<Employee> employees;
    private bool modalOpen;
    private string modalText;
    private string modalTitle;

    protected override async void OnParametersSet()
    {
        await LoadEmployees();
    }

    private async Task LoadEmployees()
    {
        employees = new List<Employee>();
        employees = await Http.GetFromJsonAsync<List<Employee>>($"employees?divisionId={AppData.CurrentDivision.Id}");
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadEmployees();
    }

    private void EmployeeChangeButton_OnClick(Employee employee)
    {
        StateMachine.SetChangeState();
        AppData.CurrentEmployee = employee;
        NavigationManager.NavigateTo("employeeInfo");
    }

    private async Task Modal_OnClose(bool success)
    {
        modalOpen = false;
        if (StateMachine.CurrentState != StateMachine.State.Delete)
        {
            return;
        }
        var employeeToDelete = AppData.CurrentEmployee;
        AppData.CurrentEmployee = null;

        if (!success)
        {
            return;
        }

        var response = await Http.DeleteAsync($"employees?id={employeeToDelete.Id}");

        if (!response.IsSuccessStatusCode)
        {
            StateMachine.SetIdleState();
            modalOpen = true;
            modalTitle = "Ошибка удаления";
            modalText = "Не удалось удалить сотрудника";
            return;
        }

        employees.Remove(employeeToDelete);
    }

    private void DeleteButton_OnClick(Employee employee)
    {
        AppData.CurrentEmployee = employee;
        modalTitle = "Подтверждение удаления";
        modalText = "Вы действительно хотите удалить сотрудника?";
        modalOpen = true;
        StateMachine.SetDeleteState();
    }

    private void EmployeeAddButton_OnClick()
    {
        StateMachine.SetAddState();
        AppData.CurrentEmployee = null;
        NavigationManager.NavigateTo("employeeInfo");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine StateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
