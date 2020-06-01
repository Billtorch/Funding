#pragma checksum "C:\Users\billt\source\repos\codehub-learn\dotnet-skg-team3\Funder\FunderMVC\Views\Home\CreateProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b5680ccc6a75d82de632e9240ed72f234633801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateProject), @"mvc.1.0.view", @"/Views/Home/CreateProject.cshtml")]
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
#nullable restore
#line 1 "C:\Users\billt\source\repos\codehub-learn\dotnet-skg-team3\Funder\FunderMVC\Views\_ViewImports.cshtml"
using FunderMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\billt\source\repos\codehub-learn\dotnet-skg-team3\Funder\FunderMVC\Views\_ViewImports.cshtml"
using FunderMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b5680ccc6a75d82de632e9240ed72f234633801", @"/Views/Home/CreateProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70cb2f191db5282d8a36227180c9a92cc36d415f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f2346338013764", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title> Create a New Project</title>
    <link rel=""stylesheet"" href=""/lib/bootstrap/dist/css/bootstrap-flatly.css"" />
    <link rel=""stylesheet"" href=""/css/site.css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f2346338015028", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f2346338015382", async() => {
                    WriteLiteral(@"
    <fieldset>
        <legend>Create New Project</legend>
        <div class=""form-group row"">
        </div>
        <!-- Project Title -->
        <div class=""form-group row-cols-md-2"">
            <label for=""projectTitle"">Project Title</label>
            <input type=""text"" class=""form-control"" id=""projectTitle""");
                    BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 762, "\"", 781, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Enter a title for your Project"" />
            <small id=""projectTitleHelp"" class=""form-text text-muted"">Use a title which best represents  your project.</small>
        </div>
        <!-- Project Description -->
        <div
        <html lang=""en"">
        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f2346338016459", async() => {
                        WriteLiteral(@"
            <meta charset=""UTF-8"">
            <label for=""projectDescription"">Project Description</label>
            <title>Project Description</title>
            <script src=""https://code.jquery.com/jquery-3.5.1.min.js"" crossorigin=""anonymous""></script>
            <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>

            <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
            <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

            <link href=""https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-bs4.min.css"" r");
                        WriteLiteral("el=\"stylesheet\">\r\n            <script src=\"https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-bs4.min.js\"></script>\r\n        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f2346338018784", async() => {
                        WriteLiteral("\r\n        <div id=\"summernote\"></div>\r\n        <script>\r\n        $(\'#summernote\').summernote({\r\n        placeholder: \'Enter a description for your project\',\r\n        tabsize: 2,\r\n        height: 100\r\n        });\r\n        </script>\r\n        ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
        </html>
        </div>
        <!-- Project Category -->
        <div class=""form-group row-cols-md-4"">
            <label for=""projectCategory"">Select a Category</label>
            <select class=""form-control"" id=""projectCategory"">
                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f23463380110393", async() => {
                        WriteLiteral("Art");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f23463380111477", async() => {
                        WriteLiteral("Technology");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f23463380112568", async() => {
                        WriteLiteral("Games");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b5680ccc6a75d82de632e9240ed72f23463380113654", async() => {
                        WriteLiteral("Business");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
            </select>
        </div>
        <!-- Upload Photos -->
        <div class=""form-group"">
            <label for=""photoUpload"">Upload Photos</label>
            <input type=""file"" class=""form-control-file"" id=""photoUpload"" aria-describedby=""fileHelp"">
            <small id=""uploadPhotoHelp"" class=""form-text text-muted"">Upload up to 3 .png or .jpeg files.</small>
        </div>
        <!-- Low Tier Packages & Rewards -->
        <h5>Set Packages & Rewards:</h5>
        <div class=""form-group row-cols-md-4"">
            <label class=""col-form-label"" for=""inputDefault"">Low Tier Package:</label>
            <input type=""text"" class=""form-control"" placeholder=""Default input"" id=""inputDefault"">
            <div class=""input-group-append"">
                <span class=""input-group-text"">€</span>
            </div>
        </div>
        <div class=""form-group row-cols-md-4"">
            <label class=""col-form-label"" for=""inputDefault"">Low Tier Reward:</label>
            <input type=""");
                    WriteLiteral(@"text"" class=""form-control"" placeholder=""Default input"" id=""inputDefault"">
        </div>
        <!-- Mid Tier Packages & Rewards -->
        <div class=""form-group row-cols-md-4"">
            <label class=""col-form-label"" for=""inputDefault"">Default input</label>
            <input type=""text"" class=""form-control"" placeholder=""Default input"" id=""inputDefault"">
        </div>
        <div class=""form-group row-cols-md-4"">
            <label class=""col-form-label"" for=""inputDefault"">Default input</label>
            <input type=""text"" class=""form-control"" placeholder=""Default input"" id=""inputDefault"">
        </div>
        <!-- High Tier Packages & Rewards -->
        <div class=""form-group row-cols-md-4"">
            <label class=""col-form-label"" for=""inputDefault"">Default input</label>
            <input type=""text"" class=""form-control"" placeholder=""Default input"" id=""inputDefault"">
        </div>
        <div class=""form-group row-cols-md-4"">
            <label class=""col-form-label"" for=""i");
                    WriteLiteral(@"nputDefault"">Default input</label>
            <input type=""text"" class=""form-control"" placeholder=""Default input"" id=""inputDefault"">
        </div>
        <!-- Fund Goal -->
        <div class=""form-group row-cols-md-4"">
            <label class=""control-label"">Fund Goal:</label>
            <div class=""form-group"">
                <div class=""input-group mb-3"">
                    <input type=""text"" class=""form-control"" aria-label=""Amount"">
                    <div class=""input-group-append"">
                        <span class=""input-group-text"">€</span>
                    </div>
                </div>
            </div>
        </div>
        <!-- Buttons -->
        <button type=""button"" class=""btn btn-primary disabled"">Cancel</button>
        <button type=""button"" class=""btn btn-primary disabled"">Create</button>
    </fieldset>
");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        </main>
    </div>

    <footer class=""border-top footer text-muted"">
        <div class=""container"">
            &copy; 2020 - FunderMVC - <a href=""/Home/Privacy"">Privacy</a>
        </div>
    </footer>
    <script src=""/lib/jquery/dist/jquery.min.js""></script>
    <script src=""/lib/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""/js/site.js?v=4q1jwFhaPaZgr8WAUSrux6hAuh0XDg9kPS3xIVq36I0""></script>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
