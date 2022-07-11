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
#line 1 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
using TestTask.Client.Services;

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
#line 49 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
       
    private List<Division> _divisions;
    private bool _collapseNavMenu = true;
    private string _modalTitle;
    private string _modalText;
    private bool _modalOpen;

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
        _divisions = await _http.GetFromJsonAsync<List<Division>>("divisions");
        _appData.Divisions = _divisions;
    }

    private string GetDivisionHrefById(int divisionId)
    {
        return "employees/" + divisionId;
    }

    private RenderFragment GetList(Division division, RenderFragment markup)
    {
        foreach (var subDivision in division.SubDivisions)
        {
            markup += 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "li");
            __builder2.AddMarkupContent(1, "\r\n                          ");
            __builder2.OpenElement(2, "div");
            __builder2.AddAttribute(3, "class", "pd1248");
            __builder2.AddMarkupContent(4, "\r\n                              ");
            __builder2.OpenElement(5, "a");
            __builder2.AddAttribute(6, "href", 
#nullable restore
#line 83 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                        GetDivisionHrefById(subDivision.Id)

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(7, "style", "cursor: pointer");
            __builder2.AddAttribute(8, "@onclick", "() => SetCurrentDivision(subDivision)");
#nullable restore
#line 83 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(9, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(10, @"
                              <img src=""css/delete.svg"" style=""cursor: pointer"" @onclick=""() => DeleteDivisionButton_OnClick(subDivision)"" alt>
                              <img src=""css/edit.svg"" style=""cursor: pointer"" @onclick=""() => ChangeDivisionButton_OnClick(subDivision)"" alt>
                          ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(11, "\r\n                      ");
            __builder2.CloseElement();
        }
#nullable restore
#line 87 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                           ;
                          
                          if (subDivision.SubDivisions != null)
                              markup += GetList(subDivision, 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(12, "<div></div>");
        }
#nullable restore
#line 90 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                         );
        }
        return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(13, "ul");
#nullable restore
#line 92 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(14, markup);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
        }
#nullable restore
#line 92 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                ;
    }

    private void DivisionAddButton_OnClick()
    {
        _stateMachine.SetAddState();
        _navigationManager.NavigateTo("divisionInfo");
    }

    private void DeleteDivisionButton_OnClick(Division division)
    {
        _appData.CurrentDivision = division;
        _modalTitle = "Подтверждение удаления";
        _modalText = "Вы действительно хотите удалить подразделение?";
        _modalOpen = true;
        _stateMachine.SetDeleteState();
    }

    private async Task Modal_OnClose(bool success)
    {
        _modalOpen = false;
        if (_stateMachine.CurrentState != StateMachine.State.Delete)
            return;

        var divisionToDelete = _appData.CurrentDivision;
        _appData.CurrentDivision = null;

        if (!success)
            return;

        var response = await _http.DeleteAsync($"divisions?id={divisionToDelete.Id}");

        if (!response.IsSuccessStatusCode)
        {
            _stateMachine.SetIdleState();
            _modalOpen = true;
            _modalTitle = "Ошибка удаления";
            _modalText = "Не удалось удалить подразделение";
            return;
        }

        await GetDivisions();
    }

    private void ChangeDivisionButton_OnClick(Division division)
    {
        _stateMachine.SetChangeState();
        _appData.CurrentDivision = division;

        _navigationManager.NavigateTo("divisionInfo");
    }

    private void SetCurrentDivision(Division division)
    {
        _appData.CurrentDivision = division;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventAggregator _eventAggregator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData _appData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591
