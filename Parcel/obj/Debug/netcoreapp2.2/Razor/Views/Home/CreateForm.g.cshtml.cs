#pragma checksum "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Home/CreateForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28ff4d10af15a1b44187828fc4ed95ae975b9f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateForm), @"mvc.1.0.view", @"/Views/Home/CreateForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CreateForm.cshtml", typeof(AspNetCore.Views_Home_CreateForm))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28ff4d10af15a1b44187828fc4ed95ae975b9f9", @"/Views/Home/CreateForm.cshtml")]
    public class Views_Home_CreateForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 734, true);
            WriteLiteral(@"<form action=""/packages"" method=""post"">
    <h2>To calculate the shipping cost we will need the following information:</h2> 
  <label for=""height"">Add a new package height</label>
  <input required id=""height"" name=""height"" type=""number"">

  <label for=""width"">Add a new package width</label>
  <input required id=""width"" name=""width"" type=""number"">

  <label for=""weight"">Add a new package weight</label>
  <input required id=""weight"" name=""weight"" type=""number"">

  <label for=""to"">Add where your package is going</label>
  <input required id=""to"" name=""to"" type=""text"">

  <label for=""from"">Add where your package is from</label>
  <input required id=""from"" name=""from"" type=""text"">

  <button type=""submit"">Submit</button>
</form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
