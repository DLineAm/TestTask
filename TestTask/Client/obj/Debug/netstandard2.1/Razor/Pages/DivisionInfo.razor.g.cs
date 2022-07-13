#pragma checksum "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef15a2b0ce7eda93ba0ae833527bd98a6284c53"
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
            __builder.AddMarkupContent(0, "<h3 class=\"info__title\">Информация о подразделении</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  GoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "Назад");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<label for=\"title\">Наименование</label>\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "id", "title");
            __builder.AddAttribute(10, "placeholder", "Наименование");
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                                          SaveDivision

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                               _division.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Title = __value, _division.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.AddMarkupContent(18, "<label for=\"date\">Дата создания</label>\r\n    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "date");
            __builder.AddAttribute(21, "id", "date");
            __builder.AddAttribute(22, "placeholder", "Выберите дату");
            __builder.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                                                           SaveDivision

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                           _division.CreateDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.CreateDate = __value, _division.CreateDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.AddMarkupContent(30, "<label for=\"parent\">Родительское подразделение</label>\r\n    ");
            __builder.OpenElement(31, "select");
            __builder.AddAttribute(32, "id", "parent");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                               DivisionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DivisionId = __value, DivisionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 25 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
         foreach (var divisionFromData in _divisions)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 27 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                            divisionFromData.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 27 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(39, divisionFromData.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 28 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.AddMarkupContent(46, "<label for=\"desc\">Описание</label>\r\n    ");
            __builder.OpenElement(47, "textarea");
            __builder.AddAttribute(48, "id", "desc");
            __builder.AddAttribute(49, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                (e) => { _division.Description = (string)e.Value; SaveDivision(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                               _division.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Description = __value, _division.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenElement(54, "div");
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "div");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.AddMarkupContent(58, "<label for=\"child\">Вложенные подразделения</label>\r\n\r\n        ");
            __builder.OpenElement(59, "select");
            __builder.AddAttribute(60, "id", "child");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                  _subDivisionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _subDivisionId = __value, _subDivisionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 40 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var divisionFromData in _divisionsToAdd)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", 
#nullable restore
#line 42 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                divisionFromData.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 42 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(67, divisionFromData.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 43 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                          AddSubDivision

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "class", "main--btn inverted");
            __builder.AddMarkupContent(74, "Добавить подразделение");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "subdiv__wrapper");
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 48 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
         if (_subDivisionsToAdd != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var subDivision in _subDivisionsToAdd)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "subdiv__item");
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "div");
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "span");
#nullable restore
#line 54 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(87, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.OpenElement(89, "span");
#nullable restore
#line 55 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(90, subDivision.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n                    ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                      () => DeleteSubDivision(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "class", "main--btn inverted");
            __builder.AddMarkupContent(96, "Удалить");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 60 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  async () => await ApplyButton_OnClick()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "class", "main--btn inverted");
            __builder.AddMarkupContent(105, "Принять");
            __builder.CloseElement();
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
    private List<Division> _subDivisionsToAdd = new List<Division>();
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

    protected override void OnParametersSet()
    {
        _divisions = _divisionsToAdd = _subDivisionsToAdd = new List<Division>();
        InitializeData();
        StateHasChanged();
    }

    private void InitializeData()
    {
        var divisionFromSession = GetDivisionFromSession();
        if (Program.AppData.CurrentDivision == null && divisionFromSession != null)
        {
            _division = divisionFromSession;
            GetDivisions();
            FillSubDivisions();
        }
        else
        {
            _division = _stateMachine.CurrentState is StateMachine.State.Add
                ? new Division()
                : Program.AppData.CurrentDivision;
            _storageService.SetItem("currentDivision", _division);
        }

        if (Program.AppData.CurrentDivisionFromList == null)
        {
            DivisionId = _storageService.GetItem<int>("currentDivisionIdFromList");
        }
        else
        {
            DivisionId = Program.AppData.CurrentDivisionFromList.Id;
            _storageService.SetItem("currentDivisionIdFromList", DivisionId);
        }

        GetDivisions();

        if (_stateMachine.CurrentState is StateMachine.State.Change && _division.SubDivisions != null)
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

    private void GetDivisions()
    {
        var divisionsList = Program.AppData.Divisions.Where(d => d.Id != _division.Id).ToList();
        divisionsList.ForEach(d =>
        {
            d.ParentDivision = null;
            d.Employees = new HashSet<Employee>();
            d.SubDivisions = new HashSet<Division>();
        });
        _divisionsToAdd = divisionsList;
        divisionsList.Insert(0, new Division {Title = "Нет"});
        _divisions = divisionsList.ToList();
    }

    /// <summary>
    /// Заполняет список вложенных подразделений
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
    /// Добавляет подразделение в список вложенных подразделений
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

        await Program.AppData.RefreshBaseProperties();
        _eventAggregator.InvokeDivisionCollectionChanged();

        _navigationManager.NavigateTo("");

        //GetDivisions();
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
