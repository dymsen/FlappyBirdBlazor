#pragma checksum "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e2aa39f1f57995c1886b385f54e663f4246903d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/game")]
    public partial class GameContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Programmieren\FlappyBirdBlazor\FlappyBirdDemo\FlappyBirdDemo.Web\Components\GameContainer.razor"
       
    GameManager _gameManager;


    protected override void OnInitialized()
    {
        _gameManager = new GameManager();
        _gameManager.MainLoopCompleted += (o, e) => StateHasChanged();
    }

    void HandleKeyUp(KeyboardEventArgs e)
    {
        if(e.Key == " ")
        {
            _gameManager.Jump();
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
