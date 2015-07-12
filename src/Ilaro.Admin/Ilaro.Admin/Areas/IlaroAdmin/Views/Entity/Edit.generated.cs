﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Ilaro.Admin.Models.Paging;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Entity/Edit.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Entity_Edit_cshtml : System.Web.Mvc.WebViewPage<EntityCreateOrEditModel>
    {
        public _Areas_IlaroAdmin_Views_Entity_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
  
    Layout = "~/Areas/IlaroAdmin/Views/Shared/_Layout.cshtml";
    ViewBag.Title = string.Format(IlaroAdminResources.Edit_Title, Model.Entity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
       Write(Html.ActionLink(IlaroAdminResources.Index_Title, "Index", "Group", new { area = "IlaroAdmin" }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 12 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Group, "Details", "Group", new { area = "IlaroAdmin", groupName = Model.Entity.Verbose.Group }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 13 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Plural, "Index", "Entities", new { area = "IlaroAdmin", entityName = Model.Entity.Name }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 14 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                      Write(string.Format(IlaroAdminResources.Edit_Title, Model.Entity.Name));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<h2>");

            
            #line 18 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
Write(Model.Entity.Verbose.Singular);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n");

            
            #line 20 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
 using (Html.BeginForm("Edit", "Entity", new { area = "IlaroAdmin" }, FormMethod.Post, new { @class = "form-horizontal" }))
{
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                 


    foreach (var key in Model.Entity.Key)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 29 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                             Write(key.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"col-md-6 control-value\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
           Write(key.Value.AsString);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 34 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
    }

    if (Model.PropertiesGroups.Count > 1)
    {
        foreach (var group in Model.PropertiesGroups)
        {

            
            #line default
            #line hidden
WriteLiteral("            <fieldset>\r\n                <legend>");

            
            #line 41 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                   Write(group.GroupName);

            
            #line default
            #line hidden
WriteLiteral(" <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn pull-right\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 1553), Tuple.Create("\"", 1664)
            
            #line 41 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                , Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(Html.Condition(group.IsCollapsed, () => "glyphicon glyphicon-plus", () => "glyphicon glyphicon-minus")
            
            #line default
            #line hidden
, 1561), false)
);

WriteLiteral("></i></button></legend>\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1710), Tuple.Create("\"", 1773)
, Tuple.Create(Tuple.Create("", 1718), Tuple.Create("fields", 1718), true)
            
            #line 42 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 1724), Tuple.Create<System.Object, System.Int32>(Html.Condition(group.IsCollapsed, () => "hide")
            
            #line default
            #line hidden
, 1725), false)
);

WriteLiteral(">\r\n");

            
            #line 43 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                     foreach (var property in group.Properties.Where(x => x.IsKey == false))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 46 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                       Write(Html.EditorFor(m => property, property.Template.Editor));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 47 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                             if (property.IsForeignKey)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2152), Tuple.Create("\"", 2230)
            
            #line 49 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2159), Tuple.Create<System.Object, System.Int32>(Url.Action("Create", new { entityName = property.ForeignEntity.Name })
            
            #line default
            #line hidden
, 2159), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"btn btn-primary create-foreign\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span></a>\r\n");

            
            #line 50 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n");

            
            #line 52 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </fieldset>\r\n");

            
            #line 55 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
        }
    }
    else if (Model.PropertiesGroups.Count == 1)
    {
        foreach (var property in Model.PropertiesGroups[0].Properties.Where(x => x.IsKey == false))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 62 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
           Write(Html.EditorFor(m => property, property.Template.Editor));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 63 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 63 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                 if (property.IsForeignKey)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2858), Tuple.Create("\"", 2936)
            
            #line 65 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2865), Tuple.Create<System.Object, System.Int32>(Url.Action("Create", new { entityName = property.ForeignEntity.Name })
            
            #line default
            #line hidden
, 2865), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"btn btn-primary create-foreign\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span></a>\r\n");

            
            #line 66 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 68 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
        }
    }

    
            
            #line default
            #line hidden
            
            #line 71 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
Write(Html.Hidden("EntityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 71 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                                 


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-action\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 75 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                                     Write(IlaroAdminResources.Save);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" name=\"ContinueEdit\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i> ");

            
            #line 76 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                                                                                                  Write(IlaroAdminResources.SaveAndContinueEdit);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" name=\"AddNext\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></i> ");

            
            #line 77 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                                                                                             Write(IlaroAdminResources.SaveAndAddNext);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3665), Tuple.Create("\"", 3765)
            
            #line 78 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3672), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Entities", new { area = "IlaroAdmin", entityName = Model.Entity.Name })
            
            #line default
            #line hidden
, 3672), false)
);

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 78 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                                                                                                                    Write(IlaroAdminResources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3835), Tuple.Create("\"", 3938)
            
            #line 79 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3842), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", new { entityName = Model.Entity.Name, key = Model.Entity.JoinedKeyValue })
            
            #line default
            #line hidden
, 3842), false)
);

WriteLiteral(" class=\"btn btn-danger pull-right\"");

WriteLiteral(">");

            
            #line 79 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
                                                                                                                                                    Write(IlaroAdminResources.Delete);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n");

            
            #line 82 "..\..\Areas\IlaroAdmin\Views\Entity\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"foreign-modal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"Create foreign entity\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" style=\"width:90%\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n                <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">Create foreign entity</h4>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
