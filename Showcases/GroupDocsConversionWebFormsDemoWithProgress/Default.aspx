<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GroupDocsConversionWebFormsDemoWithProgress.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GroupDocs.Conversion Web Forms Demo with Progress</title>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>


    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="//jqueryui.com/jquery-wp-content/themes/jqueryui.com/style.css">
    <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap.min.css" type="text/css" />
    <script type="text/javascript">
        function showProgress(myval) {
            $("#progressbar").progressbar({ value: myval });
        }
        function hideProgress() {
            $("#progressbar").progressbar({ value: 0 });
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">

        <table width="100%" align="center">
            <tr>
                <td>
                    <div style="padding: 20px 20px 20px 20px;">
                        <div class="panel panel-default" style="width: 600px;">
                            <div class="panel-heading">
                                <h4>GroupDocs Conversion Demo</h4>
                            </div>
                            <div class="panel-body">
                                <div runat="server" class="alert alert-danger" id="labelFailed" visible="false">Conversion failed</div>
                                <div runat="server" class="alert alert-success" id="labelCompleted" visible="false">Conversion completed</div>
                                <table cellpadding="5">
                                    <tr>
                                        <td><strong>Input File:</strong></td>
                                        <td><span class="label label-default"><%=inputGUIDFile %></span></td>
                                    </tr>
                                    <tr>
                                        <td><strong>Output Type:</strong></td>
                                        <td>
                                            <asp:DropDownList Width="100%" CssClass="input" runat="server" ID="ddlOutputTypes"></asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:LinkButton title="Convert" runat="server" OnClientClick="showProgress(15);" ID="buttonConvert" OnClick="buttonConvert_Click" CssClass="btn btn-success">Convert & Download</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <div style="width: 100%;" id="progressbar"></div>

                                            <asp:Label ID="progressLabel" runat="server"></asp:Label>
                                            <div id="result"></div>
                                            <br />
                                            <asp:Label runat="server" ID="lbldisp" Text="Percentage Completed : " />
                                            <asp:Label runat="server" ID="lblStatus" />

                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
