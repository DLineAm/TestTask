#pragma checksum "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42898e11cc19137aba20a075ad44c1c09e1ff4ac"
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
            __builder.AddMarkupContent(0, "<div>\r\n    <a class=\"sidebar__title\" href>Подразделения</a>\r\n</div>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
 if (_divisions is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<span style=\"color: white\">Загрузка</span>\r\n");
#nullable restore
#line 19 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 23 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 27 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
             foreach (var (id, division) in GetMainDivisions())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "li");
            __builder.SetKey(
#nullable restore
#line 29 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                          id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "style", "cursor:" + " pointer;" + " color:" + " #fff;" + " " + (
#nullable restore
#line 30 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                  Program.CurrentDivisionId == id ? "text-decoration: underline;" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                                                                                   async () => await SetCurrentDivision(division)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 30 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 31 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 32 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                    () => DeleteDivisionButton_OnClick(division)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "alt", "");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
#nullable restore
#line 33 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder.AddContent(36, GetList(division, (__builder2) => {
    __builder2.AddMarkupContent(37, "<div></div>");
}
));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 35 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
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
#line 38 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 40 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
 if (_modalOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.OpenComponent<TestTask.Client.Shared.Modal>(45);
            __builder.AddAttribute(46, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                   _modalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                  _modalText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "IsConfirmation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                            _modalConfirmation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 45 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                    Modal_OnClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 46 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
       
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
        _divisions = new Dictionary<int, Division>();
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
            __builder2.AddMarkupContent(51, "<div></div>");
        }
#nullable restore
#line 87 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                               ;
        }

        foreach (var (id, subDivision) in subDivisions)
        {
            markup += 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(52, "li");
            __builder2.SetKey(
#nullable restore
#line 92 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                 id

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(53, "\r\n                          ");
            __builder2.OpenElement(54, "div");
            __builder2.AddAttribute(55, "class", "pd1248");
            __builder2.AddMarkupContent(56, "\r\n                              ");
            __builder2.OpenElement(57, "a");
            __builder2.AddAttribute(58, "style", "cursor:" + " pointer;" + " color:" + " #fff;" + " " + (
#nullable restore
#line 94 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                        Program.CurrentDivisionId == id ? "text-decoration: underline;" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                                                                                         async () => await SetCurrentDivision(subDivision)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 94 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(60, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(61, "\r\n                              ");
            __builder2.OpenElement(62, "img");
            __builder2.AddAttribute(63, "src", "css/edit.svg");
            __builder2.AddAttribute(64, "style", "cursor: pointer");
            __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                        () => ChangeDivisionButton_OnClick(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(66, "alt", "");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(67, "\r\n                              ");
            __builder2.OpenElement(68, "img");
            __builder2.AddAttribute(69, "src", "css/delete.svg");
            __builder2.AddAttribute(70, "style", "cursor: pointer");
            __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                                                          () => DeleteDivisionButton_OnClick(subDivision)

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
#line 98 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                           ;
            markup += GetList(subDivision, 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(75, "<div></div>");
        }
#nullable restore
#line 99 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
                                                       );
        }
        return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(76, "ul");
#nullable restore
#line 101 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
__builder2.AddContent(77, markup);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(78, "\r\n");
        }
#nullable restore
#line 102 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Shared\NavMenu.razor"
    ;
    }

    private void DivisionAddButton_OnClick()
    {
        _stateMachine.SetState(StateMachine.State.Add);
        _navigationManager.NavigateTo("divisionInfo/0");
    }

    private void DeleteDivisionButton_OnClick(Division division)
    {
        Program.AppData.SelectedDivision = division;
        _modalTitle = "Подтверждение удаления";
        _modalText = "Вы действительно хотите удалить подразделение?";
        _modalOpen = true;
        _modalConfirmation = true;
        _stateMachine.SetState(StateMachine.State.Delete);
    }

    private async Task Modal_OnClose(bool success)
    {
        _modalOpen = false;
        if (_stateMachine.CurrentState != StateMachine.State.Delete)
            return;

        var divisionToDelete = Program.AppData.SelectedDivision;
        Program.AppData.SelectedDivision = null;

        if (!success)
            return;

        var response = await _http.DeleteAsync($"divisions?id={divisionToDelete.Id}");

        if (!response.IsSuccessStatusCode)
        {
            _stateMachine.SetState(StateMachine.State.Idle);
            _modalOpen = true;
            _modalTitle = "Ошибка удаления";
            _modalText = "Не удалось удалить подразделение";
            _modalConfirmation = false;
            return;
        }

        await Program.AppData.InitializeBaseProperties();
        await GetDivisions();
        var divisionFromSession = _storageService.GetItem<Division>("currentDivision");
        if (divisionFromSession != null && divisionFromSession.Id == divisionToDelete.Id)
            _storageService.Clear();
        if (Program.LastPageUrl == "employees/" + divisionToDelete.Id)
            _navigationManager.NavigateTo("");
    }

    private void ChangeDivisionButton_OnClick(Division division)
    {
        _stateMachine.SetState(StateMachine.State.Change);

        Program.AppData.SelectedDivision = division;
        Program.DivisionInfoPageOpened = true;

        _navigationManager.NavigateTo("divisionInfo/" + division.Id);
    }

    private async Task SetCurrentDivision(Division division)
    {
        _stateMachine.SetState(StateMachine.State.Idle);
        _divisions = new Dictionary<int, Division>();
        _divisions = (await Program.AppData.GetDivisionsAsync()).ToDictionary(d => d.Id, d => d);
        var url = GetDivisionHrefById(division.Id);
        Program.LastPageUrl = url;

        Program.AppData.SelectedDivision = division;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncSessionStorageService _storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventAggregator _eventAggregator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
    }
}
#pragma warning restore 1591
