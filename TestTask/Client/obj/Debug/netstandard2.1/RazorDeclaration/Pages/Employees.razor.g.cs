// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
