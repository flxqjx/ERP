<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="UserControls/TreeDropDownList.ascx" tagname="TreeDropDownList" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <link href="UserControls/treeddl.css" type="text/css" rel="stylesheet" />
    <script src="UserControls/treeddl.js" type="text/javascript"></script>
    <script type="text/javascript">
     function GetTreeNodeValue(name,id,divname)//获取选中节点的text和value
     {
        //document.getElementById("parentid").value=id;
        //document.getElementById("name1").value=name;
        //document.getElementById("Button1").click();//若需要使用treenodeChange事件请隐藏该按钮，并在该按钮事件中写代码
        //alert(name);
        //alert(divname);
        if(divname=="TreeDropDownList1")//当在同一页面使用多个控件时需该值进行判断
        {
            document.getElementById("Button1").click(); 
        }
     }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style=" width:200px;">
        <uc1:TreeDropDownList ID="TreeDropDownList1" runat="server" /></div>    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    
    </div>
    <div style=" width:250px;"><uc1:TreeDropDownList ID="TreeDropDownList2" runat="server" /></div>
    </form>
</body>
</html>
