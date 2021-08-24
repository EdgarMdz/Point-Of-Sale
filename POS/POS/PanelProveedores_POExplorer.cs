using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class PanelProveedores_POExplorer : Form
    {
        private readonly Proveedor supplier;
        public PanelProveedores_POExplorer(Proveedor supplier)
        {
            this.InitializeComponent();
            this.supplier = supplier;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.bunifuImageButton2.Visible = true;
            this.bunifuImageButton1.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.bunifuImageButton1.Visible = true;
            this.bunifuImageButton2.Visible = false;
        }

        private void bunifuGradientPanel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.bunifuImageButton1.Visible = false;
                this.bunifuImageButton2.Visible = true;
            }
            else
            {
                if (this.WindowState != FormWindowState.Maximized)
                    return;
                this.WindowState = FormWindowState.Normal;
                this.bunifuImageButton1.Visible = true;
                this.bunifuImageButton2.Visible = false;
            }
        }

        private void PanelProveedores_POExplorer_Load(object sender, EventArgs e)
        {
            List<int> intList = new List<int>();
            for (int index = 0; index < this.supplier.POList.Rows.Count; ++index)
            {
                DateTime dateTime = Convert.ToDateTime(this.supplier.POList.Rows[index]["Fecha de Compra"]);
                if (intList.IndexOf(dateTime.Year) == -1)
                    intList.Add(dateTime.Year);
            }
            foreach (int num in intList)
                this.treeView1.Nodes.Add(new TreeNode(num.ToString(), 1, 2));
            foreach (TreeNode node in this.treeView1.Nodes)
            {
                node.Nodes.Add(node.Text, "Enero", 0);
                node.Nodes.Add(node.Text, "Febrero", 0);
                node.Nodes.Add(node.Text, "Marzo", 0);
                node.Nodes.Add(node.Text, "Abril", 0);
                node.Nodes.Add(node.Text, "Mayo", 0);
                node.Nodes.Add(node.Text, "Junio", 0);
                node.Nodes.Add(node.Text, "Julio", 0);
                node.Nodes.Add(node.Text, "Agosto", 0);
                node.Nodes.Add(node.Text, "Septiembre", 0);
                node.Nodes.Add(node.Text, "Octubre", 0);
                node.Nodes.Add(node.Text, "Noviembre", 0);
                node.Nodes.Add(node.Text, "Diciembre", 0);
            }
            DataTable dataTable = this.supplier.POList.Copy();
            foreach (TreeNode node1 in this.treeView1.Nodes)
            {
                for (int index1 = 0; index1 < node1.Nodes.Count; ++index1)
                {
                    TreeNode node2 = node1.Nodes[index1];
                    for (int index2 = 0; index2 < dataTable.Rows.Count; ++index2)
                    {
                        DataRow row = dataTable.Rows[index2];
                        DateTime dateTime = Convert.ToDateTime(row["Fecha de Compra"]);
                        string str = Convert.ToBoolean(row["Estado de Pago"]) ? "Pagado" : "Pago pendiente";
                        if (dateTime.Year.ToString() == node2.Parent.Text)
                        {
                            TreeNode node3 = (TreeNode)null;
                            if (dateTime.Month == 1 && node2.Text == "Enero")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 2 && node2.Text == "Febrero")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 3 && node2.Text == "Marzo")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 4 && node2.Text == "Abril")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 5 && node2.Text == "Mayo")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 6 && node2.Text == "Junio")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 7 && node2.Text == "Julio")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 8 && node2.Text == "Agosto")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 9 && node2.Text == "Septiembre")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 10 && node2.Text == "Octubre")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 11 && node2.Text == "Noviembre")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            if (dateTime.Month == 12 && node2.Text == "Diciembre")
                                node3 = new TreeNode(row["ID_PO"].ToString() + ", Total=" + Convert.ToDouble(row["Total"]).ToString("n2") + ", " + str, 1, 1);
                            node1.ImageIndex = 0;
                            node1.SelectedImageIndex = 0;
                            if (node3 != null)
                            {
                                node3.ForeColor = !Convert.ToBoolean(row["Estado de Pago"]) ? Color.Tomato : Color.LimeGreen;
                                node2.Nodes.Add(node3);
                                row.Delete();
                                dataTable.AcceptChanges();
                                --index2;
                            }
                        }
                    }
                    if (node2.Nodes.Count == 0)
                    {
                        node2.Remove();
                        --index1;
                    }
                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                 if (e.Node.Text.IndexOf(",") <= -1)
                    return;
                //Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.IndexOf("bin"))), "Template\\PO#" + e.Node.Text.Substring(0, e.Node.Text.IndexOf(",")) + ".pdf"));
                Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\PO#" + e.Node.Text.Substring(0, e.Node.Text.IndexOf(",")) + ".pdf");
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("No se encontró el Archivo");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.IndexOf(',') != -1)
                return;
            this.listView1.Items.Clear();
            ListViewItem listViewItem = (ListViewItem)null;
            DataTable dataTable = this.supplier.POList.Copy();
            for (int index = 0; index < dataTable.Rows.Count; ++index)
            {
                DataRow row = dataTable.Rows[index];
                if (e.Node.Parent == null)
                {
                    DateTime dateTime = Convert.ToDateTime(row["Fecha de Compra"]);
                    if (e.Node.Text == dateTime.Year.ToString())
                    {
                        listViewItem = new ListViewItem("Orden de Compra #" + row["ID_PO"].ToString(), 1);
                        this.listView1.Items.Add(listViewItem);
                    }
                }
                if (e.Node.Parent != null && e.Node.Text.IndexOf(",") == -1)
                {
                    DateTime dateTime = Convert.ToDateTime(row["Fecha de Compra"]);
                    string str;
                    switch (dateTime.Month)
                    {
                        case 1:
                            str = "Enero";
                            break;
                        case 2:
                            str = "Febrero";
                            break;
                        case 3:
                            str = "Marzo";
                            break;
                        case 4:
                            str = "Abril";
                            break;
                        case 5:
                            str = "Mayo";
                            break;
                        case 6:
                            str = "Junio";
                            break;
                        case 7:
                            str = "Julio";
                            break;
                        case 8:
                            str = "Agosto";
                            break;
                        case 9:
                            str = "Septiembre";
                            break;
                        case 10:
                            str = "Octubre";
                            break;
                        case 11:
                            str = "Noviembre";
                            break;
                        case 12:
                            str = "Diciembre";
                            break;
                        default:
                            str = "";
                            break;
                    }
                    if (e.Node.Text == str && e.Node.Parent.Text == dateTime.Year.ToString())
                    {
                        listViewItem = new ListViewItem("Orden de Compra #" + row["ID_PO"].ToString(), 1);
                        this.listView1.Items.Add(listViewItem);
                    }
                }
                if (listViewItem != null)
                {
                    listViewItem.ForeColor = Convert.ToBoolean(row["Estado de Pago"]) ? Color.LimeGreen : Color.Tomato;
                    row.Delete();
                    dataTable.AcceptChanges();
                    --index;
                }
            }
            this.listView1.Sorting = SortOrder.Ascending;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
            {
                string text = selectedItem.Text;
                this.openFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\PO#" + text.Substring(text.IndexOf('#') + 1) + ".pdf");
               // this.openFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.IndexOf("bin"))), "Template\\PO#" + text.Substring(text.IndexOf('#') + 1) + ".pdf"));
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
            {
                string text = selectedItem.Text;
                //this.openFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.IndexOf("bin"))), "Template\\PO#" + text.Substring(text.IndexOf('#') + 1) + ".pdf"));
                this.openFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\PO#" + text.Substring(text.IndexOf('#') + 1) + ".pdf");
            }
        }

        private void openFile(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("No se encontró el archivo");
            }
        }
    }
}

