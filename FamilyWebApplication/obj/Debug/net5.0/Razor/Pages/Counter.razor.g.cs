#pragma checksum "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d5dedd564d0d6943d9f0616484eda7bd192e296"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyWebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using FamilyWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\_Imports.razor"
using FamilyWebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
using FamilyWebApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Manage Family</h1>\n\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                  Family

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                     FormSubmittedFamiliy

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<label for=\"sname\">Street name:</label><br>\n    ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "text");
                __builder2.AddAttribute(8, "id", "sname");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                    Family.StreetName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Family.StreetName = __value, Family.StreetName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "<br>\n    ");
                __builder2.AddMarkupContent(12, "<label for=\"houseNo\">House number:</label><br>\n    ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "number");
                __builder2.AddAttribute(15, "id", "houseNo");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                      Family.HouseNumber

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Family.HouseNumber = __value, Family.HouseNumber, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "<br>\n    ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "id", "sname");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                    Family.StreetName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Family.StreetName = __value, Family.StreetName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "<br>\n    ");
                __builder2.AddMarkupContent(25, "<label for=\"lname\">Last name:</label><br>\n    ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "id", "lname");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                    Adult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.LastName = __value, Adult.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "<br>\n    ");
                __builder2.AddMarkupContent(32, "<label for=\"hcolor\">Hair color:</label><br>\n    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "id", "hcolor");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                    Adult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.HairColor = __value, Adult.HairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "<br>\n    ");
                __builder2.AddMarkupContent(39, "<label for=\"ecolor\">Eye color:</label><br>\n    ");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "type", "text");
                __builder2.AddAttribute(42, "id", "ecolor");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                    Adult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.EyeColor = __value, Adult.EyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "<br>\n    ");
                __builder2.AddMarkupContent(46, "<label for=\"age\">Age:</label><br>\n    ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "type", "number");
                __builder2.AddAttribute(49, "id", "age");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                      Adult.Age

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.Age = __value, Adult.Age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "<br>\n    ");
                __builder2.AddMarkupContent(53, "<label for=\"weight\">Weight(kg):</label><br>\n    ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "number");
                __builder2.AddAttribute(56, "id", "weight");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                      Adult.Weight

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.Weight = __value, Adult.Weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "<br>\n    ");
                __builder2.AddMarkupContent(60, "<label for=\"height\">Height(cm):</label><br>\n    ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "type", "number");
                __builder2.AddAttribute(63, "id", "height");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                      Adult.Height

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.Height = __value, Adult.Height, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "<br>\n    ");
                __builder2.AddMarkupContent(67, "<label for=\"sex\">Sex:</label><br>\n    ");
                __builder2.OpenElement(68, "input");
                __builder2.AddAttribute(69, "type", "text");
                __builder2.AddAttribute(70, "id", "sex");
                __builder2.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                                    Adult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Adult.Sex = __value, Adult.Sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "<br>\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Add New\"><br>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\n\n\n");
            __builder.OpenElement(75, "table");
            __builder.AddAttribute(76, "class", "table");
            __builder.AddMarkupContent(77, "<thead><tr><td>Id</td>\n        <td>First Name</td>\n        <td>Last Name</td>\n        <td>HairColor</td>\n        <td>EyeColor</td>\n        <td>Age</td>\n        <td>Weight</td>\n        <td>Height</td>\n        <td>Sex</td></tr></thead>\n    ");
            __builder.OpenElement(78, "tbody");
#nullable restore
#line 49 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
     foreach (var adult in Adults)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(79, "tr");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 52 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n            ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 53 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n            ");
            __builder.OpenElement(86, "td");
            __builder.AddContent(87, 
#nullable restore
#line 54 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n            ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 55 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n            ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 56 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n            ");
            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 57 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n            ");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 58 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n            ");
            __builder.OpenElement(101, "td");
            __builder.AddContent(102, 
#nullable restore
#line 59 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n            ");
            __builder.OpenElement(104, "td");
            __builder.AddContent(105, 
#nullable restore
#line 60 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
                 adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "E:\3RD SEMESTER\WebAppAssigment\WebApplication\FamilyWebApplication\Pages\Counter.razor"
       
    Adult Adult = new();
    Family Family = new();
    IList<Adult> Adults = AdultDataList.ReadData<Adult>();

    void ClearForm()
    {
        Adult.FirstName = null;
        Family.HouseNumber = 0;
        Family.StreetName = null;
        Adult.LastName = null;
        Adult.HairColor = null;
        Adult.EyeColor = null;
        Adult.Age = 0;
        Adult.Weight = 0;
        Adult.Height = 0;
        Adult.Sex = null;
    }

    private void FormSubmittedFamiliy()
    {
        _dataList.SaveFamilieChanges(Family);
        ClearForm();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdultDataList _dataList { get; set; }
    }
}
#pragma warning restore 1591
