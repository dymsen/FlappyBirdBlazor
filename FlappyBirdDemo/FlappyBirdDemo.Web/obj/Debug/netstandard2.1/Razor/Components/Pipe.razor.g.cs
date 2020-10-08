#pragma checksum "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Pipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27cf11195b249a9d6d82d1cbbf6ecf5a80ec3829"
// <auto-generated/>
#pragma warning disable 1591
namespace FlappyBirdDemo.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\_Imports.razor"
using FlappyBirdDemo.Web.Models;

#line default
#line hidden
#nullable disable
    public partial class Pipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "pipe");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 1 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Pipe.razor"
                          _topPipeCss

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "pipe");
            __builder.AddAttribute(6, "style", 
#nullable restore
#line 2 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Pipe.razor"
                          _bottompipeCss

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\Components\Pipe.razor"
       
    [Parameter] public PipeModel Model { get; set; }

    string _bottompipeCss => 
        $"left: {Model.DistanceFromLeft}px; bottom: {Model.DistanceFromBottom}px";

    string _topPipeCss => 
        $"left: {Model.DistanceFromLeft}px; bottom: {Model.DistanceFromBottom + 300 + Model.Gab}px";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
