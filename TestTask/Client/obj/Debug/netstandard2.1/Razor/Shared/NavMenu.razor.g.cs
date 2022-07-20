#pragma checksum "G:\TestTask\TestTask\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6470f79f6a506407b39e54b2ac23ee70c0efb6f5"
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
#nullable restore
#line 4 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
using Newtonsoft.Json;

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
#line 17 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
 if (_divisions is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<span style=\"color: white\">Загрузка</span>\r\n");
#nullable restore
#line 20 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 24 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 28 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
             foreach (var division in _divisions.Where(d => d.DivisionId is null))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "li");
            __builder.SetKey(
#nullable restore
#line 30 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                          division.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "style", "cursor:" + " pointer;" + " color:" + " #fff;" + "  " + (
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                   _currentDivisionId == division.Id ? "font-weight: 700" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                                                                           () => SetCurrentDivision(division)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder.AddContent(22, division.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", "css/edit.svg");
            __builder.AddAttribute(26, "style", "cursor: pointer");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                  () => ChangeDivisionButton_OnClick(division)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "src", "css/delete.svg");
            __builder.AddAttribute(32, "style", "cursor: pointer");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                    () => DeleteDivisionButton_OnClick(division)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                         if (division.SubDivisions != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder.AddContent(36, GetList(division, (__builder2) => {
    __builder2.AddMarkupContent(37, "<div></div>");
}
));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                              
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 39 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 42 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 44 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
 if (_modalOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.OpenComponent<TestTask.Client.Shared.Modal>(45);
            __builder.AddAttribute(46, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                   _modalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                  _modalText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                    Modal_OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 49 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
       
    private List<Division> _divisions;
    private bool _collapseNavMenu = true;
    private string _modalTitle;
    private string _modalText;
    private bool _modalOpen;
    private int _currentDivisionId;

    protected override void OnInitialized()
    {
        _eventAggregator.DivisionCollectionChanged += () =>
        {
            GetDivisions();
            StateHasChanged();
        };

        GetDivisions();
    }

    private void GetDivisions()
    {
        _divisions = Program.AppData.Divisions.ToList();
        StateHasChanged();
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
            __builder2.OpenElement(50, "li");
            __builder2.SetKey(
#nullable restore
#line 85 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                 subDivision.Id

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(51, "\r\n                          ");
            __builder2.OpenElement(52, "div");
            __builder2.AddAttribute(53, "class", "pd1248");
            __builder2.AddMarkupContent(54, "\r\n                              ");
            __builder2.OpenElement(55, "a");
            __builder2.AddAttribute(56, "style", "cursor:" + " pointer;" + " color:" + " #fff;" + "  " + (
#nullable restore
#line 87 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                         _currentDivisionId == subDivision.Id ? "font-weight: 700" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                                                                                    () => SetCurrentDivision(subDivision)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 87 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(58, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(59, "\r\n                              ");
            __builder2.OpenElement(60, "img");
            __builder2.AddAttribute(61, "src", "css/edit.svg");
            __builder2.AddAttribute(62, "style", "cursor: pointer");
            __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                        () => ChangeDivisionButton_OnClick(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(64, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(65, "\r\n                              ");
            __builder2.OpenElement(66, "img");
            __builder2.AddAttribute(67, "src", "css/delete.svg");
            __builder2.AddAttribute(68, "style", "cursor: pointer");
            __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                          () => DeleteDivisionButton_OnClick(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(70, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(71, "\r\n                          ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(72, "\r\n                      ");
            __builder2.CloseElement();
        }
#nullable restore
#line 91 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                           ;
                          
                          if (subDivision.SubDivisions != null)
                              markup += GetList(subDivision, 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(73, "<div></div>");
        }
#nullable restore
#line 94 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                         );
        }
        return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(74, "ul");
#nullable restore
#line 96 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(75, markup);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
        }
#nullable restore
#line 96 "G:\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
            return;
        }

        await Program.AppData.RefreshBaseProperties();
        GetDivisions();
        if (Program.LastPageUrl == "employees/" + divisionToDelete.Id)
            _navigationManager.NavigateTo("");
    }

    private void ChangeDivisionButton_OnClick(Division division)
    {
        _stateMachine.SetChangeState();
        Program.AppData.CurrentDivision = division;

        _navigationManager.NavigateTo("divisionInfo/" + division.Id);
    }

    private void SetCurrentDivision(Division division)
    {
        var url = GetDivisionHrefById(division.Id);
        Program.LastPageUrl = url;

        Program.AppData.CurrentDivision = division;
        _currentDivisionId = division.Id;

        if (Program.AfterEmployeeInfoPage)
        {
            _navigationManager.NavigateTo("Redirect");
            Program.AfterEmployeeInfoPage = false;
        }
        _navigationManager.NavigateTo(url);
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
