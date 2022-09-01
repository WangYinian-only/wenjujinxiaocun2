using CHEXC.GoodMenhod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHEXC
{
    public partial class frmJhTable : Form
    {
        DB db;
        public frmJhTable()
        {
            InitializeComponent();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)//剔除根节点，点击根结点是没有任何动作的！
            {
                string table_name = e.Node.Text;

                listView1.Clear();
                //查表的信息
                DataTable table_info = db.getBySql("select name from tb_JhGoodsInfo where id=object_id('{0}')", new Object[] { table_name });
                for (int i = 0; i < table_info.Rows.Count; i++)
                {
                    for (int j = 0; j < table_info.Columns.Count; j++)
                    {//生成表头
                        listView1.Columns.Add(table_info.Rows[i][j] + "", listView1.Width / table_info.Rows.Count - 1, HorizontalAlignment.Left);
                    }
                }
                //查表的内容
                DataTable table = db.getBySql("select * from [{0}]", new Object[] { table_name });
                listView1.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();//生成每一列
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j <= 0)
                        {
                            listViewItem.Text = table.Rows[i][j] + "";
                        }
                        else
                        {
                            listViewItem.SubItems.Add(table.Rows[i][j] + "");
                        }
                    }
                    listView1.Items.Add(listViewItem);
                }
                listView1.EndUpdate();//结束数据处理，UI界面一次性绘制。  
            }


        }

        private void frmJhTable_Load(object sender, EventArgs e)
        {
            try
            {
                TreeNode root_node = new TreeNode();//建立节点
                root_node.Text = "Test数据库";
                treeView1.Nodes.Add(root_node);
                db = DB.getInstance();//初始化数据库查询单例DB.cs
                DataTable table_name = db.getBySql("SELECT name FROM sysobjects WHERE (xtype = 'U')");//查询test数据库表有多少张表
                for (int i = 0; i < table_name.Rows.Count; i++)//遍历查询出来的结果表（视图）
                {
                    for (int j = 0; j < table_name.Columns.Count; j++)
                    {
                        TreeNode treeNode = new TreeNode();
                        treeNode.Text = table_name.Rows[i][j] + "";
                        root_node.Nodes.Add(treeNode);//一一将查询结果，也就是表名添加到树节点
                    }
                }
            }
            catch
            {
                MessageBox.Show(this.Text, "数据库出错！");
                Environment.Exit(1);
            }

        }
    }

}
