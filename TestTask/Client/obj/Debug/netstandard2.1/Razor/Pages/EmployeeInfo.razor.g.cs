#pragma checksum "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4b078054a04a2dffd37482c165feaf3fce166f"
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
#line 2 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
using TestTask.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeInfo")]
    public partial class EmployeeInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"info__title\">Информация о сотруднике</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label for=\"lastname\">Фамилия</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "lastname");
            __builder.AddAttribute(6, "placeholder", "Фамилия");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                                                             _employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.LastName = __value, _employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<label for=\"firstname\">Имя</label>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "id", "firstname");
            __builder.AddAttribute(16, "placeholder", "Имя");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                                                          _employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.FirstName = __value, _employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.AddMarkupContent(23, "<label for=\"middlename\">Отчество</label>\r\n    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "id", "middlename");
            __builder.AddAttribute(26, "placeholder", "Отчество");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                                                                _employee.MiddleName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.MiddleName = __value, _employee.MiddleName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.AddMarkupContent(33, "<label for=\"birth\">Дата рождения</label>\r\n    ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "id", "birth");
            __builder.AddAttribute(36, "type", "date");
            __builder.AddAttribute(37, "placeholder", "Выберите дату");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                                                                            _employee.DateOfBirth

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.DateOfBirth = __value, _employee.DateOfBirth, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenElement(42, "div");
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.AddMarkupContent(44, "<label for=\"gender\">Пол</label>\r\n    ");
            __builder.OpenElement(45, "select");
            __builder.AddAttribute(46, "id", "gender");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                               _employee.GenderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.GenderId = __value, _employee.GenderId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 32 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
         foreach (var gender in _genders)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", 
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                            gender.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
__builder.AddContent(53, gender.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 35 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "div");
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "checkbox");
            __builder.AddAttribute(62, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                                   _employee.HasDriverLicense

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.HasDriverLicense = __value, _employee.HasDriverLicense));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, " Есть водительские права \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.OpenElement(66, "div");
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.AddMarkupContent(68, "<label for=\"division\">Подразделение</label>\r\n    ");
            __builder.OpenElement(69, "select");
            __builder.AddAttribute(70, "id", "division");
            __builder.AddAttribute(71, "class", "custom-select-sm");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                                 _employee.DivisionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _employee.DivisionId = __value, _employee.DivisionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 45 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
         foreach (var division in _divisions)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "            ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", 
#nullable restore
#line 47 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                            division.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 47 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
__builder.AddContent(78, division.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 48 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "hidden", 
#nullable restore
#line 51 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
              _isErrorHidden

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "\r\n    ");
#nullable restore
#line 52 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
__builder.AddContent(86, _errorText);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n\r\n");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
                  async () => await Apply()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", "main--btn inverted");
            __builder.AddMarkupContent(92, "Применить");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
       
    private Employee _employee;
    private IEnumerable<Division> _divisions;
    private IEnumerable<Gender> _genders;
    private bool _isErrorHidden = true;
    private string _errorText;
    private int _divisionId;

    protected override void OnInitialized()
    {
        _genders = _appData.Genders;
        var firstGender = _genders.First();
        _employee = _stateMachine.CurrentState is StateMachine.State.Add 
            ? new Employee{Gender = firstGender, GenderId = firstGender.Id} 
            : _appData.CurrentEmployee;
        _divisions = _appData.Divisions;
        _divisionId = _appData.CurrentDivision.Id;
        _employee.DivisionId = _stateMachine.CurrentState is StateMachine.State.Add 
            ? _appData.CurrentDivision.Id : _appData.CurrentDivisionFromEmployee.Id;
    }

    private async Task Apply()
    {
        if (string.IsNullOrWhiteSpace(_employee.FirstName) ||
            string.IsNullOrWhiteSpace(_employee.LastName) ||
            string.IsNullOrWhiteSpace(_employee.MiddleName))
        {
            _errorText = "Все поля должны быть заполнены!";
            _isErrorHidden = false;
            return;
        }

        _isErrorHidden = true;

        _employee.Division = null;
        _employee.Gender = null;

        var response = _stateMachine.CurrentState is StateMachine.State.Change
        ? await PutEmployeeAsync()
        : await PostEmployeeAsync();

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine(await response.Content.ReadAsStringAsync());
            return;
        }

        _navigationManager.NavigateTo($"employees/{_divisionId}");
    }

    private async Task<HttpResponseMessage> PostEmployeeAsync()
    {
        var response = await _http.PostAsJsonAsync("employees", _employee);
        return response;
    }

    private async Task<HttpResponseMessage> PutEmployeeAsync()
    {
        var json = JsonConvert.SerializeObject(_employee);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _http.PutAsync("employees/change", content);
        return response;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData _appData { get; set; }
    }
}
#pragma warning restore 1591