// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestTask.Client.Shared
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
#line 1 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
using TestTask.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
       
    private Dictionary<int,Division> _divisions;
    private bool _collapseNavMenu = true;
    private string _modalTitle;
    private string _modalText;
    private bool _modalOpen;
    private bool _modalConfirmation;


    protected override async Task OnInitializedAsync()
    {
        _eventAggregator.DivisionCollectionChanged += async () =>
        {
            await GetDivisions();
            StateHasChanged();
        };

        await GetDivisions();
    }

    private async Task GetDivisions()
    {
        _divisions = (await Program.AppData.GetDivisionsAsync()).ToDictionary(d => d.Id, d => d);
        StateHasChanged();
    }

    private string GetDivisionHrefById(int divisionId)
    {
        return "employees/" + divisionId;
    }

    private RenderFragment GetList(Division division, RenderFragment markup)
    {
        var subDivisions = _divisions.Where(d => d.Value.DivisionId == division.Id)
            .ToDictionary(d => d.Key, d => d.Value);

        if (!subDivisions.Any())
        {
            return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, "<div></div>");
        }
#nullable restore
#line 85 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                               ;
        }

        foreach (var (id, subDivision) in subDivisions)
        {
            markup += 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(1, "li");
            __builder2.AddAttribute(2, "@key", "id");
            __builder2.AddMarkupContent(3, "\r\n                          ");
            __builder2.OpenElement(4, "div");
            __builder2.AddAttribute(5, "class", "pd1248");
            __builder2.AddMarkupContent(6, "\r\n                              ");
            __builder2.OpenElement(7, "a");
            __builder2.AddAttribute(8, "style", "cursor:" + " pointer;" + " color:" + " #fff;" + " " + (
#nullable restore
#line 92 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                        Program.CurrentDivisionId == id ? "text-decoration: underline;" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(9, "@onclick", "async () => await SetCurrentDivision(subDivision)");
#nullable restore
#line 92 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(10, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(11, @"
                              <img src=""css/edit.svg"" style=""cursor: pointer"" @onclick=""() => ChangeDivisionButton_OnClick(subDivision)"" alt>
                              <img src=""css/delete.svg"" style=""cursor: pointer"" @onclick=""() => DeleteDivisionButton_OnClick(subDivision)"" alt>
                          ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(12, "\r\n                      ");
            __builder2.CloseElement();
        }
#nullable restore
#line 96 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                           ;
            markup += GetList(subDivision, 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(13, "<div></div>");
        }
#nullable restore
#line 97 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                       );
        }
        return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(14, "ul");
#nullable restore
#line 99 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(15, markup);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(16, "\r\n");
        }
#nullable restore
#line 100 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
    ;
    }

    private void DivisionAddButton_OnClick()
    {
        _stateMachine.SetAddState();
        _navigationManager.NavigateTo("divisionInfo/0");
    }

    private void DeleteDivisionButton_OnClick(Division division)
    {
        Program.AppData.CurrentDivision = division;
        _modalTitle = "Подтверждение удаления";
        _modalText = "Вы действительно хотите удалить подразделение?";
        _modalOpen = true;
        _modalConfirmation = true;
        _stateMachine.SetDeleteState();
    }

    private async Task Modal_OnClose(bool success)
    {
        _modalOpen = false;
        if (_stateMachine.CurrentState != StateMachine.State.Delete)
            return;

        var divisionToDelete = Program.AppData.CurrentDivision;
        Program.AppData.CurrentDivision = null;

        if (!success)
            return;

        var response = await _http.DeleteAsync($"divisions?id={divisionToDelete.Id}");

        if (!response.IsSuccessStatusCode)
        {
            _stateMachine.SetIdleState();
            _modalOpen = true;
            _modalTitle = "Ошибка удаления";
            _modalText = "Не удалось удалить подразделение";
            _modalConfirmation = false;
            return;
        }

        await Program.AppData.InitializeBaseProperties();
        await GetDivisions();
        if (Program.LastPageUrl == "employees/" + divisionToDelete.Id)
            _navigationManager.NavigateTo("");
    }

    private void ChangeDivisionButton_OnClick(Division division)
    {
        _stateMachine.SetChangeState();

        if (Program.DivisionInfoPageOpened)
            Program.AppData.RecoverDivision();

        if (Program.EmployeeInfoPageOpened)
        {
            Program.AppData.RecoverEmployee();
            Program.EmployeeInfoPageOpened = false;
        }

        Program.AppData.CurrentDivision = division;
        Program.DivisionInfoPageOpened = true;

        _navigationManager.NavigateTo("divisionInfo/" + division.Id);
    }

    private async Task SetCurrentDivision(Division division)
    {
        _stateMachine.SetIdleState();
        _divisions = new Dictionary<int, Division>();
        _divisions = (await Program.AppData.GetDivisionsAsync()).ToDictionary(d => d.Id, d => d);
        var url = GetDivisionHrefById(division.Id);
        Program.LastPageUrl = url;

        if (Program.DivisionInfoPageOpened)
        {
            Program.AppData.RecoverDivision();
            Program.DivisionInfoPageOpened = false;
        }
        if (Program.EmployeeInfoPageOpened)
        {
            Program.AppData.RecoverEmployee();
            Program.EmployeeInfoPageOpened = false;
        }

        Program.AppData.CurrentDivision = division;
        Program.CurrentDivisionId = division.Id;

        if (Program.AfterEmployeeInfoPage)
        {
            _navigationManager.NavigateTo("Redirect");
            Program.AfterEmployeeInfoPage = false;
        }
        _navigationManager.NavigateTo(url);
    }

    private IEnumerable<KeyValuePair<int, Division>> GetMainDivisions()
    {
        return _divisions.Where(d => d.Value.DivisionId is null || d.Value.DivisionId == 0);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventAggregator _eventAggregator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591