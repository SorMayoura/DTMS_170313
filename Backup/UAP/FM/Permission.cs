using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIS;


namespace UAP.FM
{
    public partial class Permission : Layout.Normal
    {
        private string UserID = "";
        public Permission()
        {
            InitializeComponent();
            initTreeview();
            initUser();
        }

        public Permission(string paramID)
        {
            InitializeComponent();
            initTreeview();
            UserID = paramID;
            tabControlRole.TabPages.RemoveAt(0);          
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void initUser() 
        {
            string query = @"SELECT    [UserID]
                                      ,[UserName]
                                      ,[Password]
                                      ,[ExpireDate]
                                      ,[Department]
                                      ,[Branch]
                                  FROM [T_User] WHERE Status='A'";
            DataTable tabUser = SqlHelper.ExecuteDataTable(query);
            dgvUser.DataSource = tabUser;
        }
 
        private void initTreeview()
        {
            DataTable tabControls = SqlHelper.ExecuteDataTable("Select * From T_Controls");
            AddKids(null, "ParentID IS NULL", "DisplayOrder", tabControls);
        }

        private void initPermissionUser(string UserID)
        {
            DataTable tabRoleDep = SqlHelper.ExecuteDataTable("Select * From T_UserPermission Where UserID='" + UserID + "' ");
            //Clear Nodes
            clearNode();
            foreach (DataRow rows in tabRoleDep.Rows)
            {
                CheckedParentNodesFromSQL(treeRoles.Nodes, rows["ControlName"].ToString(),int.Parse(rows["Permission"].ToString()));
                foreach (TreeNode childNote in treeRoles.Nodes)
                {
                    CheckChildNodeFromSQL(childNote, rows["ControlName"].ToString(), int.Parse(rows["Permission"].ToString()));
                }

            }

        }


        private void AddKids(string parentid, string filter, string sort, DataTable table)
        {
            DataRow[] foundRows = table.Select(filter, sort);
            if (foundRows.Length == 0)
                return;
            // Get TreeNode of parent using Find which looks in the name
            // property of each node. true itterates all children
            TreeNode[] parentNode = treeRoles.Nodes.Find(parentid, true);
            if (parentid != null)
                if (parentNode.Length == 0)
                    return;
            // Add each row to tree
            for (int i = 0; i <= foundRows.GetUpperBound(0); i++)
            {
                string controlName = foundRows[i]["ControlName"].ToString();
                string nodetype = foundRows[i]["ControlType"].ToString();
                string nodetext = foundRows[i]["ControlText"].ToString();
                string nodeid = foundRows[i]["CTID"].ToString();
                TreeNode node = new TreeNode();
                node.Tag = controlName;
                node.Text = nodetext;
                node.Name = nodeid; // This is critical as the Find method searches the Name property
                if (parentid == null)
                    treeRoles.Nodes.Add(node); // Top Level
                else
                    parentNode[0].Nodes.Add(node); // Add children under parent
                // Itterate into any nodes
                if (nodetype.ToLower() == "node")
                    AddKids(nodeid, "ParentID=" + nodeid, sort, table);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void t_DepartmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.t_DepartmentBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dSRoles);

        }

        private void FrmManageRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRoles.T_Department' table. You can move, or remove it, as needed.
            //this.t_DepartmentTableAdapter.Fill(this.dSRoles.T_Department);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckedParentNodes(treeRoles.Nodes);
            MessageBox.Show("Permission Updated Success!","Permission",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void SaveUserPermission(string controlID,int Permission)
        {
            object existRecord = SqlHelper.ExecuteScalar("Select COUNT(UserID) From T_UserPermission Where ControlName='" + controlID + "' AND UserID='" + UserID + "' And Status='A' ");
            if (Convert.ToInt32(existRecord) > 0)
            {
                SqlHelper.ExecuteNonQuery("Update T_UserPermission SET Permission="+ Permission +" WHERE ControlName='" + controlID + "' AND UserID='" + UserID + "' ");
            }
            else
            {
                SqlHelper.ExecuteNonQuery("Insert INTO T_UserPermission(ControlName,UserID,Permission)VALUES('" + controlID + "','" + UserID + "'," + Permission + ")");
            }
         
        }

        // Check Child If ParentChecked
        public void CheckedParentNodes(TreeNodeCollection nodes)
        {
            int Permission = 0;
            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                
                //edit
                if (aNode.Checked)
                {
                    Permission = 1;
                }
                else 
                {
                    Permission = 0;
                }
                    // MessageBox.Show(aNode.Text);
                SaveUserPermission(aNode.Tag.ToString(), Permission);

                if (aNode.Nodes.Count != 0)
                    CheckedParentNodes(aNode.Nodes);
            }

     
      
        }

        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }


        /// <Check Node From SQL>
        public void CheckedParentNodesFromSQL(TreeNodeCollection nodes, string controlID, int Permission)
        {
            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (controlID.ToUpper() == aNode.Tag.ToString().ToUpper() && Permission == 1)
                {
                    aNode.Checked = true;
                }
                CheckedParentNodesFromSQL(aNode.Nodes, controlID, Permission);
                   
            }
        }

        // Updates all child tree nodes recursively.
        private void CheckChildNodeFromSQL(TreeNode treeNode, string ControlID,int Permission)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                if (ControlID.ToUpper() == node.Tag.ToString().ToUpper() && Permission==1)
                {
                    node.Checked = true;
                }
                this.CheckChildNodeFromSQL(node, ControlID,Permission);

            }
        }


       public void UnCheckedParentNodes(TreeNodeCollection nodes)
        {
            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                aNode.Checked = false;
                UnCheckedParentNodes(aNode.Nodes);

            }
        }

        // Updates all child tree nodes recursively.
        private void UnCheckChildNode(TreeNode treeNode)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = false;
                this.UnCheckChildNode(node);

            }
        }

        private void clearNode() 
        {
            UnCheckedParentNodes(treeRoles.Nodes);
            foreach (TreeNode node in treeRoles.Nodes)
            {
                UnCheckChildNode(node);
            }
        }

      

        /// </Check Node From SQL>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void treeRoles_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private void DgvUser_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowSelected in dgvUser.SelectedRows)
            {
                UserID = rowSelected.Cells["colUserID"].Value.ToString();
                initPermissionUser(UserID);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Users use = new Users(UserID,false);
            use.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUser)
            {
                btnEdit.Enabled = true;
            }
            else 
            {
                btnEdit.Enabled = false;
            }
        }

     
      


      



    }
}