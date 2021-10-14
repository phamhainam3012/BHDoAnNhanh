using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCAFE
{
    public partial class Form3 : Form
    {
        QLQCOF5Entities thucan = new QLQCOF5Entities();
        QLQCOF5Entities ban = new QLQCOF5Entities();
        QLQCOF5Entities danhmuc = new QLQCOF5Entities();
        QLQCOF5Entities hoadon = new QLQCOF5Entities();
        public Form3()
        {
            InitializeComponent();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            rgthucan.DataSource = thucan.GetMONAN();
            rgdanhmuc.DataSource = danhmuc.GetDANHMUC();
            rgbanan.DataSource = ban.GetBAN();
            rghoadon.DataSource = hoadon.GetHOADON();
            idban.DataSource = hoadon.GetBAN();
            idban.DisplayMember = "Mã_BÀN";
            idban.ValueMember = "Mã_Bàn";
        }

        private void datamonan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thêm món ăn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    thucan.InsertMONAN(rtxID.Text,txbFoodName.Text,nmFoodPrice.Value,ImageToByteArray(imagethucan.Image));
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dlr = MessageBox.Show("Bạn muốn sửa món ăn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    thucan.UpdateMONAN(rtxID.Text, txbFoodName.Text, nmFoodPrice.Value,ImageToByteArray(imagethucan.Image));
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa món ăn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    thucan.DeleteMONAN(rtxID.Text);
                Form3_Load(sender, e);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSearchFoodName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            Form3_Load(sender, e);

        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            rgthucan.DataSource = thucan.SearchMONAN(txbSearchFoodName.Text);
        }
        
        private void dtgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thêm bàn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    ban.InsertBAN(txbIDban.Text, txbtenban.Text, rdtrangthaiban.Text);
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa bàn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    ban.DeleteBAN(txbIDban.Text, txbtenban.Text, rdtrangthaiban.Text);
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dlr = MessageBox.Show("Bạn muốn sửa bàn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    ban.UpdateBAN(txbIDban.Text, txbtenban.Text, rdtrangthaiban.Text);
                    Form3_Load(sender, e);
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            {
                Form3_Load(sender, e);
            }
        }

      
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn thêm danh mục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlr == DialogResult.Yes)
                    {
                        danhmuc.InserDANHMUC(tbIDdanhmuc.Text, tbtendanhmuc.Text);
                        Form3_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa danh mục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    danhmuc.DeleteDANHMUC(tbIDdanhmuc.Text, tbtendanhmuc.Text);
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dlr = MessageBox.Show("Bạn muốn sửa danh mục ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    danhmuc.UpdateDANHMUC(tbIDdanhmuc.Text, tbtendanhmuc.Text);
                    Form3_Load(sender, e);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            Form3_Load(sender, e);
        }

        private void IDMon_Valid(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxID.Text))
            {
                e.Cancel = true;
                rtxID.Focus();
                ValidIDmon.SetError(rtxID, "ID món ăn không được để trống!");
            }
            else
            {
                e.Cancel = false;
                ValidIDmon.SetError(rtxID, "");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnchoosen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image file (*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (of.ShowDialog() == DialogResult.OK)
                imagethucan.Image = new Bitmap(of.FileName);
        }

        private void rgthucan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rgthucan_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int i;
            i = rgthucan.CurrentRow.Index;
            rtxID.Text = rgthucan.Rows[i].Cells[0].Value.ToString();
            txbFoodName.Text = rgthucan.Rows[i].Cells[1].Value.ToString();
            nmFoodPrice.Text = rgthucan.Rows[i].Cells[2].Value.ToString();
            try
            {
                imagethucan.Image = byteArrayToImage((byte[])rgthucan.SelectedRows[0].Cells[3].Value);
            }
            catch
            {
            }
        }

        private void rgdanhmuc_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            {
                int i;
                i = rgdanhmuc.CurrentRow.Index;
                tbIDdanhmuc.Text = rgdanhmuc.Rows[i].Cells[0].Value.ToString();
                tbtendanhmuc.Text = rgdanhmuc.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void rgbanan_Click(object sender, EventArgs e)
        {

        }

        private void rgbanan_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int i;
            i = rgbanan.CurrentRow.Index;
            txbIDban.Text = rgbanan.Rows[i].Cells[0].Value.ToString();
            txbtenban.Text = rgbanan.Rows[i].Cells[1].Value.ToString();
            rdtrangthaiban.Text = rgbanan.Rows[i].Cells[2].Value.ToString();
        }

        private void rghoadon_Click(object sender, EventArgs e)
        {
            int i;
            i = rghoadon.CurrentRow.Index;
            idhoadon.Text = rghoadon.Rows[i].Cells[0].Value.ToString();
            idban.Text = rghoadon.Rows[i].Cells[1].Value.ToString();
            rdthoigiantoi.Value = Convert.ToDateTime (rghoadon.Rows[i].Cells[2].Value);
            rdthoigiandi.Value = Convert.ToDateTime (rghoadon.Rows[i].Cells[3].Value);
        }

        private void btxoahoadon_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    hoadon.DeleteHOADON(idhoadon.Text);
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btsuahoadon_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dlr = MessageBox.Show("Bạn muốn sửa hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    hoadon.UpdateHOADON(idhoadon.Text, idban.SelectedValue.ToString(), rdthoigiantoi.Value, rdthoigiandi.Value);
                    Form3_Load(sender, e);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btthemhoadon_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thêm hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    hoadon.InsertHOADON(idhoadon.Text, idban.SelectedValue.ToString(), rdthoigiantoi.Value, rdthoigiandi.Value);
                    Form3_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxemhoadon_Click(object sender, EventArgs e)
        {
            Form3_Load(sender, e);
        }

        private void cbTrangthaiban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdtrangthai_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }
    }
}
