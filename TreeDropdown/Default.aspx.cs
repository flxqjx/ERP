using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindTreeddl();
            bindTreeddl1();
        }
    }

    private void bindTreeddl1()
    {
        TreeDropDownList2.ChearNode();//清空所有节点
        TreeNode node0 = new TreeNode();
        node0.Text = "所有sss";
        node0.Value = "0";
        //parentid.Value = "0";
        node0.Expanded = false;
        node0.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList2.AddTreeNode(ref node0);//增加根节点
        TreeDropDownList2.setvalue("所有sss", "0");

        TreeNode node = new TreeNode();
        node.Text = "汽车1";
        node.Value = "1";
        node.Expanded = false;
        node.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList2.AddChildNode(ref node0, ref node);//增加子节点

        TreeNode node1 = new TreeNode();
        node1.Text = "大众2";
        node1.Value = "2";
        node1.Expanded = false;
        node1.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList2.AddChildNode(ref node, ref node1);

        TreeNode node2 = new TreeNode();
        node2.Text = "轮船3";
        node2.Value = "3";
        node2.Expanded = false;
        node2.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList2.AddChildNode(ref node0, ref node2);
    }
    private void bindTreeddl()
    {
        TreeDropDownList1.ChearNode();//清空所有节点
        TreeNode node0 = new TreeNode();
        node0.Text = "所有类型";
        node0.Value = "0";
        //parentid.Value = "0";
        node0.Expanded = false;
        node0.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList1.AddTreeNode(ref node0);//增加根节点
        TreeDropDownList1.setvalue("所有类型", "0");

        TreeNode node = new TreeNode();
        node.Text = "汽车";
        node.Value ="1";
        node.Expanded = false;
        node.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList1.AddChildNode(ref node0, ref node);//增加子节点

        TreeNode node1 = new TreeNode();
        node1.Text = "大众";
        node1.Value = "2";
        node1.Expanded = false;
        node1.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList1.AddChildNode(ref node, ref node1);

        TreeNode node2 = new TreeNode();
        node2.Text = "轮船";
        node2.Value = "3";
        node2.Expanded = false;
        node2.SelectAction = TreeNodeSelectAction.SelectExpand;
        TreeDropDownList1.AddChildNode(ref node0, ref node2);
        /*string sql = "select PTypeID,TypeName from ProductType where parentID=0";
        DataSet ds = conn.getBinding(sql, "ss");
        foreach (DataRow dr in ds.Tables["ss"].Rows)
        {
            TreeNode node = new TreeNode();
            node.Text = dr["TypeName"].ToString();
            node.Value = dr["PTypeID"].ToString();
            node.Expanded = false;
            node.SelectAction = TreeNodeSelectAction.SelectExpand;
            TreeDropDownList1.AddTreeNode(ref node);
            CreateDataSource(dr["PTypeID"].ToString(), ref node);
        }*/
    }
    private void CreateDataSource(string Parentid, ref TreeNode Pnode)
    {
        /*string sqlstr = " select PTypeID,TypeName from ProductType where parentID=" + Parentid;

        DataSet ds = conn.getBinding(sqlstr, "tt");
        foreach (DataRow dr in ds.Tables["tt"].Rows)
        {
            TreeNode node = new TreeNode();
            node.Text = dr["TypeName"].ToString();
            node.Value = dr["PTypeID"].ToString();
            node.Expanded = false;
            node.SelectAction = TreeNodeSelectAction.SelectExpand;
            TreeDropDownList1.AddChildNode(ref Pnode, ref node);
            //				node.ImageUrl="../images/sciencesearch.gif";
            CreateDataSource(dr["PTypeID"].ToString(), ref node);

        }*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write(TreeDropDownList1.Text + "%%%%%" + TreeDropDownList1.Value);//页面回发后，可用TreeDropDownList1.Text/Value获取所选的treenode.Text/Value,
    }
}
