#pragma checksum "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacf98b491d5321616a6610c6e22d4b7529328c1"
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
#line 2 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using TestTask.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using TestTask.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
using TestTask.Client.Utils;

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
            __builder.AddAttribute(2, "class", "main--btn inverted");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                             GoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "Назад");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                  _division

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label for=\"title\">Наименование</label>\r\n        ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "id", "title");
                __builder2.AddAttribute(15, "placeholder", "Наименование");
                __builder2.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                                              SaveDivision

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                   _division.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Title = __value, _division.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.AddMarkupContent(23, "<label for=\"date\">Дата создания</label>\r\n        ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "date");
                __builder2.AddAttribute(26, "id", "date");
                __builder2.AddAttribute(27, "placeholder", "Выберите дату");
                __builder2.AddAttribute(28, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                                                               SaveDivision

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                               _division.CreateDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.CreateDate = __value, _division.CreateDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.AddMarkupContent(35, "<label for=\"parent\">Родительское подразделение</label>\r\n        ");
                __builder2.OpenElement(36, "select");
                __builder2.AddAttribute(37, "id", "parent");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                    _division.DivisionId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.DivisionId = __value, _division.DivisionId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(40, "\r\n");
#nullable restore
#line 27 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var divisionFromData in _divisions)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, "                ");
                __builder2.OpenElement(42, "option");
                __builder2.AddAttribute(43, "value", 
#nullable restore
#line 29 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                divisionFromData.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 29 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(44, divisionFromData.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n");
#nullable restore
#line 30 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(46, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.AddMarkupContent(51, "<label for=\"desc\">Описание</label>\r\n        ");
                __builder2.OpenElement(52, "textarea");
                __builder2.AddAttribute(53, "id", "desc");
                __builder2.AddAttribute(54, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                                                    (e) => { _division.Description = (string)e.Value; SaveDivision(); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                   _division.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _division.Description = __value, _division.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.AddMarkupContent(63, "<label for=\"child\">Вложенные подразделения</label>\r\n\r\n            ");
                __builder2.OpenElement(64, "select");
                __builder2.AddAttribute(65, "id", "child");
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                      _subDivisionId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _subDivisionId = __value, _subDivisionId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(68, "\r\n");
#nullable restore
#line 42 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                 foreach (var divisionFromData in _divisionsToAdd)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(69, "                    ");
                __builder2.OpenElement(70, "option");
                __builder2.AddAttribute(71, "value", 
#nullable restore
#line 44 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                    divisionFromData.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 44 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(72, divisionFromData.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n");
#nullable restore
#line 45 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(74, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenElement(76, "button");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                              AddSubDivision

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "class", "main--btn inverted");
                __builder2.AddMarkupContent(79, "Добавить подразделение");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "subdiv__wrapper");
                __builder2.AddMarkupContent(84, "\r\n");
#nullable restore
#line 50 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
             foreach (var subDivision in _subDivisionsToAdd)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                 if (subDivision != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(85, "                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "subdiv__item");
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddMarkupContent(90, "\r\n                            ");
                __builder2.OpenElement(91, "span");
#nullable restore
#line 56 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(92, subDivision.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenElement(94, "span");
#nullable restore
#line 57 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(95, subDivision.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n                        ");
                __builder2.OpenElement(98, "button");
                __builder2.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                                          () => DeleteSubDivision(subDivision)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "class", "main--btn inverted");
                __builder2.AddMarkupContent(101, "Удалить");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
#nullable restore
#line 62 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(104, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n");
#nullable restore
#line 67 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
     if (!string.IsNullOrWhiteSpace(_errorText))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
__builder2.AddContent(107, _errorText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                   
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(108, "\r\n    ");
                __builder2.OpenElement(109, "button");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
                      async () => await ApplyButton_OnClick()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "class", "main--btn inverted");
                __builder2.AddMarkupContent(112, "Принять");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\pocht\Desktop\TestTask\TestTask\Client\Pages\DivisionInfo.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Division _division;
    private Division _divisionBackup;
    private int? _subDivisionId;
    private List<Division> _divisions;
    private List<Division> _divisionsToAdd;
    private List<Division> _subDivisionsToAdd;
    private int _divisionId;
    private string _errorText;

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
        _errorText = string.Empty;
        _divisions = _divisionsToAdd = _subDivisionsToAdd = new List<Division>();
        await InitializeData();
        StateHasChanged();
    }

    private async Task InitializeData()
    {
        _division = null;
        var divisionFromSession = GetDivisionFromSession();
        //_subDivisionsToAdd = new List<Division>();
        if (!Program.AppData.SelectedDivision.CheckCopied() && divisionFromSession != null)
        {
            _division = divisionFromSession;
        }
        else
        {
            _division = _stateMachine.CurrentState is StateMachine.State.Add
                ? new Division { DivisionId = Program.AppData.SelectedDivisionFromList?.Id ?? 0 }
                : Program.AppData.SelectedDivision;
            SaveDivision();
        }

        _divisionBackup = new Division(_division);

        await GetDivisions();

        if (_stateMachine.CurrentState == StateMachine.State.Add && divisionFromSession != null
            || _division.SubDivisions.Count > 0)
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
        divisionsList.Insert(0, new Division { Title = "Нет", DivisionId = -1 });
        _divisionsToAdd = divisionsList.Where(d => d.DivisionId != null && d.DivisionId != 0).ToList();
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
            var subDivisionFromList = _divisionsToAdd.Where(d => d.Id != _division.DivisionId).FirstOrDefault(d => d.Id == subDivision.Id);
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

        _division.SubDivisions.Add(divisionToAdd);

        if (_division.DivisionId == _subDivisionId)
            _division.DivisionId = 0;

        _subDivisionId = null;
        SaveDivision();
    }

    private async Task ApplyButton_OnClick()
    {
        _errorText = string.Empty;

        if (string.IsNullOrWhiteSpace(_division.Title))
        {
            _errorText = "Наименование должно быть заполнено!";
            return;
        }

        var childrenDivision = _divisions.FirstOrDefault(d => d.Id == _division.DivisionId);

        if (childrenDivision != null 
            && (_divisionBackup.DivisionId is 0 || _divisionBackup.DivisionId is null) 
            && childrenDivision.HasParent(_division))
        {
            _errorText = @"Попытка изменить поле корневого подразделения ""Родительское подразделение"" на одно из вложенных подразделений";
            return;
        }

        _subDivisionsToAdd = _subDivisionsToAdd.Where(d => d != null).ToList();

        _division.SubDivisions = _subDivisionsToAdd;

        var divisions = new List<Division> { _division};
        if (_division.DivisionId != 0)
        {
            var parentDivision = _divisions.FirstOrDefault(d => d.Id == _division.DivisionId);
            if (parentDivision != null)
                divisions.Add(parentDivision);
        }

        var subdivisions = _division.SubDivisions.Select(d =>
        {
            var division = new Division(d)
                {
                    DivisionId = _division.Id
                };

            return division;
        });

        divisions.AddRange(subdivisions);

        if (TreeHelper.IsLoop(divisions))
        {
            _errorText = @"Попытка создать цикл из родительского подразделения и вложенных подразделений";
            return;
        }

        if (_division.DivisionId == 0)
            _division.DivisionId = null;

        _division.ParentDivision = null;

        Debug.WriteLine(_subDivisionsToAdd.Count);

        if ( _division.DivisionId != null && _subDivisionsToAdd.Any(d => d.Id == _division.DivisionId))
            _division.DivisionId = _divisionsToAdd.FirstOrDefault(d => d.Id > _division.DivisionId)?.Id;

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
        _stateMachine.SetState(StateMachine.State.Idle);
        _navigationManager.NavigateTo(Program.LastPageUrl);
        _storageService.Clear();
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
