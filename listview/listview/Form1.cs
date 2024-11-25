using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ListViewItem list = new ListViewItem(txt_stt.Text);
            list.SubItems.Add(txt_ma.Text);
            list.SubItems.Add(txt_ten.Text);
            lsSanPham.Items.Add(list);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {   //remove by selected item
            foreach (ListViewItem eachItem in lsSanPham.SelectedItems)
            {
                lsSanPham.Items.Remove(eachItem);
            }
            //remove by text match
            foreach (ListViewItem item in lsSanPham.Items)
            {
                if (item.Text == txt_stt.Text &&
                    item.SubItems[1].Text == txt_ma.Text &&
                    item.SubItems[2].Text == txt_ten.Text)
                {
                    lsSanPham.Items.Remove(item);
                    break; 
                }
            }

            //remove by check box
            foreach (ListViewItem item in lsSanPham.Items)
            {
                if (item.Checked)
                    item.Remove();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            if (lsSanPham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsSanPham.SelectedItems[0];
                selectedItem.Text = txt_stt.Text; 
                selectedItem.SubItems[1].Text = txt_ma.Text;
                selectedItem.SubItems[2].Text = txt_ten.Text; 
            }
            else
            {
                MessageBox.Show("chọn dòng để edit", "Edit dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
