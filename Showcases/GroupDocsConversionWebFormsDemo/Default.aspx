<%@ Page Title=":: GroupDocs Conversion WebForms Demo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GroupDocsConversionWebFormsDemo._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div style="padding: 20px 20px 20px 20px">
        <div class="panel panel-default" style="width: 90%;">
            <div class="panel-heading"><b>GroupDocs Conversion WebForms Demo</b></div>
            <div class="panel-body">
                <span class="label label-default">
                    <asp:Label runat="server" ID="Label1"></asp:Label></span><br />
                .
            <div class="input-group">
                <asp:Button runat="server" Text="Convert to JPG" ID="buttonConvertJpg" OnCommand="ConvertCommand" CommandArgument="jpg" CssClass="btn btn-default" />
                <asp:Button runat="server" Text="Convert to PDF" ID="buttonConvertPdf" OnCommand="ConvertCommand" CommandArgument="pdf" CssClass="btn btn-danger" />
                <asp:Button runat="server" Text="Convert to PNG" ID="buttonConvertpng" OnCommand="ConvertCommand" CommandArgument="png" CssClass="btn btn-default" />
                <asp:Button runat="server" Text="Convert to Excel" ID="buttonConvertxlsx" OnCommand="ConvertCommand" CommandArgument="xlsx" CssClass="btn btn-success" />
                <asp:Button runat="server" Text="Convert to Slides" ID="buttonConvertSlides" OnCommand="ConvertCommand" CommandArgument="pptx" CssClass="btn btn-warning" />
                <asp:Button runat="server" Text="Convert to HTML" ID="buttonConvertHTML" OnCommand="ConvertCommand" CommandArgument="html" CssClass="btn btn-danger" />
            </div>
            </div>
        </div>
    </div>
</asp:Content>
