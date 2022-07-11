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
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "G:\TestTask\TestTask\Client\Pages\EmployeeInfo.razor"
       
    private Employee employee;
    private IEnumerable<Division> divisions;
    private IEnumerable<Gender> genders;
    private bool isErrorHidden = true;
    private string errorText;
    private int divisionId;

    protected override void OnInitialized()
    {
        genders = AppData.Genders;
        var firstGender = genders.First();
        employee = StateMachine.CurrentState == StateMachine.State.Add 
            ? new Employee{Gender = firstGender, GenderId = firstGender.Id} 
            : AppData.CurrentEmployee;
        divisions = AppData.Divisions;
        divisionId = employee.DivisionId = StateMachine.CurrentState == StateMachine.State.Add 
            ? AppData.CurrentDivision.Id : employee.DivisionId;
    }

    private async Task Apply()
    {
        if (string.IsNullOrWhiteSpace(employee.FirstName) ||
            string.IsNullOrWhiteSpace(employee.LastName) ||
            string.IsNullOrWhiteSpace(employee.MiddleName))
        {
            errorText = "Все поля должны быть заполнены!";
            isErrorHidden = false;
            return;
        }

        isErrorHidden = true;

        employee.Division = null;
        employee.Gender = null;

        var response = StateMachine.CurrentState == StateMachine.State.Change
        ? await PutEmployeeAsync()
        : await PostEmployeeAsync();

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine(await response.Content.ReadAsStringAsync());
            return;
        }

        NavigationManager.NavigateTo($"employees/{divisionId}");
    }

    private async Task<HttpResponseMessage> PostEmployeeAsync()
    {
        var response = await Http.PostAsJsonAsync("employees", employee);
        return response;
    }

    private async Task<HttpResponseMessage> PutEmployeeAsync()
    {
        var json = JsonConvert.SerializeObject(employee);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await Http.PutAsync("employees/change", content);
        return response;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine StateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
    }
}
#pragma warning restore 1591
