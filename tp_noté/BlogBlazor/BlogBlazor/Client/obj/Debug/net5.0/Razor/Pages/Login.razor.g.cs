#pragma checksum "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a518e5b8079d9df590cd158d77619311d6019dc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlogBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Shared.Model.Author;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Shared.Model.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Shared.Model.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Login.razor"
using BlogBlazor.Client.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Login.razor"
                         HandleValidLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "id", "email");
                __builder2.AddAttribute(8, "placeholder", "Votre Email");
                __builder2.AddAttribute(9, "value", 
#nullable restore
#line 11 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Login.razor"
                                       _email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(10, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _email = __value, _email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "password");
                __builder2.AddAttribute(14, "placeholder", "Votre mot de passe");
                __builder2.AddAttribute(15, "value", 
#nullable restore
#line 12 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Login.razor"
                                          _password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(16, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _password = __value, _password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n    ");
                __builder2.AddMarkupContent(18, "<button type=\"submit\">Connexion</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Login.razor"
       
    private AuthorReadDTO author;
    private string _email;
    private string _password;

    protected async Task HandleValidLogin()
    {
        author = await _authenticationService.Login(_email);

        if (author != null)
        {
            _navigationManager.NavigateTo("/posts");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService _authenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
