#pragma checksum "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80e0fec37a10690395a5b137a1ce4d94c5f8c715"
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
#line 2 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using TestTask.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/divisionInfo/{Id:int}")]
    public partial class DivisionInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"info__title\">???????????????????? ?? ??????????????????????????</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  GoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "??????????");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  _division

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.AddMarkupContent(11, "<label for=\"title\">????????????????????????</label>\r\n    ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "id", "title");
                __builder2.AddAttribute(14, "placeholder", "????????????????????????");
                __builder2.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                                          SaveDivision

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                               _division.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Title = __value, _division.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n");
                __builder2.OpenElement(20, "div");
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.AddMarkupContent(22, "<label for=\"date\">???????? ????????????????</label>\r\n    ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "date");
                __builder2.AddAttribute(25, "id", "date");
                __builder2.AddAttribute(26, "placeholder", "???????????????? ????????");
                __builder2.AddAttribute(27, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                                                           SaveDivision

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                           _division.CreateDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.CreateDate = __value, _division.CreateDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n");
                __builder2.OpenElement(32, "div");
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.AddMarkupContent(34, "<label for=\"parent\">???????????????????????? ??????????????????????????</label>\r\n    ");
                __builder2.OpenElement(35, "select");
                __builder2.AddAttribute(36, "id", "parent");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                _division.DivisionId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.DivisionId = __value, _division.DivisionId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(39, "\r\n");
#nullable restore
#line 26 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
         foreach (var divisionFromData in _divisions)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "            ");
                __builder2.OpenElement(41, "option");
                __builder2.AddAttribute(42, "value", 
#nullable restore
#line 28 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                            divisionFromData.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 28 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(43, divisionFromData.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n");
#nullable restore
#line 29 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(45, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
                __builder2.OpenElement(48, "div");
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.AddMarkupContent(50, "<label for=\"desc\">????????????????</label>\r\n    ");
                __builder2.OpenElement(51, "textarea");
                __builder2.AddAttribute(52, "id", "desc");
                __builder2.AddAttribute(53, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                (e) => { _division.Description = (string)e.Value; SaveDivision(); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                               _division.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Description = __value, _division.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
                __builder2.OpenElement(58, "div");
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.AddMarkupContent(62, "<label for=\"child\">?????????????????? ??????????????????????????</label>\r\n\r\n        ");
                __builder2.OpenElement(63, "select");
                __builder2.AddAttribute(64, "id", "child");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                  _subDivisionId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _subDivisionId = __value, _subDivisionId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 41 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var divisionFromData in _divisionsToAdd)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(68, "                ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", 
#nullable restore
#line 43 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                divisionFromData.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 43 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(71, divisionFromData.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n");
#nullable restore
#line 44 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(73, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                          AddSubDivision

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "class", "main--btn inverted");
                __builder2.AddMarkupContent(78, "???????????????? ??????????????????????????");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "subdiv__wrapper");
                __builder2.AddMarkupContent(83, "\r\n");
#nullable restore
#line 49 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
         foreach (var subDivision in _subDivisionsToAdd)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(84, "                ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "subdiv__item");
                __builder2.AddMarkupContent(87, "\r\n                    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.OpenElement(90, "span");
#nullable restore
#line 53 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(91, subDivision.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.OpenElement(93, "span");
#nullable restore
#line 54 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(94, subDivision.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n                    ");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                      () => DeleteSubDivision(subDivision)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "class", "main--btn inverted");
                __builder2.AddMarkupContent(100, "??????????????");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n");
#nullable restore
#line 59 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(103, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n");
                __builder2.OpenElement(106, "button");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  async () => await ApplyButton_OnClick()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "class", "main--btn inverted");
                __builder2.AddMarkupContent(109, "??????????????");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Division _division;
    private int? _subDivisionId;
    private List<Division> _divisions;
    private List<Division> _divisionsToAdd;
    private List<Division> _subDivisionsToAdd;
    private int _divisionId;

    public int DivisionId
    {
        get => _divisionId;
        set
        {
            _divisionId = value;
            _division.DivisionId = value;
            _storageService.SetItem("currentDivisionIdFromList", value);
            SaveDivision();
        }
    }

    protected override async Task OnParametersSetAsync()
    {
        _divisions = _divisionsToAdd = _subDivisionsToAdd = new List<Division>();
        await InitializeData();
        StateHasChanged();
    }

    private async Task InitializeData()
    {
        var divisionFromSession = GetDivisionFromSession();
        _subDivisionsToAdd = new List<Division>();
        if (Program.AppData.CurrentDivision == null && divisionFromSession != null)
        {
            _division = divisionFromSession;
        }
        else
        {
            _division = _stateMachine.CurrentState is StateMachine.State.Add
                ? new Division()
                : Program.AppData.CurrentDivision;
            _storageService.SetItem("currentDivision", _division);
        }

        _division.DivisionId ??= 0;

        await GetDivisions();

        if (_stateMachine.CurrentState == StateMachine.State.Add && divisionFromSession != null || _division.SubDivisions.Count > 0)
            FillSubDivisions();
    }

    private Division GetDivisionFromSession()
    {
        try
        {
            return _storageService.GetItem<Division>("currentDivision");
        }
        catch
        {
            return null;
        }
    }

    private async Task GetDivisions()
    {
        var divisionsList = (await Program.AppData.GetDivisionsAsync()).Where(d => d.Id != _division.Id).ToList();
        divisionsList.ForEach(d =>
        {
            d.ParentDivision = null;
            d.Employees = new HashSet<Employee>();
            d.SubDivisions = new HashSet<Division>();
        });
        _divisionsToAdd = divisionsList;
        divisionsList.Insert(0, new Division {Title = "??????"});
        _divisions = divisionsList.ToList();
    }

    /// <summary>
    /// ?????????????????? ???????????? ?????????????????? ??????????????????????????
    /// </summary>
    private void FillSubDivisions()
    {
        var subDivisions = _division.SubDivisions.ToList();

        foreach (var subDivision in subDivisions)
        {
            var subDivisionFromList = _divisionsToAdd.FirstOrDefault(d => d.Id == subDivision.Id);
            _divisions.Remove(subDivisionFromList);
            _divisionsToAdd.Remove(subDivisionFromList);
            _subDivisionsToAdd.Add(subDivisionFromList);
        }
    }

    /// <summary>
    /// ?????????????????? ?????????????????????????? ?? ???????????? ?????????????????? ??????????????????????????
    /// </summary>
    private void AddSubDivision()
    {
        var divisionToAdd = _divisionsToAdd.FirstOrDefault(d => d.Id == _subDivisionId);

        if (divisionToAdd is null)
            return;

        _divisions.Remove(divisionToAdd);
        _divisionsToAdd.Remove(divisionToAdd);
        _subDivisionsToAdd.Add(divisionToAdd);

        _division.SubDivisions = _subDivisionsToAdd;

        _subDivisionId = null;
        SaveDivision();
    }

    private async Task ApplyButton_OnClick()
    {
        if (string.IsNullOrWhiteSpace(_division.Title))
            return;

        if (_division.DivisionId == 0)
        {
            _division.DivisionId = null;
        }
        _division.ParentDivision = null;
        _division.Employees = new HashSet<Employee>();
        _division.SubDivisions = _subDivisionsToAdd;

        var response = _stateMachine.CurrentState is StateMachine.State.Change
            ? await PutDivisionAsync()
            : await PostDivisionAsync();

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine(await response.Content.ReadAsStringAsync());
            return;
        }

        await Program.AppData.InitializeBaseProperties();
        _eventAggregator.InvokeDivisionCollectionChanged();

        _navigationManager.NavigateTo(Program.LastPageUrl);
    }

    private async Task<HttpResponseMessage> PutDivisionAsync()
    {
        var response = await _http.PutAsJsonAsync("divisions", _division);
        return response;
    }

    private async Task<HttpResponseMessage> PostDivisionAsync()
    {
        var response = await _http.PostAsJsonAsync("divisions", _division);

        return response;
    }

    private void DeleteSubDivision(Division subDivision)
    {
        _subDivisionsToAdd.Remove(subDivision);
        _divisionsToAdd.Add(subDivision);

        _division.SubDivisions = _subDivisionsToAdd;
        _storageService.SetItem("currentDivision", _division);
    }

    private void SaveDivision()
    {
        _storageService.Clear();
        _storageService.SetItem("currentDivision", _division);
    }

    private void GoBack()
    {
        _navigationManager.NavigateTo(Program.LastPageUrl);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncSessionStorageService _storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventAggregator _eventAggregator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
    }
}
#pragma warning restore 1591
