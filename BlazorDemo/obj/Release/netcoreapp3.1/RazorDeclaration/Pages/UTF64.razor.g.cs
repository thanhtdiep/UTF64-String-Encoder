#pragma checksum "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\Pages\UTF64.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d393e5bfdfd3b367ed2ff9caa0b5575e475b3d1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\_Imports.razor"
using BlazorDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\Pages\UTF64.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\Pages\UTF64.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\Pages\UTF64.razor"
using BlazorDemo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Codec")]
    public partial class UTF64 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\n9607234\Desktop\String Decode in C#\BlazorDemoApp\BlazorDemo\Pages\UTF64.razor"
       
    private List<Codec> codecs;
    private DisplayCodec newCodec = new DisplayCodec();
    private bool encodeFlag;

    protected override async Task OnInitializedAsync()
    {
        codecs = await _db.GetCodecs();
    }

    private async Task InsertCodec()
    {
        if (encodeFlag)
        {
            // Encode string
            newCodec.DecodeString = CodecProcess.encode(newCodec.EncodeString);
            newCodec.Status = "Encoding";
        }
        else
        {
            // Encode string
            newCodec.EncodeString = CodecProcess.decode(newCodec.DecodeString);
            newCodec.Status = "Decoding";
        }

        // Insert new model to database
        Codec c = new Codec
        {
            EncodeString = newCodec.EncodeString,
            DecodeString = newCodec.DecodeString,
            Status = newCodec.Status
        };

        await _db.InsertCodec(c);

        codecs.Add(c);

        newCodec = new DisplayCodec();
    }

    private async Task EncodeString()
    {
        encodeFlag = true;
        await InsertCodec();
    }

    private async Task DecodeString()
    {
        encodeFlag = false;
        await InsertCodec();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorDemo.Data.Codec CodecProcess { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICodecData _db { get; set; }
    }
}
#pragma warning restore 1591