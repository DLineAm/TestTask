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
#line 1 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using TestTask.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\_Imports.razor"
using TestTask.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
using TestTask.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
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
#line 57 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
       
    [Parameter]
    public int Id { get; set; }

    private string _title;
    private List<Employee> _employees;
    private bool _modalOpen;
    private string _modalText;
    private string _modalTitle;
    private List<Employee> _existEmployees;
    private Division _currentDivision;
    private IEnumerable<Division> _divisions;
    private bool _modalConfirmation;


    protected override async void OnParametersSet()
    {
        await LoadEmployees();
    }

    private async Task LoadEmployees()
    {
        _existEmployees = new List<Employee>();

        _currentDivision = Program.AppData.CurrentDivision 
                           ?? (Program.AppData.CurrentDivision = (await Program.AppData.GetDivisionsAsync()).FirstOrDefault(d => d.Id == Id));
        Program.AppData.CurrentDivisionFromList = _currentDivision;
        _divisions = await Program.AppData.GetDivisionsAsync();
        _title = _currentDivision?.Title;
        _employees = new List<Employee>();
        _employees = Program.AppData.Employees.Where(e => e.DivisionId != null && e.DivisionId == _currentDivision.Id).ToList();
        if (_currentDivision?.SubDivisions.Count > 0)
        {
            foreach (var subDivision in _currentDivision.SubDivisions)
            {
                FillEmployeesListFromSubDivisions(subDivision);
            }
        }
        StateHasChanged();
    }

    private async Task EmployeeChangeButton_OnClick(Employee employee)
    {
        _stateMachine.SetChangeState();
        Program.AppData.CurrentEmployee = employee;
        Program.EmployeeInfoPageOpened = true;
        await _storageService.SetItemAsync("employeeId", employee.Id);
        _navigationManager.NavigateTo("employeeInfo");
    }

    private async Task Modal_OnClose(bool success)
    {
        _modalOpen = false;
        if (_stateMachine.CurrentState != StateMachine.State.Delete)
        {
            return;
        }
        var employeeToDelete = Program.AppData.CurrentEmployee;
        Program.AppData.CurrentEmployee = null;

        if (!success)
        {
            return;
        }

        var response = await _http.DeleteAsync($"employees?id={employeeToDelete.Id}");

        if (!response.IsSuccessStatusCode)
        {
            _stateMachine.SetIdleState();
            _modalOpen = true;
            _modalTitle = "Ошибка удаления";
            _modalText = "Не удалось удалить сотрудника";
            _modalConfirmation = true;
            return;
        }

        Program.AppData.Employees.Remove(employeeToDelete);

        if (employeeToDelete.DivisionId != Id)
        {
            _existEmployees.Remove(employeeToDelete);
            return;
        }

        _employees.Remove(employeeToDelete);
    }

    private async Task DeleteButton_OnClick(Employee employee)
    {
        Program.AppData.CurrentEmployee = employee;
        await _storageService.SetItemAsync("currentEmployee", employee);
        _modalTitle = "Подтверждение удаления";
        _modalText = "Вы действительно хотите удалить сотрудника?";
        _modalOpen = true;
        _modalConfirmation = true;
        _stateMachine.SetDeleteState();
    }

    private async Task EmployeeAddButton_OnClick()
    {
        _stateMachine.SetAddState();
        await _storageService.SetItemAsync<Employee>("currentEmployee", null);
        Program.AppData.ClearEmployeeBackup();
        _navigationManager.NavigateTo("employeeInfo");
    }

    /// <summary>
    /// Генерирует разметку для каждого сотрудника в подразделениях
    /// </summary>
    /// <param name="fragment"></param>
    /// <returns></returns>
    private RenderFragment GetEmployeesInSubDivisions(RenderFragment fragment)
    {
        foreach (var employee in _existEmployees)
        {
            fragment +=
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "div");
            __builder2.AddAttribute(1, "class", "subdiv__item");
            __builder2.AddMarkupContent(2, "\r\n        ");
            __builder2.OpenElement(3, "span");
            __builder2.AddAttribute(4, "style", "font-size: 20px; font-weight: 700");
#nullable restore
#line 175 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
__builder2.AddContent(5, employee.FullName);

#line default
#line hidden
#nullable disable
            __builder2.AddContent(6, " (");
#nullable restore
#line 175 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
__builder2.AddContent(7, _divisions.FirstOrDefault(d => d.Id == employee.DivisionId)?.Title);

#line default
#line hidden
#nullable disable
            __builder2.AddContent(8, ")");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(9, "\r\n        ");
            __builder2.AddMarkupContent(10, @"<div>
            <img style=""width: 20px; cursor: pointer"" src=""css/edit--green.svg"" @onclick=""() => EmployeeChangeButton_OnClick(employee)"" alt>
            <img style=""width: 20px; cursor: pointer"" src=""css/delete--green.svg"" @onclick=""() => DeleteButton_OnClick(employee)"" alt>
        </div>
    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(11, "\r\n");
        }
#nullable restore
#line 181 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\Employees.razor"
    ;
        }

        return fragment;
    }

    /// <summary>
    /// Заполняет список сотрудников из вложенных подразделений
    /// </summary>
    /// <param name="division"></param>
    private void FillEmployeesListFromSubDivisions(Division division)
    {
        var employeesFromDivision = Program.AppData.Employees.Where(e => e.DivisionId == division.Id && _existEmployees.All(emp => emp.Id != e.Id)).ToList();

        _existEmployees.AddRange(employeesFromDivision);

        if (division.SubDivisions.Count == 0) return;

        foreach (var subDivision in division.SubDivisions.ToList())
        {
            FillEmployeesListFromSubDivisions(subDivision);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService _storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591
