#pragma checksum "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e59d3c9c0ee754c63b0fca44d770217be064557"
// <auto-generated/>
#pragma warning disable 1591
namespace KnowledgeManagerOnline.Components.Tiles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using KnowledgeManagerOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using KnowledgeManagerOnline.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
using KnowledgeManagerOnline.Models;

#line default
#line hidden
#nullable disable
    public partial class WeeklyRecap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikChart>(0);
            __builder.AddAttribute(1, "Width", "100%");
            __builder.AddAttribute(2, "Height", "100%");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartSeriesItems>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartSeries>(6);
                    __builder3.AddAttribute(7, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesType?>(
#nullable restore
#line 6 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                            ChartSeriesType.Line

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 7 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                            Podcasts

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                               nameof(PodcastViewModel.Downloads) 

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                       nameof(PodcastViewModel.Date) 

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesAggregate?>(
#nullable restore
#line 10 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                 ChartSeriesAggregate.Sum

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxes>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxis>(15);
                    __builder3.AddAttribute(16, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisType?>(
#nullable restore
#line 14 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                  ChartCategoryAxisType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "BaseUnit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisBaseUnit?>(
#nullable restore
#line 14 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                                                         ChartCategoryAxisBaseUnit.Fit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxisLabels>(19);
                        __builder4.AddAttribute(20, "Format", "{0:d MMM}");
                        __builder4.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxisLabelsRotation>(22);
                            __builder5.AddAttribute(23, "Angle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                                         LabelsRotation

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n            ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxisMajorGridLines>(25);
                        __builder4.AddAttribute(26, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 18 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                                      false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n            ");
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxisMajorTicks>(28);
                        __builder4.AddAttribute(29, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 19 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                                  false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartValueAxes>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartValueAxis>(33);
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartValueAxisLabels>(35);
                        __builder4.AddAttribute(36, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#nullable restore
#line 24 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                        4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(37, (__value) => {
#nullable restore
#line 4 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
                                                ChartRef = (Telerik.Blazor.Components.TelerikChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\steve\source\repos\KnowledgeManagerOnline\KnowledgeManagerOnline\Components\Tiles\WeeklyRecap.razor"
       
    [Parameter]
    public IEnumerable<PodcastViewModel> Podcasts { get; set; }

    TelerikChart ChartRef { get; set; }

    string LabelsRotation = "auto";

    public void Resize()
    {
        ChartRef.Refresh();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
