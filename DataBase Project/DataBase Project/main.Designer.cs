namespace DataBase_Project
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookSearchResult = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.readerInfo = new System.Windows.Forms.TabPage();
            this.editReader = new System.Windows.Forms.Button();
            this.deleteReader = new System.Windows.Forms.Button();
            this.addReader = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readerSearchResult = new System.Windows.Forms.DataGridView();
            this.readerCondition = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.TextBox();
            this.rBorrowedNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rCurNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.readerSearch = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allBooksInfo = new System.Windows.Forms.TabPage();
            this.editBook = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.returnBook = new System.Windows.Forms.Button();
            this.borrowBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bookCondition = new System.Windows.Forms.GroupBox();
            this.borrowable = new System.Windows.Forms.ComboBox();
            this.bookSearch = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bookTotalCount = new System.Windows.Forms.TextBox();
            this.press = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookBorrowCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bookID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.delayedBooksInfo = new System.Windows.Forms.TabPage();
            this.delayedBookSearch = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.delayedbookSearchResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookSearchResult)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.readerInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerSearchResult)).BeginInit();
            this.readerCondition.SuspendLayout();
            this.allBooksInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.bookCondition.SuspendLayout();
            this.delayedBooksInfo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayedbookSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // bookSearchResult
            // 
            this.bookSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookSearchResult.Location = new System.Drawing.Point(3, 14);
            this.bookSearchResult.Name = "bookSearchResult";
            this.bookSearchResult.RowTemplate.Height = 23;
            this.bookSearchResult.Size = new System.Drawing.Size(714, 291);
            this.bookSearchResult.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.readerInfo);
            this.tabControl1.Controls.Add(this.allBooksInfo);
            this.tabControl1.Controls.Add(this.delayedBooksInfo);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // readerInfo
            // 
            this.readerInfo.BackColor = System.Drawing.SystemColors.Control;
            this.readerInfo.Controls.Add(this.editReader);
            this.readerInfo.Controls.Add(this.deleteReader);
            this.readerInfo.Controls.Add(this.addReader);
            this.readerInfo.Controls.Add(this.groupBox2);
            this.readerInfo.Controls.Add(this.readerCondition);
            this.readerInfo.Location = new System.Drawing.Point(4, 22);
            this.readerInfo.Name = "readerInfo";
            this.readerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.readerInfo.Size = new System.Drawing.Size(791, 556);
            this.readerInfo.TabIndex = 0;
            this.readerInfo.Text = "读者信息";
            // 
            // editReader
            // 
            this.editReader.Location = new System.Drawing.Point(677, 484);
            this.editReader.Name = "editReader";
            this.editReader.Size = new System.Drawing.Size(75, 23);
            this.editReader.TabIndex = 4;
            this.editReader.Text = "编辑";
            this.editReader.UseVisualStyleBackColor = true;
            // 
            // deleteReader
            // 
            this.deleteReader.Location = new System.Drawing.Point(336, 484);
            this.deleteReader.Name = "deleteReader";
            this.deleteReader.Size = new System.Drawing.Size(75, 23);
            this.deleteReader.TabIndex = 3;
            this.deleteReader.Text = "删除";
            this.deleteReader.UseVisualStyleBackColor = true;
            // 
            // addReader
            // 
            this.addReader.Location = new System.Drawing.Point(28, 484);
            this.addReader.Name = "addReader";
            this.addReader.Size = new System.Drawing.Size(75, 23);
            this.addReader.TabIndex = 2;
            this.addReader.Text = "新增";
            this.addReader.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readerSearchResult);
            this.groupBox2.Location = new System.Drawing.Point(26, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // readerSearchResult
            // 
            this.readerSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerSearchResult.Location = new System.Drawing.Point(2, 14);
            this.readerSearchResult.Name = "readerSearchResult";
            this.readerSearchResult.RowTemplate.Height = 23;
            this.readerSearchResult.Size = new System.Drawing.Size(718, 287);
            this.readerSearchResult.TabIndex = 0;
            // 
            // readerCondition
            // 
            this.readerCondition.Controls.Add(this.label10);
            this.readerCondition.Controls.Add(this.dept);
            this.readerCondition.Controls.Add(this.rBorrowedNum);
            this.readerCondition.Controls.Add(this.label11);
            this.readerCondition.Controls.Add(this.rCurNum);
            this.readerCondition.Controls.Add(this.label12);
            this.readerCondition.Controls.Add(this.sex);
            this.readerCondition.Controls.Add(this.readerSearch);
            this.readerCondition.Controls.Add(this.phone);
            this.readerCondition.Controls.Add(this.label5);
            this.readerCondition.Controls.Add(this.job);
            this.readerCondition.Controls.Add(this.label4);
            this.readerCondition.Controls.Add(this.label3);
            this.readerCondition.Controls.Add(this.rname);
            this.readerCondition.Controls.Add(this.label2);
            this.readerCondition.Controls.Add(this.borrowid);
            this.readerCondition.Controls.Add(this.label1);
            this.readerCondition.Location = new System.Drawing.Point(26, 23);
            this.readerCondition.Name = "readerCondition";
            this.readerCondition.Size = new System.Drawing.Size(726, 148);
            this.readerCondition.TabIndex = 0;
            this.readerCondition.TabStop = false;
            this.readerCondition.Text = "查询条件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "工作部门";
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(432, 71);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(100, 21);
            this.dept.TabIndex = 23;
            // 
            // rBorrowedNum
            // 
            this.rBorrowedNum.Location = new System.Drawing.Point(267, 71);
            this.rBorrowedNum.Name = "rBorrowedNum";
            this.rBorrowedNum.Size = new System.Drawing.Size(100, 21);
            this.rBorrowedNum.TabIndex = 22;
            this.rBorrowedNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "最少已借数量";
            // 
            // rCurNum
            // 
            this.rCurNum.Location = new System.Drawing.Point(85, 71);
            this.rCurNum.Name = "rCurNum";
            this.rCurNum.Size = new System.Drawing.Size(100, 21);
            this.rCurNum.TabIndex = 20;
            this.rCurNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "最少可借数量";
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(432, 32);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 20);
            this.sex.TabIndex = 18;
            // 
            // readerSearch
            // 
            this.readerSearch.Location = new System.Drawing.Point(310, 109);
            this.readerSearch.Name = "readerSearch";
            this.readerSearch.Size = new System.Drawing.Size(75, 23);
            this.readerSearch.TabIndex = 16;
            this.readerSearch.Text = "查询";
            this.readerSearch.UseVisualStyleBackColor = true;
            this.readerSearch.Click += new System.EventHandler(this.readerSearch_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(597, 71);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 21);
            this.phone.TabIndex = 15;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "联系电话";
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(597, 32);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(100, 21);
            this.job.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "职称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别";
            // 
            // rname
            // 
            this.rname.Location = new System.Drawing.Point(267, 32);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(100, 21);
            this.rname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // borrowid
            // 
            this.borrowid.Location = new System.Drawing.Point(85, 32);
            this.borrowid.Name = "borrowid";
            this.borrowid.Size = new System.Drawing.Size(100, 21);
            this.borrowid.TabIndex = 1;
            this.borrowid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号";
            // 
            // allBooksInfo
            // 
            this.allBooksInfo.BackColor = System.Drawing.SystemColors.Control;
            this.allBooksInfo.Controls.Add(this.editBook);
            this.allBooksInfo.Controls.Add(this.deleteBook);
            this.allBooksInfo.Controls.Add(this.addBook);
            this.allBooksInfo.Controls.Add(this.returnBook);
            this.allBooksInfo.Controls.Add(this.borrowBook);
            this.allBooksInfo.Controls.Add(this.groupBox3);
            this.allBooksInfo.Controls.Add(this.bookCondition);
            this.allBooksInfo.Location = new System.Drawing.Point(4, 22);
            this.allBooksInfo.Name = "allBooksInfo";
            this.allBooksInfo.Padding = new System.Windows.Forms.Padding(3);
            this.allBooksInfo.Size = new System.Drawing.Size(791, 556);
            this.allBooksInfo.TabIndex = 1;
            this.allBooksInfo.Text = "图书信息";
            // 
            // editBook
            // 
            this.editBook.Location = new System.Drawing.Point(680, 486);
            this.editBook.Name = "editBook";
            this.editBook.Size = new System.Drawing.Size(75, 23);
            this.editBook.TabIndex = 8;
            this.editBook.Text = "编辑";
            this.editBook.UseVisualStyleBackColor = true;
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(357, 486);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(75, 23);
            this.deleteBook.TabIndex = 7;
            this.deleteBook.Text = "删除";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(35, 486);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(75, 23);
            this.addBook.TabIndex = 6;
            this.addBook.Text = "新增";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // returnBook
            // 
            this.returnBook.Location = new System.Drawing.Point(521, 486);
            this.returnBook.Name = "returnBook";
            this.returnBook.Size = new System.Drawing.Size(75, 23);
            this.returnBook.TabIndex = 5;
            this.returnBook.Text = "还书";
            this.returnBook.UseVisualStyleBackColor = true;
            // 
            // borrowBook
            // 
            this.borrowBook.Location = new System.Drawing.Point(194, 486);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(75, 23);
            this.borrowBook.TabIndex = 4;
            this.borrowBook.Text = "借书";
            this.borrowBook.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bookSearchResult);
            this.groupBox3.Location = new System.Drawing.Point(32, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 310);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询结果";
            // 
            // bookCondition
            // 
            this.bookCondition.Controls.Add(this.borrowable);
            this.bookCondition.Controls.Add(this.bookSearch);
            this.bookCondition.Controls.Add(this.author);
            this.bookCondition.Controls.Add(this.label6);
            this.bookCondition.Controls.Add(this.label13);
            this.bookCondition.Controls.Add(this.label14);
            this.bookCondition.Controls.Add(this.bookTotalCount);
            this.bookCondition.Controls.Add(this.press);
            this.bookCondition.Controls.Add(this.label7);
            this.bookCondition.Controls.Add(this.label8);
            this.bookCondition.Controls.Add(this.bookName);
            this.bookCondition.Controls.Add(this.bookBorrowCount);
            this.bookCondition.Controls.Add(this.label15);
            this.bookCondition.Controls.Add(this.bookID);
            this.bookCondition.Controls.Add(this.label16);
            this.bookCondition.Location = new System.Drawing.Point(32, 21);
            this.bookCondition.Name = "bookCondition";
            this.bookCondition.Size = new System.Drawing.Size(723, 148);
            this.bookCondition.TabIndex = 2;
            this.bookCondition.TabStop = false;
            this.bookCondition.Text = "查询条件";
            // 
            // borrowable
            // 
            this.borrowable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borrowable.FormattingEnabled = true;
            this.borrowable.Items.AddRange(new object[] {
            "是",
            "否"});
            this.borrowable.Location = new System.Drawing.Point(556, 71);
            this.borrowable.Name = "borrowable";
            this.borrowable.Size = new System.Drawing.Size(100, 20);
            this.borrowable.TabIndex = 23;
            // 
            // bookSearch
            // 
            this.bookSearch.Location = new System.Drawing.Point(325, 110);
            this.bookSearch.Name = "bookSearch";
            this.bookSearch.Size = new System.Drawing.Size(75, 23);
            this.bookSearch.TabIndex = 16;
            this.bookSearch.Text = "查询";
            this.bookSearch.UseVisualStyleBackColor = true;
            this.bookSearch.Click += new System.EventHandler(this.bookSearch_Click);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(568, 29);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 21);
            this.author.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "是否可借";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(521, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "作者";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "出版社";
            // 
            // bookTotalCount
            // 
            this.bookTotalCount.Location = new System.Drawing.Point(371, 71);
            this.bookTotalCount.Name = "bookTotalCount";
            this.bookTotalCount.Size = new System.Drawing.Size(100, 21);
            this.bookTotalCount.TabIndex = 21;
            this.bookTotalCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // press
            // 
            this.press.Location = new System.Drawing.Point(415, 29);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(100, 21);
            this.press.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(278, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "最少馆藏数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "最少可借数量";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(262, 29);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(100, 21);
            this.bookName.TabIndex = 3;
            // 
            // bookBorrowCount
            // 
            this.bookBorrowCount.Location = new System.Drawing.Point(162, 71);
            this.bookBorrowCount.Name = "bookBorrowCount";
            this.bookBorrowCount.Size = new System.Drawing.Size(100, 21);
            this.bookBorrowCount.TabIndex = 19;
            this.bookBorrowCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(215, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "书名";
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(109, 29);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(100, 21);
            this.bookID.TabIndex = 1;
            this.bookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInputOnly);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "ISBN书号";
            // 
            // delayedBooksInfo
            // 
            this.delayedBooksInfo.BackColor = System.Drawing.SystemColors.Control;
            this.delayedBooksInfo.Controls.Add(this.delayedBookSearch);
            this.delayedBooksInfo.Controls.Add(this.groupBox5);
            this.delayedBooksInfo.Location = new System.Drawing.Point(4, 22);
            this.delayedBooksInfo.Name = "delayedBooksInfo";
            this.delayedBooksInfo.Size = new System.Drawing.Size(791, 556);
            this.delayedBooksInfo.TabIndex = 2;
            this.delayedBooksInfo.Text = "逾期图书信息";
            // 
            // delayedBookSearch
            // 
            this.delayedBookSearch.Location = new System.Drawing.Point(338, 465);
            this.delayedBookSearch.Name = "delayedBookSearch";
            this.delayedBookSearch.Size = new System.Drawing.Size(75, 23);
            this.delayedBookSearch.TabIndex = 5;
            this.delayedBookSearch.Text = "查询";
            this.delayedBookSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.delayedbookSearchResult);
            this.groupBox5.Location = new System.Drawing.Point(30, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(701, 428);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "查询结果";
            // 
            // delayedbookSearchResult
            // 
            this.delayedbookSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delayedbookSearchResult.Location = new System.Drawing.Point(3, 14);
            this.delayedbookSearchResult.Name = "delayedbookSearchResult";
            this.delayedbookSearchResult.RowTemplate.Height = 23;
            this.delayedbookSearchResult.Size = new System.Drawing.Size(692, 408);
            this.delayedbookSearchResult.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "查询&管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookSearchResult)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.readerInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readerSearchResult)).EndInit();
            this.readerCondition.ResumeLayout(false);
            this.readerCondition.PerformLayout();
            this.allBooksInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.bookCondition.ResumeLayout(false);
            this.bookCondition.PerformLayout();
            this.delayedBooksInfo.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delayedbookSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage readerInfo;
        private System.Windows.Forms.GroupBox readerCondition;
        private System.Windows.Forms.TabPage allBooksInfo;
        private System.Windows.Forms.TabPage delayedBooksInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView readerSearchResult;
        private System.Windows.Forms.Button readerSearch;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox borrowid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox bookCondition;
        private System.Windows.Forms.Button bookSearch;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox press;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button delayedBookSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView delayedbookSearchResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox rBorrowedNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rCurNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.ComboBox borrowable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookTotalCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bookBorrowCount;
        private System.Windows.Forms.Button editReader;
        private System.Windows.Forms.Button deleteReader;
        private System.Windows.Forms.Button addReader;
        private System.Windows.Forms.Button editBook;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button returnBook;
        private System.Windows.Forms.Button borrowBook;
        private System.Windows.Forms.DataGridView bookSearchResult;
    }
}