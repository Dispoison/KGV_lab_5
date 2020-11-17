namespace KGV_lab_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cBox_rotateArbitAxis = new System.Windows.Forms.CheckBox();
            this.lbl_rotate = new System.Windows.Forms.Label();
            this.btn_zPlus = new System.Windows.Forms.Button();
            this.btn_zMinus = new System.Windows.Forms.Button();
            this.btn_yPlus = new System.Windows.Forms.Button();
            this.btn_yMinus = new System.Windows.Forms.Button();
            this.lbl_scale = new System.Windows.Forms.Label();
            this.btn_scaleDown = new System.Windows.Forms.Button();
            this.btn_scaleUp = new System.Windows.Forms.Button();
            this.lbl_transfer = new System.Windows.Forms.Label();
            this.btn_xMinus = new System.Windows.Forms.Button();
            this.btn_xPlus = new System.Windows.Forms.Button();
            this.cBox_rotateX = new System.Windows.Forms.CheckBox();
            this.cBox_rotateY = new System.Windows.Forms.CheckBox();
            this.cBox_rotateZ = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nX = new System.Windows.Forms.Label();
            this.lbl_arbitrAxis = new System.Windows.Forms.Label();
            this.lbl_mX = new System.Windows.Forms.Label();
            this.lbl_mY = new System.Windows.Forms.Label();
            this.lbl_mZ = new System.Windows.Forms.Label();
            this.lbl_nY = new System.Windows.Forms.Label();
            this.lbl_nZ = new System.Windows.Forms.Label();
            this.tBox_mX = new System.Windows.Forms.TextBox();
            this.tBox_nX = new System.Windows.Forms.TextBox();
            this.tBox_mY = new System.Windows.Forms.TextBox();
            this.tBox_nY = new System.Windows.Forms.TextBox();
            this.tBox_mZ = new System.Windows.Forms.TextBox();
            this.tBox_nZ = new System.Windows.Forms.TextBox();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.timer_fpsUpdate = new System.Windows.Forms.Timer(this.components);
            this.cBox_drawProj = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cBox_drawProjConnectLines = new System.Windows.Forms.CheckBox();
            this.cBox_drawProjX = new System.Windows.Forms.CheckBox();
            this.cBox_drawProjY = new System.Windows.Forms.CheckBox();
            this.cBox_drawProjZ = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_drawObjectAxis = new System.Windows.Forms.CheckBox();
            this.cBox_drawWorldAxis = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.10577F));
            this.tableLayoutPanel1.Controls.Add(this.picCanvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05312F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(800, 600);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cBox_rotateArbitAxis, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.lbl_rotate, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_zPlus, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_zMinus, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_yPlus, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_yMinus, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_scale, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_scaleDown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_scaleUp, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_transfer, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_xMinus, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_xPlus, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cBox_rotateX, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.cBox_rotateY, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.cBox_rotateZ, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 11);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(800, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 600);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cBox_rotateArbitAxis
            // 
            this.cBox_rotateArbitAxis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_rotateArbitAxis.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.cBox_rotateArbitAxis, 2);
            this.cBox_rotateArbitAxis.Location = new System.Drawing.Point(23, 334);
            this.cBox_rotateArbitAxis.Name = "cBox_rotateArbitAxis";
            this.cBox_rotateArbitAxis.Size = new System.Drawing.Size(159, 21);
            this.cBox_rotateArbitAxis.TabIndex = 15;
            this.cBox_rotateArbitAxis.Text = "Rotate Arbitrary Axis";
            this.cBox_rotateArbitAxis.UseVisualStyleBackColor = true;
            this.cBox_rotateArbitAxis.CheckedChanged += new System.EventHandler(this.cBox_rotateArbitAxis_CheckedChanged);
            // 
            // lbl_rotate
            // 
            this.lbl_rotate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_rotate.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbl_rotate, 2);
            this.lbl_rotate.Location = new System.Drawing.Point(78, 194);
            this.lbl_rotate.Name = "lbl_rotate";
            this.lbl_rotate.Size = new System.Drawing.Size(50, 17);
            this.lbl_rotate.TabIndex = 10;
            this.lbl_rotate.Text = "Rotate";
            // 
            // btn_zPlus
            // 
            this.btn_zPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zPlus.Location = new System.Drawing.Point(103, 149);
            this.btn_zPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_zPlus.Name = "btn_zPlus";
            this.btn_zPlus.Size = new System.Drawing.Size(103, 37);
            this.btn_zPlus.TabIndex = 9;
            this.btn_zPlus.Text = "+Z";
            this.btn_zPlus.UseVisualStyleBackColor = true;
            this.btn_zPlus.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // btn_zMinus
            // 
            this.btn_zMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zMinus.Location = new System.Drawing.Point(0, 149);
            this.btn_zMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_zMinus.Name = "btn_zMinus";
            this.btn_zMinus.Size = new System.Drawing.Size(103, 37);
            this.btn_zMinus.TabIndex = 8;
            this.btn_zMinus.Text = "-Z";
            this.btn_zMinus.UseVisualStyleBackColor = true;
            this.btn_zMinus.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // btn_yPlus
            // 
            this.btn_yPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_yPlus.Location = new System.Drawing.Point(103, 114);
            this.btn_yPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_yPlus.Name = "btn_yPlus";
            this.btn_yPlus.Size = new System.Drawing.Size(103, 35);
            this.btn_yPlus.TabIndex = 7;
            this.btn_yPlus.Text = "+Y";
            this.btn_yPlus.UseVisualStyleBackColor = true;
            this.btn_yPlus.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // btn_yMinus
            // 
            this.btn_yMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_yMinus.Location = new System.Drawing.Point(0, 114);
            this.btn_yMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_yMinus.Name = "btn_yMinus";
            this.btn_yMinus.Size = new System.Drawing.Size(103, 35);
            this.btn_yMinus.TabIndex = 6;
            this.btn_yMinus.Text = "-Y";
            this.btn_yMinus.UseVisualStyleBackColor = true;
            this.btn_yMinus.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // lbl_scale
            // 
            this.lbl_scale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_scale.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbl_scale, 2);
            this.lbl_scale.Location = new System.Drawing.Point(81, 1);
            this.lbl_scale.Name = "lbl_scale";
            this.lbl_scale.Size = new System.Drawing.Size(43, 17);
            this.lbl_scale.TabIndex = 0;
            this.lbl_scale.Text = "Scale";
            // 
            // btn_scaleDown
            // 
            this.btn_scaleDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_scaleDown.Location = new System.Drawing.Point(0, 20);
            this.btn_scaleDown.Margin = new System.Windows.Forms.Padding(0);
            this.btn_scaleDown.Name = "btn_scaleDown";
            this.btn_scaleDown.Size = new System.Drawing.Size(103, 36);
            this.btn_scaleDown.TabIndex = 1;
            this.btn_scaleDown.Text = "Scale down";
            this.btn_scaleDown.UseVisualStyleBackColor = true;
            this.btn_scaleDown.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // btn_scaleUp
            // 
            this.btn_scaleUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_scaleUp.Location = new System.Drawing.Point(103, 20);
            this.btn_scaleUp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_scaleUp.Name = "btn_scaleUp";
            this.btn_scaleUp.Size = new System.Drawing.Size(103, 36);
            this.btn_scaleUp.TabIndex = 2;
            this.btn_scaleUp.Text = "Scale up";
            this.btn_scaleUp.UseVisualStyleBackColor = true;
            this.btn_scaleUp.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // lbl_transfer
            // 
            this.lbl_transfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_transfer.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lbl_transfer, 2);
            this.lbl_transfer.Location = new System.Drawing.Point(72, 61);
            this.lbl_transfer.Name = "lbl_transfer";
            this.lbl_transfer.Size = new System.Drawing.Size(62, 17);
            this.lbl_transfer.TabIndex = 3;
            this.lbl_transfer.Text = "Transfer";
            // 
            // btn_xMinus
            // 
            this.btn_xMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xMinus.Location = new System.Drawing.Point(0, 84);
            this.btn_xMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_xMinus.Name = "btn_xMinus";
            this.btn_xMinus.Size = new System.Drawing.Size(103, 30);
            this.btn_xMinus.TabIndex = 4;
            this.btn_xMinus.Text = "-X";
            this.btn_xMinus.UseVisualStyleBackColor = true;
            this.btn_xMinus.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // btn_xPlus
            // 
            this.btn_xPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xPlus.Location = new System.Drawing.Point(103, 84);
            this.btn_xPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_xPlus.Name = "btn_xPlus";
            this.btn_xPlus.Size = new System.Drawing.Size(103, 30);
            this.btn_xPlus.TabIndex = 5;
            this.btn_xPlus.Text = "+X";
            this.btn_xPlus.UseVisualStyleBackColor = true;
            this.btn_xPlus.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // cBox_rotateX
            // 
            this.cBox_rotateX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_rotateX.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.cBox_rotateX, 2);
            this.cBox_rotateX.Location = new System.Drawing.Point(60, 225);
            this.cBox_rotateX.Name = "cBox_rotateX";
            this.cBox_rotateX.Size = new System.Drawing.Size(85, 21);
            this.cBox_rotateX.TabIndex = 11;
            this.cBox_rotateX.Text = "Rotate X";
            this.cBox_rotateX.UseVisualStyleBackColor = true;
            // 
            // cBox_rotateY
            // 
            this.cBox_rotateY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_rotateY.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.cBox_rotateY, 2);
            this.cBox_rotateY.Location = new System.Drawing.Point(60, 260);
            this.cBox_rotateY.Name = "cBox_rotateY";
            this.cBox_rotateY.Size = new System.Drawing.Size(85, 21);
            this.cBox_rotateY.TabIndex = 12;
            this.cBox_rotateY.Text = "Rotate Y";
            this.cBox_rotateY.UseVisualStyleBackColor = true;
            // 
            // cBox_rotateZ
            // 
            this.cBox_rotateZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_rotateZ.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.cBox_rotateZ, 2);
            this.cBox_rotateZ.Location = new System.Drawing.Point(60, 297);
            this.cBox_rotateZ.Name = "cBox_rotateZ";
            this.cBox_rotateZ.Size = new System.Drawing.Size(85, 21);
            this.cBox_rotateZ.TabIndex = 13;
            this.cBox_rotateZ.Text = "Rotate Z";
            this.cBox_rotateZ.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_nX, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_arbitrAxis, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_mX, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_mY, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_mZ, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl_nY, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_nZ, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tBox_mX, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tBox_nX, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tBox_mY, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tBox_nY, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tBox_mZ, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.tBox_nZ, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.cBox_drawProj, 0, 9);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 363);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(206, 234);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lbl_nX
            // 
            this.lbl_nX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_nX.AutoSize = true;
            this.lbl_nX.Location = new System.Drawing.Point(106, 25);
            this.lbl_nX.Name = "lbl_nX";
            this.lbl_nX.Size = new System.Drawing.Size(25, 17);
            this.lbl_nX.TabIndex = 2;
            this.lbl_nX.Text = "nX";
            // 
            // lbl_arbitrAxis
            // 
            this.lbl_arbitrAxis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_arbitrAxis.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.lbl_arbitrAxis, 2);
            this.lbl_arbitrAxis.Location = new System.Drawing.Point(21, 0);
            this.lbl_arbitrAxis.Name = "lbl_arbitrAxis";
            this.lbl_arbitrAxis.Size = new System.Drawing.Size(164, 17);
            this.lbl_arbitrAxis.TabIndex = 0;
            this.lbl_arbitrAxis.Text = "Arbitrary Axis of Rotation";
            // 
            // lbl_mX
            // 
            this.lbl_mX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_mX.AutoSize = true;
            this.lbl_mX.Location = new System.Drawing.Point(3, 25);
            this.lbl_mX.Name = "lbl_mX";
            this.lbl_mX.Size = new System.Drawing.Size(28, 17);
            this.lbl_mX.TabIndex = 1;
            this.lbl_mX.Text = "mX";
            // 
            // lbl_mY
            // 
            this.lbl_mY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_mY.AutoSize = true;
            this.lbl_mY.Location = new System.Drawing.Point(3, 80);
            this.lbl_mY.Name = "lbl_mY";
            this.lbl_mY.Size = new System.Drawing.Size(28, 17);
            this.lbl_mY.TabIndex = 1;
            this.lbl_mY.Text = "mY";
            // 
            // lbl_mZ
            // 
            this.lbl_mZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_mZ.AutoSize = true;
            this.lbl_mZ.Location = new System.Drawing.Point(3, 120);
            this.lbl_mZ.Name = "lbl_mZ";
            this.lbl_mZ.Size = new System.Drawing.Size(28, 17);
            this.lbl_mZ.TabIndex = 1;
            this.lbl_mZ.Text = "mZ";
            // 
            // lbl_nY
            // 
            this.lbl_nY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_nY.AutoSize = true;
            this.lbl_nY.Location = new System.Drawing.Point(106, 80);
            this.lbl_nY.Name = "lbl_nY";
            this.lbl_nY.Size = new System.Drawing.Size(25, 17);
            this.lbl_nY.TabIndex = 2;
            this.lbl_nY.Text = "nY";
            // 
            // lbl_nZ
            // 
            this.lbl_nZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_nZ.AutoSize = true;
            this.lbl_nZ.Location = new System.Drawing.Point(106, 120);
            this.lbl_nZ.Name = "lbl_nZ";
            this.lbl_nZ.Size = new System.Drawing.Size(25, 17);
            this.lbl_nZ.TabIndex = 2;
            this.lbl_nZ.Text = "nZ";
            // 
            // tBox_mX
            // 
            this.tBox_mX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_mX.Location = new System.Drawing.Point(1, 48);
            this.tBox_mX.Margin = new System.Windows.Forms.Padding(0);
            this.tBox_mX.Name = "tBox_mX";
            this.tBox_mX.Size = new System.Drawing.Size(100, 22);
            this.tBox_mX.TabIndex = 3;
            this.tBox_mX.Text = "0";
            this.tBox_mX.TextChanged += new System.EventHandler(this.tBox_arbitCoord_TextChanged);
            this.tBox_mX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_arbitCoord_KeyPress);
            // 
            // tBox_nX
            // 
            this.tBox_nX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_nX.Location = new System.Drawing.Point(104, 48);
            this.tBox_nX.Margin = new System.Windows.Forms.Padding(0);
            this.tBox_nX.Name = "tBox_nX";
            this.tBox_nX.Size = new System.Drawing.Size(100, 22);
            this.tBox_nX.TabIndex = 3;
            this.tBox_nX.Text = "1";
            this.tBox_nX.TextChanged += new System.EventHandler(this.tBox_arbitCoord_TextChanged);
            this.tBox_nX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_arbitCoord_KeyPress);
            // 
            // tBox_mY
            // 
            this.tBox_mY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_mY.Location = new System.Drawing.Point(1, 97);
            this.tBox_mY.Margin = new System.Windows.Forms.Padding(0);
            this.tBox_mY.Name = "tBox_mY";
            this.tBox_mY.Size = new System.Drawing.Size(100, 22);
            this.tBox_mY.TabIndex = 3;
            this.tBox_mY.Text = "0";
            this.tBox_mY.TextChanged += new System.EventHandler(this.tBox_arbitCoord_TextChanged);
            this.tBox_mY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_arbitCoord_KeyPress);
            // 
            // tBox_nY
            // 
            this.tBox_nY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_nY.Location = new System.Drawing.Point(104, 97);
            this.tBox_nY.Margin = new System.Windows.Forms.Padding(0);
            this.tBox_nY.Name = "tBox_nY";
            this.tBox_nY.Size = new System.Drawing.Size(100, 22);
            this.tBox_nY.TabIndex = 3;
            this.tBox_nY.Text = "1";
            this.tBox_nY.TextChanged += new System.EventHandler(this.tBox_arbitCoord_TextChanged);
            this.tBox_nY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_arbitCoord_KeyPress);
            // 
            // tBox_mZ
            // 
            this.tBox_mZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_mZ.Location = new System.Drawing.Point(1, 137);
            this.tBox_mZ.Margin = new System.Windows.Forms.Padding(0);
            this.tBox_mZ.Name = "tBox_mZ";
            this.tBox_mZ.Size = new System.Drawing.Size(100, 22);
            this.tBox_mZ.TabIndex = 3;
            this.tBox_mZ.Text = "0";
            this.tBox_mZ.TextChanged += new System.EventHandler(this.tBox_arbitCoord_TextChanged);
            this.tBox_mZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_arbitCoord_KeyPress);
            // 
            // tBox_nZ
            // 
            this.tBox_nZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_nZ.Location = new System.Drawing.Point(104, 137);
            this.tBox_nZ.Margin = new System.Windows.Forms.Padding(0);
            this.tBox_nZ.Name = "tBox_nZ";
            this.tBox_nZ.Size = new System.Drawing.Size(100, 22);
            this.tBox_nZ.TabIndex = 3;
            this.tBox_nZ.Text = "1";
            this.tBox_nZ.TextChanged += new System.EventHandler(this.tBox_arbitCoord_TextChanged);
            this.tBox_nZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_arbitCoord_KeyPress);
            // 
            // timer_game
            // 
            this.timer_game.Enabled = true;
            this.timer_game.Interval = 15;
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // timer_fpsUpdate
            // 
            this.timer_fpsUpdate.Enabled = true;
            this.timer_fpsUpdate.Interval = 50;
            this.timer_fpsUpdate.Tick += new System.EventHandler(this.timer_fpsUpdate_Tick);
            // 
            // cBox_drawProj
            // 
            this.cBox_drawProj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawProj.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.cBox_drawProj, 2);
            this.cBox_drawProj.Location = new System.Drawing.Point(35, 205);
            this.cBox_drawProj.Name = "cBox_drawProj";
            this.cBox_drawProj.Size = new System.Drawing.Size(136, 21);
            this.cBox_drawProj.TabIndex = 4;
            this.cBox_drawProj.Text = "Draw Projections";
            this.cBox_drawProj.UseVisualStyleBackColor = true;
            this.cBox_drawProj.CheckedChanged += new System.EventHandler(this.cBox_drawProj_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.cBox_drawProjConnectLines, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cBox_drawProjX, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cBox_drawProjY, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cBox_drawProjZ, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(803, 603);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 115);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // cBox_drawProjConnectLines
            // 
            this.cBox_drawProjConnectLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawProjConnectLines.AutoSize = true;
            this.cBox_drawProjConnectLines.Checked = true;
            this.cBox_drawProjConnectLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.cBox_drawProjConnectLines, 2);
            this.cBox_drawProjConnectLines.Location = new System.Drawing.Point(28, 6);
            this.cBox_drawProjConnectLines.Name = "cBox_drawProjConnectLines";
            this.cBox_drawProjConnectLines.Size = new System.Drawing.Size(144, 21);
            this.cBox_drawProjConnectLines.TabIndex = 0;
            this.cBox_drawProjConnectLines.Text = "Draw Connections";
            this.cBox_drawProjConnectLines.UseVisualStyleBackColor = true;
            this.cBox_drawProjConnectLines.Visible = false;
            // 
            // cBox_drawProjX
            // 
            this.cBox_drawProjX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawProjX.AutoSize = true;
            this.cBox_drawProjX.Checked = true;
            this.cBox_drawProjX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.cBox_drawProjX, 2);
            this.cBox_drawProjX.Location = new System.Drawing.Point(29, 37);
            this.cBox_drawProjX.Name = "cBox_drawProjX";
            this.cBox_drawProjX.Size = new System.Drawing.Size(142, 20);
            this.cBox_drawProjX.TabIndex = 1;
            this.cBox_drawProjX.Text = "Draw Projection X";
            this.cBox_drawProjX.UseVisualStyleBackColor = true;
            this.cBox_drawProjX.Visible = false;
            // 
            // cBox_drawProjY
            // 
            this.cBox_drawProjY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawProjY.AutoSize = true;
            this.cBox_drawProjY.Checked = true;
            this.cBox_drawProjY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.cBox_drawProjY, 2);
            this.cBox_drawProjY.Location = new System.Drawing.Point(29, 63);
            this.cBox_drawProjY.Name = "cBox_drawProjY";
            this.cBox_drawProjY.Size = new System.Drawing.Size(142, 21);
            this.cBox_drawProjY.TabIndex = 2;
            this.cBox_drawProjY.Text = "Draw Projection Y";
            this.cBox_drawProjY.UseVisualStyleBackColor = true;
            this.cBox_drawProjY.Visible = false;
            // 
            // cBox_drawProjZ
            // 
            this.cBox_drawProjZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawProjZ.AutoSize = true;
            this.cBox_drawProjZ.Checked = true;
            this.cBox_drawProjZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.cBox_drawProjZ, 2);
            this.cBox_drawProjZ.Location = new System.Drawing.Point(29, 90);
            this.cBox_drawProjZ.Name = "cBox_drawProjZ";
            this.cBox_drawProjZ.Size = new System.Drawing.Size(142, 21);
            this.cBox_drawProjZ.TabIndex = 3;
            this.cBox_drawProjZ.Text = "Draw Projection Z";
            this.cBox_drawProjZ.UseVisualStyleBackColor = true;
            this.cBox_drawProjZ.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.71536F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.28464F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cBox_drawObjectAxis, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cBox_drawWorldAxis, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 603);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 115);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // cBox_drawObjectAxis
            // 
            this.cBox_drawObjectAxis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawObjectAxis.AutoSize = true;
            this.cBox_drawObjectAxis.Location = new System.Drawing.Point(641, 18);
            this.cBox_drawObjectAxis.Name = "cBox_drawObjectAxis";
            this.cBox_drawObjectAxis.Size = new System.Drawing.Size(136, 21);
            this.cBox_drawObjectAxis.TabIndex = 4;
            this.cBox_drawObjectAxis.Text = "Draw Object Axis";
            this.cBox_drawObjectAxis.UseVisualStyleBackColor = true;
            // 
            // cBox_drawWorldAxis
            // 
            this.cBox_drawWorldAxis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_drawWorldAxis.AutoSize = true;
            this.cBox_drawWorldAxis.Location = new System.Drawing.Point(643, 75);
            this.cBox_drawWorldAxis.Name = "cBox_drawWorldAxis";
            this.cBox_drawWorldAxis.Size = new System.Drawing.Size(132, 21);
            this.cBox_drawWorldAxis.TabIndex = 5;
            this.cBox_drawWorldAxis.Text = "Draw World Axis";
            this.cBox_drawWorldAxis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.Timer timer_fpsUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_scale;
        private System.Windows.Forms.Button btn_scaleDown;
        private System.Windows.Forms.Button btn_scaleUp;
        private System.Windows.Forms.Label lbl_transfer;
        private System.Windows.Forms.Button btn_xMinus;
        private System.Windows.Forms.Label lbl_rotate;
        private System.Windows.Forms.Button btn_zPlus;
        private System.Windows.Forms.Button btn_zMinus;
        private System.Windows.Forms.Button btn_yPlus;
        private System.Windows.Forms.Button btn_yMinus;
        private System.Windows.Forms.Button btn_xPlus;
        private System.Windows.Forms.CheckBox cBox_rotateX;
        private System.Windows.Forms.CheckBox cBox_rotateY;
        private System.Windows.Forms.CheckBox cBox_rotateZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_nX;
        private System.Windows.Forms.Label lbl_arbitrAxis;
        private System.Windows.Forms.Label lbl_mX;
        private System.Windows.Forms.Label lbl_mY;
        private System.Windows.Forms.Label lbl_mZ;
        private System.Windows.Forms.Label lbl_nY;
        private System.Windows.Forms.Label lbl_nZ;
        private System.Windows.Forms.TextBox tBox_mX;
        private System.Windows.Forms.TextBox tBox_nX;
        private System.Windows.Forms.CheckBox cBox_rotateArbitAxis;
        private System.Windows.Forms.TextBox tBox_mY;
        private System.Windows.Forms.TextBox tBox_nY;
        private System.Windows.Forms.TextBox tBox_mZ;
        private System.Windows.Forms.TextBox tBox_nZ;
        private System.Windows.Forms.CheckBox cBox_drawProj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.CheckBox cBox_drawProjConnectLines;
        public System.Windows.Forms.CheckBox cBox_drawProjX;
        public System.Windows.Forms.CheckBox cBox_drawProjY;
        public System.Windows.Forms.CheckBox cBox_drawProjZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBox_drawObjectAxis;
        private System.Windows.Forms.CheckBox cBox_drawWorldAxis;
    }
}

