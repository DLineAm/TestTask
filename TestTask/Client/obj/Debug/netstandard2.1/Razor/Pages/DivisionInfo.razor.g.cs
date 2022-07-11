#pragma checksum "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e55b79ea2688374231f37d398287ff4f5744317"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/divisionInfo")]
    public partial class DivisionInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"info__title\">Информация о подразделении</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label for=\"title\">Наименование</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "title");
            __builder.AddAttribute(6, "placeholder", "Наименование");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                               _division.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Title = __value, _division.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<label for=\"date\">Дата создания</label>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "date");
            __builder.AddAttribute(16, "id", "date");
            __builder.AddAttribute(17, "placeholder", "Выберите дату");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                           _division.CreateDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.CreateDate = __value, _division.CreateDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.AddMarkupContent(24, "<label for=\"parent\">Является подразделением</label>\r\n    ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "id", "parent");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                               _division.DivisionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.DivisionId = __value, _division.DivisionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 23 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
         foreach (var divisionFromData in _divisions)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 25 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                            divisionFromData.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 25 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(33, divisionFromData.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 26 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.AddMarkupContent(40, "<label for=\"desc\">Описание</label>\r\n    ");
            __builder.OpenElement(41, "textarea");
            __builder.AddAttribute(42, "id", "desc");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                               _division.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Description = __value, _division.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<label for=\"child\">Вложенные подразделения</label>\r\n        \r\n        ");
            __builder.OpenElement(52, "select");
            __builder.AddAttribute(53, "id", "child");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                  _subDivisionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _subDivisionId = __value, _subDivisionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 38 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var divisionFromData in _divisionsToAdd)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", 
#nullable restore
#line 40 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                divisionFromData.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 40 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(60, divisionFromData.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 41 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                          AddSubDivision

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "main--btn inverted");
            __builder.AddMarkupContent(67, "Добавить подразделение");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "subdiv__wrapper");
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 46 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
         if (_subDivisionsToAdd != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var subDivision in _subDivisionsToAdd)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "subdiv__item");
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "span");
#nullable restore
#line 52 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(80, subDivision.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "span");
#nullable restore
#line 53 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder.AddContent(83, subDivision.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    \r\n                    ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                      () => DeleteSubDivision(subDivision)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "class", "main--btn inverted");
            __builder.AddMarkupContent(89, "Удалить");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 58 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  async () => await ApplyButton_OnClick()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "class", "main--btn inverted");
            __builder.AddMarkupContent(98, "Принять");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "G:\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
       
    private Division _division;
    private int? _subDivisionId;
    private List<Division> _divisions;
    private List<Division> _divisionsToAdd;
    private readonly List<Division> _subDivisionsToAdd = new List<Division>();

    protected override void OnInitialized()
    {
        _division = _stateMachine.CurrentState is StateMachine.State.Add
            ? new Division()
            : _appData.CurrentDivision;

        var divisionsList = _appData.Divisions.Where(d => d.Id != _division.Id).ToList();
        divisionsList.ForEach(d =>
        {
            d.ParentDivision = null;
            d.Employees = new HashSet<Employee>();
            d.SubDivisions = new HashSet<Division>();
        });
        _divisionsToAdd = divisionsList;
        divisionsList.Insert(0, new Division { Title = "Нет" });
        _divisions = divisionsList;

        if (_stateMachine.CurrentState is StateMachine.State.Change && _division.SubDivisions != null)
            FillSubDivisions();
    }

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

    private void AddSubDivision()
    {
        var divisionToAdd = _divisionsToAdd.FirstOrDefault(d => d.Id == _subDivisionId);

        if (divisionToAdd is null)
            return;

        _divisions.Remove(divisionToAdd);
        _divisionsToAdd.Remove(divisionToAdd);
        _subDivisionsToAdd.Add(divisionToAdd);

        _subDivisionId = null;
    }

    private async Task ApplyButton_OnClick()
    {
        if (string.IsNullOrWhiteSpace(_division.Title))
            return;

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

        _eventAggregator.InvokeDivisionCollectionChanged();

        _navigationManager.NavigateTo("");
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
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventAggregator _eventAggregator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateMachine _stateMachine { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData _appData { get; set; }
    }
}
#pragma warning restore 1591
