namespace Odev_BP
{
    partial class RoomStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();

            // cmbRoomStatus
            this.cmbRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Location = new System.Drawing.Point(12, 12);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomStatus.TabIndex = 0;
            this.cmbRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cmbRoomStatus_SelectedIndexChanged);

            // dgvRooms
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(12, 39);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(776, 399);
            this.dgvRooms.TabIndex = 1;

            // RoomStatusForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.cmbRoomStatus);
            this.Name = "RoomStatusForm";
            this.Text = "Room Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmbRoomStatus;
        private System.Windows.Forms.DataGridView dgvRooms;
    }
    }
