﻿<%@ Control Language="C#" Inherits="Orchard.Mvc.ViewUserControl<Orchard.Packaging.ViewModels.PackagingHarvestViewModel>" %>
<p>
    <%:Html.ActionLink(T("Browse Repository Packages").ToString(), "Index") %>
    &bull;
    <%:Html.ActionLink(T("Harvest Local Packages").ToString(), "Harvest") %>
    &bull;
    <%:Html.ActionLink(T("Edit Repository Sources").ToString(), "Sources") %>
</p>
