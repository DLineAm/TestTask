#pragma checksum "G:\TestTask\TestTask\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2c0d28df05b3cf4bb4d128f33c622fbe865b569"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<div>\r\n    <a class=\"sidebar__title\" href>Подразделения</a>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 15 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
 if (_divisions is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<span style=\"color: white\">Загрузка</span>\r\n");
#nullable restore
#line 18 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                          DivisionAddButton_OnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "main--btn");
            __builder.AddMarkupContent(9, "Добавить подразделение");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "ul");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 26 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
             foreach (var division in _divisions.Where(d => d.DivisionId is null))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "li");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 29 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                  GetDivisionHrefById(division.Id)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "cursor: pointer");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                                      () => SetCurrentDivision(division)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 29 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder.AddContent(23, division.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "src", "css/delete.svg");
            __builder.AddAttribute(27, "style", "cursor: pointer");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                    () => DeleteDivisionButton_OnClick(division)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", "css/edit.svg");
            __builder.AddAttribute(33, "style", "cursor: pointer");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                  () => ChangeDivisionButton_OnClick(division)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 32 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                         if (division.SubDivisions != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder.AddContent(37, GetList(division, (__builder2) => {
    __builder2.AddMarkupContent(38, "<div></div>");
}
));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                              
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 37 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 40 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 42 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
 if (_modalOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.OpenComponent<TestTask.Client.Shared.Modal>(46);
            __builder.AddAttribute(47, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                   _modalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                  _modalText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 46 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                    Modal_OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 47 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
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
            __builder2.OpenElement(51, "li");
            __builder2.AddMarkupContent(52, "\r\n                          ");
            __builder2.OpenElement(53, "div");
            __builder2.AddAttribute(54, "class", "pd1248");
            __builder2.AddMarkupContent(55, "\r\n                              ");
            __builder2.OpenElement(56, "a");
            __builder2.AddAttribute(57, "href", 
#nullable restore
#line 83 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                        GetDivisionHrefById(subDivision.Id)

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(58, "style", "cursor: pointer");
            __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                                               () => SetCurrentDivision(subDivision)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 83 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(60, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(61, "\r\n                              ");
            __builder2.OpenElement(62, "img");
            __builder2.AddAttribute(63, "src", "css/delete.svg");
            __builder2.AddAttribute(64, "style", "cursor: pointer");
            __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                          () => DeleteDivisionButton_OnClick(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(66, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(67, "\r\n                              ");
            __builder2.OpenElement(68, "img");
            __builder2.AddAttribute(69, "src", "css/edit.svg");
            __builder2.AddAttribute(70, "style", "cursor: pointer");
            __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                        () => ChangeDivisionButton_OnClick(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(72, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(73, "\r\n                          ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(74, "\r\n                      ");
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
            __builder2.AddMarkupContent(75, "<div></div>");
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
            __builder2.OpenElement(76, "ul");
#nullable restore
#line 92 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(77, markup);

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
