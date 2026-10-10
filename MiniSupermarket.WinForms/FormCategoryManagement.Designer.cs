using System.Drawing;
using System.Windows.Forms;

namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblInfoTitle;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblSearch = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();

            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();

            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            Panel panelTop = new Panel();
            Panel panelRight = new Panel();
            GroupBox grbInfo = new GroupBox();
            FlowLayoutPanel panelButtons = new FlowLayoutPanel();
            FlowLayoutPanel panelSearchFilter = new FlowLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormCategoryManagement";
            this.Text = "Quản lý Nhóm hàng";

            // =====================================================
            // TOP PANEL (Header & Search)
            // =====================================================

            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 70;
            panelTop.BackColor = System.Drawing.Color.White;
            panelTop.Padding = new Padding(15, 10, 15, 10);

            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblListTitle.Location = new System.Drawing.Point(15, 18);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Text = "QUẢN LÝ DANH MỤC NHÓM HÀNG";

            panelSearchFilter.Dock = DockStyle.Right;
            panelSearchFilter.AutoSize = true;
            panelSearchFilter.FlowDirection = FlowDirection.LeftToRight;
            panelSearchFilter.WrapContents = false;
            panelSearchFilter.Padding = new Padding(0, 10, 10, 0);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblSearch.Margin = new Padding(0, 8, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tìm kiếm";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Margin = new Padding(0, 2, 8, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Margin = new Padding(0, 0, 6, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnReload.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 28);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            panelSearchFilter.Controls.Add(this.lblSearch);
            panelSearchFilter.Controls.Add(this.txtSearch);
            panelSearchFilter.Controls.Add(this.btnSearch);
            panelSearchFilter.Controls.Add(this.btnReload);

            panelTop.Controls.Add(this.lblListTitle);
            panelTop.Controls.Add(panelSearchFilter);

            // =====================================================
            // RIGHT PANEL (Thông tin & Thao tác)
            // =====================================================

            panelRight.Dock = DockStyle.Right;
            panelRight.Width = 340;
            panelRight.BackColor = System.Drawing.Color.White;
            panelRight.Padding = new Padding(12);

            grbInfo.Text = "THÔNG TIN NHÓM HÀNG";
            grbInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            grbInfo.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            grbInfo.Dock = DockStyle.Top;
            grbInfo.Height = 280;
            grbInfo.Padding = new Padding(10);

            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(14, 30);
            this.lblID.Name = "lblID";
            this.lblID.Text = "Mã ID";

            this.txtID.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(14, 52);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(285, 23);
            this.txtID.TabIndex = 4;

            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(14, 88);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Tên Nhóm hàng";

            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(14, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 23);
            this.txtName.TabIndex = 5;

            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(14, 146);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "Mô tả";

            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(14, 168);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(285, 90);
            this.txtDescription.TabIndex = 6;

            grbInfo.Controls.AddRange(new Control[] {
                this.lblID, this.txtID,
                this.lblName, this.txtName,
                this.lblDescription, this.txtDescription
            });

            panelButtons.Dock = DockStyle.Top;
            panelButtons.AutoSize = true;
            panelButtons.FlowDirection = FlowDirection.LeftToRight;
            panelButtons.WrapContents = true;
            panelButtons.Padding = new Padding(0, 15, 0, 10);

            int btnWidth = 145;
            int btnHeight = 36;

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Margin = new Padding(0, 0, 8, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Margin = new Padding(0, 0, 0, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Margin = new Padding(0, 0, 8, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            panelButtons.Controls.AddRange(new Control[] { this.btnAdd, this.btnUpdate, this.btnDelete });

            panelRight.Controls.Add(panelButtons);
            panelRight.Controls.Add(grbInfo);

            // =====================================================
            // DATA GRID VIEW (Tự co giãn phủ kín phần còn lại)
            // =====================================================

            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dataGridView1.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(0, 123, 255),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            };
            this.dataGridView1.ColumnHeadersHeight = 35;

            this.dataGridView1.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.FromArgb(50, 50, 50),
                Font = new System.Drawing.Font("Segoe UI", 9F),
                SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 252),
                SelectionForeColor = System.Drawing.Color.FromArgb(30, 30, 30)
            };

            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.TabIndex = 3;

            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID,
                this.colName,
                this.colDescription
            });

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // =====================================================
            // COLUMNS
            // =====================================================

            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "Mã ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 70;

            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên Nhóm hàng";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 180;

            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            // =====================================================
            // STATUS STRIP
            // =====================================================

            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 10;

            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";

            // =====================================================
            // ADD CONTROLS TO FORM
            // =====================================================

            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(panelRight);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.statusStrip1);

            // =====================================================
            // LOAD EVENT
            // =====================================================

            this.Load += new System.EventHandler(this.FormCategoryManagement_Load_1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}