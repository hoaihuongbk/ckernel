<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CTool.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>GCORE TOOL - Version 1.0.1</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap-theme.min.css">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        #ctool {
            margin-bottom: 30px;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="container-fluid" id="ctool">
            <div class="page-header">
                <h1>GCORE TOOL - Version 1.0.1</h1>
                <p class="lead">The website builder include database, service, app, template...</p>
            </div>
            <h3>Step 1: Database Builder</h3>
            <p>Enter database connection information and click step by step on Build-In View, Build-In Stored Procedure, Build DB Dictionary butons</p>

            <div class="form-inline">
                <asp:Label ID="Message" runat="server" Text=""></asp:Label>
                <div class="clearfix"></div>
                <div class="row-fluid">
                    <div class="form-group">
                        <asp:Label ID="Label1" CssClass="sr-only" runat="server" Text="Host"></asp:Label>
                        <asp:TextBox ID="inputHost" CssClass="form-control" placeholder="Host name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label4" CssClass="sr-only" runat="server" Text="Tên DB"></asp:Label>
                        <asp:TextBox ID="inputDBName" CssClass="form-control" placeholder="Database name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" CssClass="sr-only" runat="server" Text="Tên truy cập"></asp:Label>
                        <asp:TextBox ID="inputUser" CssClass="form-control" placeholder="Username" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label3" CssClass="sr-only" runat="server" Text="Mật khẩu"></asp:Label>
                        <asp:TextBox ID="inputPassword" CssClass="form-control" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label5" CssClass="sr-only" runat="server" Text="Namespace"></asp:Label>
                        <asp:TextBox ID="inputNamespace" CssClass="form-control" placeholder="Namespace" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row-fluid" style="margin-top: 15px;">
                    <asp:Button ID="btnLoadTblList" runat="server" CssClass="btn btn-primary" Text="Load List of table" OnClick="btnLoadTblList_Click" />
                    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Height="125px"  ></asp:ListBox>
                     
                    <asp:Button ID="btnLoadViewList" runat="server" CssClass="btn btn-warning" Text="Load List of view" OnClick="btnLoadViewList_Click" />
                    <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple" Height="125px"  ></asp:ListBox>
                    
                     <asp:Button ID="btnLoadSPList" runat="server" CssClass="btn btn-success" Text="Load List of SP" OnClick="btnLoadSPList_Click" />
                    <asp:ListBox ID="ListBox3" runat="server" SelectionMode="Multiple" Height="125px"  ></asp:ListBox>
                 </div>
                <div class="row-fluid" style="margin-top: 15px;">   
                    <asp:Button ID="btnBuildDBView" runat="server" CssClass="btn btn-primary" Text="Build-In View" OnClick="btnBuildDBView_Click" />
                    <asp:Button ID="btnBuildDBProcedure" runat="server" CssClass="btn btn-warning" Text="Build-In Stored Procedure" OnClick="btnBuildDBProcedure_Click" />
                    <asp:Button ID="btnBuildDBDict" runat="server" CssClass="btn btn-success" OnClick="btnBuildDBDict_Click" Text="Build DB Dictionary" />
                    <asp:Button ID="btnBuildDBModel" runat="server" CssClass="btn btn-success" Text="Build DB Model" OnClick="btnBuildDBModel_Click" />
                    <asp:Button ID="btnDropViewExtendProperty" runat="server" CssClass="btn btn-danger" Text="Drop Ckernel Extend Properties" OnClick="btnDropViewExtendProperty_Click" />
                    <asp:Button ID="btnBuildCRUD" runat="server" CssClass="btn btn-warning" Text="Build CRUD Store Procedure" OnClick="btnBuildCRUD_Click" />
                     <asp:Button ID="btnBuildJsModel" runat="server" CssClass="btn btn-success" Text="Build Js Model" OnClick="btnBuildJsModel_Click" />
                      <asp:Button ID="btnBuildRepo" runat="server" CssClass="btn btn-success" Text="Build DB Repository" OnClick="btnBuildRepo_Click" />
                    <%--<asp:Button ID="btnDropBuiltInView" runat="server" CssClass="btn btn-danger" Text="Drop Build-In View" OnClick="btnDropBuiltInView_Click" />--%>
                </div>
            </div>
            
            <h3>Step 2: Service Builder</h3>
            <p>Click on Build Service button for compile all database dictionary files to Dynamic-link library (<strong>DLL</strong>) and download it</p>
            <div class="row-fluid">
                <asp:Label ID="Message3" runat="server" Text=""></asp:Label><div class="clearfix"></div>
                 <asp:Button ID="btnBuildDBService" runat="server" CssClass="btn btn-danger" Text="Build DB Service" OnClick="btnBuildDBService_Click" />
                 <%--<asp:Button ID="btnBuildRepoService" runat="server" CssClass="btn btn-primary" Text="Build Repo Service" OnClick="btnBuildRepoService_Click" />--%>
                  <%--<asp:Button ID="btnBuildWebService" runat="server" CssClass="btn btn-default" Text="Build Web Service" OnClick="btnBuildWebService_Click" />--%>
            </div>
            <h4>How to use this service?</h4>
            <div class="row-fluid">
                <pre>
var service = new S(connectionString, isDebug, uid); //isDebug = true -> show error message in response object, uid is logged user id
var obj = new GCRequest
{
    _a = "fGetgc_App", //Action prefix f,p for get data; gc_App is table name
    _c = new Dictionary< <% Response.Write("string"); %> , <% Response.Write("object"); %>>
    {
        {"Id", appId}   //Condition: Id = appId
    },
    _f = "Id, Name"
};
var robj = service.P(obj); // {Result: 0 is failed, 1 is success, Records: List object array, TotalRecordCount: number of records, Message: error content }
                </pre>
                <p>
                    References: You can see all actions, conditions, fields definition in files <strong>D.cs, DE.cs, P.cs, PE.cs</strong> 
                </p>
            </div>
            <%-- <h4>Build web service?</h4>
            <p>
                If you want call service via webservice, you can click on Build Web Service button and then you can see file <strong>cWebService.asmx</strong> and <strong>cWebService.asmx.cs</strong> in <strong class="text-primary">ObjectBuilder</strong> folder.<br/>
                You can call webservice via Javascript like this
            </p>
            <div class="row-fluid">
                <pre>
var obj = {};
obj._a = "fGetgc_App";
obj._c = {
    Id: appId
};
obj._f = "Id, Name";

$.ajax({
    url: "http://localhost/service/cService.asmx/P",
    type: 'POST',
    contentType: "application/json; charset=utf-8",
    data: JSON.stringify({ obj: obj }),
    async: false,
    success: callBackFunc,
    error: function (m) {
        console.log(m);
    }
});
                </pre>
            </div>--%>
            <%--<div style="display: none;">
            <h3>Step 3: App Builder</h3>
            <p>Click on Build App button for buil all app files include templates, behind code and client scripts into <strong class="text-primary">AppBuilder</strong> folder</p>
             <div class="form-inline">
                <asp:Label ID="Message2" runat="server" Text=""></asp:Label>
                <div class="clearfix"></div>
                <div class="row-fluid">
                    <div class="form-group">
                        <asp:Label ID="Label6" CssClass="sr-only" runat="server" Text="AppId"></asp:Label>
                        <asp:TextBox ID="inputAppId" CssClass="form-control" placeholder="AppId" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnBuildApp" runat="server" CssClass="btn btn-primary" Text="Build App" OnClick="btnBuildApp_Click" />
                </div>
            </div>
            </div>--%>
        </div>
        <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
        <!-- Include all compiled plugins (below), or include individual files as needed -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>
        
        <link href="<%=ResolveUrl("/css/bootstrap-multiselect.css") %>" rel="stylesheet" type="text/css" />
<script src="<%=ResolveUrl("/js/bootstrap-multiselect.js") %>" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $('[id*=ListBox1]').multiselect({
            includeSelectAllOption: true,
            enableFiltering: true
        });
        $('[id*=ListBox2]').multiselect({
            includeSelectAllOption: true,
            enableFiltering: true
        });
        $('[id*=ListBox3]').multiselect({
            includeSelectAllOption: true,
            enableFiltering: true
        });
    });
</script>

    </form>
</body>
</html>
