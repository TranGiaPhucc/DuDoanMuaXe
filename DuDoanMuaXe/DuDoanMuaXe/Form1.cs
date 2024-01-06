using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DuDoanMuaXe
{
    public partial class Form1 : Form
    {
        double[] distances;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDiaChi.Enabled = false;

            comboBoxGioiTinh.Items.Add("Male");
            comboBoxGioiTinh.Items.Add("Female");
            comboBoxGioiTinh.SelectedIndex = 0;

            for (int i = 18; i <= 100; i++)
                comboBoxTuoi.Items.Add(i);
            comboBoxTuoi.SelectedIndex = 0;

            dataGridView2.Columns.Add("STT", "STT");
            dataGridView2.Columns.Add("UserID", "UserID");
            dataGridView2.Columns.Add("Khoảng cách" , "Khoảng cách");
            dataGridView2.Columns.Add("Purchased", "Purchased");
        }

        private void reload()
        {
            textBoxID.Text = "";
            textBoxLuong.Text = "";

            comboBoxGioiTinh.SelectedIndex = 0;
            comboBoxTuoi.SelectedIndex = 0;

            dataGridView2.Rows.Clear();
        }

        private void buttonMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog cFile = new OpenFileDialog();
            cFile.Filter = "customer file|*.csv";

            cFile.ShowDialog();

            string filePath = cFile.FileName;
            if (string.IsNullOrWhiteSpace(filePath))
                return;
            textBoxDiaChi.Text = filePath;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = docFile(filePath);
        }

        private DataTable docFile(string filePath)
        {
            var dt = new DataTable();
            // Creating the columns
            foreach (var headerLine in File.ReadLines(filePath).Take(1))
            {
                foreach (var headerItem in headerLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dt.Columns.Add(headerItem.Trim());
                }
            }

            File.ReadLines(filePath).Skip(1)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));

            return dt;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDiaChi.Text) == true || string.IsNullOrWhiteSpace(textBoxID.Text) == true || string.IsNullOrWhiteSpace(textBoxLuong.Text) == true)
            {
                MessageBox.Show(this, "Chưa nhập đủ dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView2.Rows.Clear();

            int n = dataGridView1.Rows.Count - 1;

            distances = new double[n + 1];

            int gioiTinh = 1;
            if (comboBoxGioiTinh.Text.Equals("Female") == true)
                gioiTinh = 0;

            int tuoi = int.Parse(comboBoxTuoi.Text);
            double luong = double.Parse(textBoxLuong.Text);
            
            for (int i = 0; i < n; i++)
            {
                string sGioiTinhDGV = dataGridView1.Rows[i].Cells[1].Value.ToString();

                int gioiTinhDGV = 1;
                if (sGioiTinhDGV.Equals("Female") == true)
                    gioiTinhDGV = 0;

                int tuoiDGV = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                double luongDGV = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                distances[i] = tinhKhoangCach((double)gioiTinh, (double)tuoi, luong, (double)gioiTinhDGV, (double)tuoiDGV, luongDGV);
            }

            //Chon k = 25% n
            int k = n / 4;

            //Xet neu k chan thi k++
            if (k % 2 == 0)
                k++;
            labelK.Text = "k = " + k.ToString();

            int[] index = new int[k];
            int id = 0;     // id for index array

            //Xet khoang cach min theo top k
            for (int step = 1; step <= k; step++)
            {
                double min = -1;
                int viTriI = -1;
                for (int i = 0; i < n; i++)
                {
                    if (!index.Contains(i))
                    {
                        if (min == -1 || (min != -1 && distances[i] < min))
                        {
                            viTriI = i;
                            min = distances[i];
                        }
                    }
                }
                if (viTriI != -1)
                {
                    index[id] = viTriI;
                    id++;
                }
            }

            //Xet nguoi nay mua hay chua (1 hay 0) theo k
            int[] mua = new int[k];
            int dem = 0;
            for (int i = 0; i < index.Length; i++)
            {
                mua[i] = int.Parse(dataGridView1.Rows[index[i]].Cells[4].Value.ToString());
                string userid = dataGridView1.Rows[index[i]].Cells[0].Value.ToString();
                dataGridView2.Rows.Add(i, userid, distances[i], mua[i]);
                if (mua[i] == 0)
                    dem--;
                else dem++;
            }

            if (dem > 0)        //Purchased co nhieu so 1 hon
                labelKetQua.Text = "Kết quả: Mua";
            else                //Purchased co nhieu so 0 hon
                labelKetQua.Text = "Kết quả: Không mua";
        }

        public double tinhKhoangCach(double x, double y, double z, double x1, double y1, double z1)
        {
            return Math.Sqrt(Math.Pow(x-x1,2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2));
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNhapLai_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
