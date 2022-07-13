#pragma checksum "G:\TestTask\TestTask\Client\Pages\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ac95b6f0628d3d778f5d30ee9f39b1874e45bf"
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
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
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
#line 11 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder.AddContent(3, _title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
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
#line 16 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
 if (_employees is null || _currentDivision is null || _divisions is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<span>Загрузка</span>\r\n");
#nullable restore
#line 19 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "subdiv__wrapper");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 23 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
         foreach (var employee in _employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "subdiv__item");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "style", "font-size: 20px; font-weight: 700");
#nullable restore
#line 26 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder.AddContent(22, employee.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "img");
            __builder.AddAttribute(27, "style", "width: 20px; cursor: pointer");
            __builder.AddAttribute(28, "src", "css/edit--green.svg");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                                                                  () => EmployeeChangeButton_OnClick(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "img");
            __builder.AddAttribute(33, "style", "width: 20px; cursor: pointer");
            __builder.AddAttribute(34, "src", "css/delete--green.svg");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                                                                    () => DeleteButton_OnClick(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 32 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.OpenElement(41, "div");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, "<h3>Работники во вложенных подразделениях</h3>\r\n\r\n");
#nullable restore
#line 36 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
             if (_currentDivision.SubDivisions != null && _currentDivision.SubDivisions.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder.AddContent(44, GetEmployeesInSubDivisions((__builder2) => {
    __builder2.AddMarkupContent(45, "<div></div>");
}
));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                           
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                ");
            __builder.AddMarkupContent(47, "<p>Работников нет</p>\r\n");
#nullable restore
#line 43 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 47 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 49 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
 if (_modalOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "    ");
            __builder.OpenComponent<TestTask.Client.Shared.Modal>(53);
            __builder.AddAttribute(54, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                   _modalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
              _modalText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 53 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                Modal_OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 54 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
       
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


    protected override async void OnParametersSet()
    {
        await LoadEmployees();
    }

    private async Task LoadEmployees()
    {
        _existEmployees = new List<Employee>();

        _currentDivision = Program.AppData.CurrentDivision 
                           ?? (Program.AppData.CurrentDivision = Program.AppData.Divisions.FirstOrDefault(d => d.Id == Id));
        Program.AppData.CurrentDivisionFromList = _currentDivision;
        _divisions = Program.AppData.Divisions;
        _title = _currentDivision?.Title;
        if (_currentDivision.SubDivisions != null && _currentDivision.SubDivisions.Count > 0)
        {

            foreach (var subDivision in _currentDivision.SubDivisions)
            {
                FillEmployeesListFromSubDivisions(subDivision);
            }
        }
        _employees = new List<Employee>();
        _employees = await _http.GetFromJsonAsync<List<Employee>>($"employees?divisionId={_currentDivision.Id}");
        StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadEmployees();
    }

    private async Task EmployeeChangeButton_OnClick(Employee employee)
    {
        _stateMachine.SetChangeState();
        Program.AppData.CurrentEmployee = employee;
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

        await _storageService.SetItemAsync<Employee>("currentEmployee", null);

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
            return;
        }

        _employees.Remove(employeeToDelete);
    }

    private async Task DeleteButton_OnClick(Employee employee)
    {
        //Program.AppData.CurrentEmployee = employee;
        await _storageService.SetItemAsync("currentEmployee", employee);
        _modalTitle = "Подтверждение удаления";
        _modalText = "Вы действительно хотите удалить сотрудника?";
        _modalOpen = true;
        _stateMachine.SetDeleteState();
    }

    private async Task EmployeeAddButton_OnClick()
    {
        _stateMachine.SetAddState();
        await _storageService.SetItemAsync<Employee>("currentEmployee", null);
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
            __builder2.OpenElement(58, "div");
            __builder2.AddAttribute(59, "class", "subdiv__item");
            __builder2.AddMarkupContent(60, "\r\n        ");
            __builder2.OpenElement(61, "span");
            __builder2.AddAttribute(62, "style", "font-size: 20px; font-weight: 700");
#nullable restore
#line 169 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder2.AddContent(63, employee.FullName);

#line default
#line hidden
#nullable disable
            __builder2.AddContent(64, " (");
#nullable restore
#line 169 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
__builder2.AddContent(65, _divisions.FirstOrDefault(d => d.Id == employee.DivisionId)?.Title);

#line default
#line hidden
#nullable disable
            __builder2.AddContent(66, ")");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(67, "\r\n        ");
            __builder2.OpenElement(68, "div");
            __builder2.AddMarkupContent(69, "\r\n            ");
            __builder2.OpenElement(70, "img");
            __builder2.AddAttribute(71, "style", "width: 20px; cursor: pointer");
            __builder2.AddAttribute(72, "src", "css/edit--green.svg");
            __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 171 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                                                          () => EmployeeChangeButton_OnClick(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(74, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(75, "\r\n            ");
            __builder2.OpenElement(76, "img");
            __builder2.AddAttribute(77, "style", "width: 20px; cursor: pointer");
            __builder2.AddAttribute(78, "src", "css/delete--green.svg");
            __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 172 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
                                                                                            () => DeleteButton_OnClick(employee)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(80, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(81, "\r\n        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(82, "\r\n    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(83, "\r\n");
        }
#nullable restore
#line 175 "G:\TestTask\TestTask\Client\Pages\Employees.razor"
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
        var employeesFromDivision = division.Employees.Where(e => _existEmployees.All(emp => emp.Id != e.Id)).ToList();

        _existEmployees.AddRange(employeesFromDivision);

        if (division.SubDivisions == null || division.SubDivisions.Count == 0) return;

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
