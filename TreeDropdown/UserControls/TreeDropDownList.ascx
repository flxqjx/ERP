<%@ control language="C#" autoeventwireup="true" inherits="UserControls_TreeDropDownList, App_Web_treedropdownlist.ascx.6bb32623" %>
<div>
   <asp:TextBox ID="treetext" runat="server" CssClass="input1" Width="80%" ></asp:TextBox><input 
       id="treebtnddl" value="." onclick="openTree('<%=Treediv.ClientID %>','<%=treetext.ClientID %>')" type="button" class="btnCss" /><input type="hidden" id="treeid" runat="server" />
</div>
<div id="Treediv" class="Treediv" runat="server">
   <asp:TreeView ID="TreeView1" runat="server" Font-Size="11px" ForeColor="#0000C0" 
        ImageSet="BulletedList2" ShowExpandCollapse="False">
       <ParentNodeStyle Font-Bold="False" />
       <HoverNodeStyle Font-Underline="True" 
           ForeColor="#5555DD" />
       <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" 
           VerticalPadding="0px" ForeColor="#5555DD" />
       <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
           HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
     </asp:TreeView>
</div>

