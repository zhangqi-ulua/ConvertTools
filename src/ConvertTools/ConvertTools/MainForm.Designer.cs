namespace ConvertTools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RtxOriginal = new System.Windows.Forms.RichTextBox();
            this.GrpJson = new System.Windows.Forms.GroupBox();
            this.BtnJsonAntiPrettyPrint = new System.Windows.Forms.Button();
            this.BtnJsonToPrettyPrint = new System.Windows.Forms.Button();
            this.GrpUrl = new System.Windows.Forms.GroupBox();
            this.CboChooseEncodingForUrl = new System.Windows.Forms.ComboBox();
            this.BtnUrlDecode = new System.Windows.Forms.Button();
            this.BtnUrlEncode = new System.Windows.Forms.Button();
            this.RtxResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpUnicode = new System.Windows.Forms.GroupBox();
            this.BtnUnicodeDecode = new System.Windows.Forms.Button();
            this.BtnUnicodeEncode = new System.Windows.Forms.Button();
            this.GrpBase64 = new System.Windows.Forms.GroupBox();
            this.CboChooseEncodingForBase64 = new System.Windows.Forms.ComboBox();
            this.BtnBase64Decode = new System.Windows.Forms.Button();
            this.BtnBase64Encode = new System.Windows.Forms.Button();
            this.BtnCopyToClipboard = new System.Windows.Forms.Button();
            this.GrpHash = new System.Windows.Forms.GroupBox();
            this.BtnSHA256 = new System.Windows.Forms.Button();
            this.CboChooseEncodingForHash = new System.Windows.Forms.ComboBox();
            this.ChkToLower = new System.Windows.Forms.CheckBox();
            this.BtnSHA1 = new System.Windows.Forms.Button();
            this.BtnMD5 = new System.Windows.Forms.Button();
            this.GrpTimestamp = new System.Windows.Forms.GroupBox();
            this.BtnToTimestamp = new System.Windows.Forms.Button();
            this.BtnToSecondTimestamp = new System.Windows.Forms.Button();
            this.CboChooseUnitForToTimestamp = new System.Windows.Forms.ComboBox();
            this.TxtInputTimeString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTimestampToString = new System.Windows.Forms.Button();
            this.TxtInputTimestamp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrpTimeSpan = new System.Windows.Forms.GroupBox();
            this.BtnCalaulateTimeSpan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DptEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DptStart = new System.Windows.Forms.DateTimePicker();
            this.ChkAutoCopyResultToCipboard = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChkIsCRLF = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblOriginalTextLength = new System.Windows.Forms.Label();
            this.LblResultTextLength = new System.Windows.Forms.Label();
            this.GrpJson.SuspendLayout();
            this.GrpUrl.SuspendLayout();
            this.GrpUnicode.SuspendLayout();
            this.GrpBase64.SuspendLayout();
            this.GrpHash.SuspendLayout();
            this.GrpTimestamp.SuspendLayout();
            this.GrpTimeSpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // RtxOriginal
            // 
            this.RtxOriginal.Location = new System.Drawing.Point(474, 45);
            this.RtxOriginal.Name = "RtxOriginal";
            this.RtxOriginal.Size = new System.Drawing.Size(419, 815);
            this.RtxOriginal.TabIndex = 0;
            this.RtxOriginal.Text = "";
            this.RtxOriginal.TextChanged += new System.EventHandler(this.RtxOriginal_TextChanged);
            // 
            // GrpJson
            // 
            this.GrpJson.Controls.Add(this.BtnJsonAntiPrettyPrint);
            this.GrpJson.Controls.Add(this.BtnJsonToPrettyPrint);
            this.GrpJson.Location = new System.Drawing.Point(19, 18);
            this.GrpJson.Name = "GrpJson";
            this.GrpJson.Size = new System.Drawing.Size(288, 83);
            this.GrpJson.TabIndex = 1;
            this.GrpJson.TabStop = false;
            this.GrpJson.Text = "Json相关";
            // 
            // BtnJsonAntiPrettyPrint
            // 
            this.BtnJsonAntiPrettyPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnJsonAntiPrettyPrint.Location = new System.Drawing.Point(152, 27);
            this.BtnJsonAntiPrettyPrint.Name = "BtnJsonAntiPrettyPrint";
            this.BtnJsonAntiPrettyPrint.Size = new System.Drawing.Size(121, 35);
            this.BtnJsonAntiPrettyPrint.TabIndex = 3;
            this.BtnJsonAntiPrettyPrint.Text = "Json压缩";
            this.BtnJsonAntiPrettyPrint.UseVisualStyleBackColor = true;
            this.BtnJsonAntiPrettyPrint.Click += new System.EventHandler(this.BtnJsonAntiPrettyPrint_Click);
            // 
            // BtnJsonToPrettyPrint
            // 
            this.BtnJsonToPrettyPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnJsonToPrettyPrint.Location = new System.Drawing.Point(15, 27);
            this.BtnJsonToPrettyPrint.Name = "BtnJsonToPrettyPrint";
            this.BtnJsonToPrettyPrint.Size = new System.Drawing.Size(121, 35);
            this.BtnJsonToPrettyPrint.TabIndex = 2;
            this.BtnJsonToPrettyPrint.Text = "Json格式化";
            this.BtnJsonToPrettyPrint.UseVisualStyleBackColor = true;
            this.BtnJsonToPrettyPrint.Click += new System.EventHandler(this.BtnJsonToPrettyPrint_Click);
            // 
            // GrpUrl
            // 
            this.GrpUrl.Controls.Add(this.CboChooseEncodingForUrl);
            this.GrpUrl.Controls.Add(this.BtnUrlDecode);
            this.GrpUrl.Controls.Add(this.BtnUrlEncode);
            this.GrpUrl.Location = new System.Drawing.Point(19, 109);
            this.GrpUrl.Name = "GrpUrl";
            this.GrpUrl.Size = new System.Drawing.Size(435, 83);
            this.GrpUrl.TabIndex = 2;
            this.GrpUrl.TabStop = false;
            this.GrpUrl.Text = "URL编解码";
            // 
            // CboChooseEncodingForUrl
            // 
            this.CboChooseEncodingForUrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboChooseEncodingForUrl.FormattingEnabled = true;
            this.CboChooseEncodingForUrl.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.CboChooseEncodingForUrl.Location = new System.Drawing.Point(294, 34);
            this.CboChooseEncodingForUrl.Name = "CboChooseEncodingForUrl";
            this.CboChooseEncodingForUrl.Size = new System.Drawing.Size(121, 25);
            this.CboChooseEncodingForUrl.TabIndex = 3;
            // 
            // BtnUrlDecode
            // 
            this.BtnUrlDecode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUrlDecode.Location = new System.Drawing.Point(152, 27);
            this.BtnUrlDecode.Name = "BtnUrlDecode";
            this.BtnUrlDecode.Size = new System.Drawing.Size(121, 35);
            this.BtnUrlDecode.TabIndex = 5;
            this.BtnUrlDecode.Text = "URL解码";
            this.BtnUrlDecode.UseVisualStyleBackColor = true;
            this.BtnUrlDecode.Click += new System.EventHandler(this.BtnUrlDecode_Click);
            // 
            // BtnUrlEncode
            // 
            this.BtnUrlEncode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUrlEncode.Location = new System.Drawing.Point(15, 27);
            this.BtnUrlEncode.Name = "BtnUrlEncode";
            this.BtnUrlEncode.Size = new System.Drawing.Size(121, 35);
            this.BtnUrlEncode.TabIndex = 4;
            this.BtnUrlEncode.Text = "URL编码";
            this.BtnUrlEncode.UseVisualStyleBackColor = true;
            this.BtnUrlEncode.Click += new System.EventHandler(this.BtnUrlEncode_Click);
            // 
            // RtxResult
            // 
            this.RtxResult.Location = new System.Drawing.Point(911, 45);
            this.RtxResult.Name = "RtxResult";
            this.RtxResult.Size = new System.Drawing.Size(692, 815);
            this.RtxResult.TabIndex = 3;
            this.RtxResult.Text = "";
            this.RtxResult.TextChanged += new System.EventHandler(this.RtxResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "原始文本：          注意输入框中的回车默认算作\\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(911, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "转换之后：";
            // 
            // GrpUnicode
            // 
            this.GrpUnicode.Controls.Add(this.BtnUnicodeDecode);
            this.GrpUnicode.Controls.Add(this.BtnUnicodeEncode);
            this.GrpUnicode.Location = new System.Drawing.Point(19, 200);
            this.GrpUnicode.Name = "GrpUnicode";
            this.GrpUnicode.Size = new System.Drawing.Size(288, 83);
            this.GrpUnicode.TabIndex = 6;
            this.GrpUnicode.TabStop = false;
            this.GrpUnicode.Text = "Unicode编解码";
            // 
            // BtnUnicodeDecode
            // 
            this.BtnUnicodeDecode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUnicodeDecode.Location = new System.Drawing.Point(152, 31);
            this.BtnUnicodeDecode.Name = "BtnUnicodeDecode";
            this.BtnUnicodeDecode.Size = new System.Drawing.Size(121, 35);
            this.BtnUnicodeDecode.TabIndex = 7;
            this.BtnUnicodeDecode.Text = "Unicode解码";
            this.BtnUnicodeDecode.UseVisualStyleBackColor = true;
            this.BtnUnicodeDecode.Click += new System.EventHandler(this.BtnUnicodeDecode_Click);
            // 
            // BtnUnicodeEncode
            // 
            this.BtnUnicodeEncode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUnicodeEncode.Location = new System.Drawing.Point(15, 31);
            this.BtnUnicodeEncode.Name = "BtnUnicodeEncode";
            this.BtnUnicodeEncode.Size = new System.Drawing.Size(121, 35);
            this.BtnUnicodeEncode.TabIndex = 6;
            this.BtnUnicodeEncode.Text = "Unicode编码";
            this.BtnUnicodeEncode.UseVisualStyleBackColor = true;
            this.BtnUnicodeEncode.Click += new System.EventHandler(this.BtnUnicodeEncode_Click);
            // 
            // GrpBase64
            // 
            this.GrpBase64.Controls.Add(this.CboChooseEncodingForBase64);
            this.GrpBase64.Controls.Add(this.BtnBase64Decode);
            this.GrpBase64.Controls.Add(this.BtnBase64Encode);
            this.GrpBase64.Location = new System.Drawing.Point(19, 291);
            this.GrpBase64.Name = "GrpBase64";
            this.GrpBase64.Size = new System.Drawing.Size(435, 83);
            this.GrpBase64.TabIndex = 8;
            this.GrpBase64.TabStop = false;
            this.GrpBase64.Text = "Base64编解码";
            // 
            // CboChooseEncodingForBase64
            // 
            this.CboChooseEncodingForBase64.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboChooseEncodingForBase64.FormattingEnabled = true;
            this.CboChooseEncodingForBase64.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.CboChooseEncodingForBase64.Location = new System.Drawing.Point(294, 38);
            this.CboChooseEncodingForBase64.Name = "CboChooseEncodingForBase64";
            this.CboChooseEncodingForBase64.Size = new System.Drawing.Size(121, 25);
            this.CboChooseEncodingForBase64.TabIndex = 6;
            // 
            // BtnBase64Decode
            // 
            this.BtnBase64Decode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBase64Decode.Location = new System.Drawing.Point(152, 31);
            this.BtnBase64Decode.Name = "BtnBase64Decode";
            this.BtnBase64Decode.Size = new System.Drawing.Size(121, 35);
            this.BtnBase64Decode.TabIndex = 7;
            this.BtnBase64Decode.Text = "Base64解码";
            this.BtnBase64Decode.UseVisualStyleBackColor = true;
            this.BtnBase64Decode.Click += new System.EventHandler(this.BtnBase64Decode_Click);
            // 
            // BtnBase64Encode
            // 
            this.BtnBase64Encode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBase64Encode.Location = new System.Drawing.Point(15, 31);
            this.BtnBase64Encode.Name = "BtnBase64Encode";
            this.BtnBase64Encode.Size = new System.Drawing.Size(121, 35);
            this.BtnBase64Encode.TabIndex = 6;
            this.BtnBase64Encode.Text = "Base64编码";
            this.BtnBase64Encode.UseVisualStyleBackColor = true;
            this.BtnBase64Encode.Click += new System.EventHandler(this.BtnBase64Encode_Click);
            // 
            // BtnCopyToClipboard
            // 
            this.BtnCopyToClipboard.Location = new System.Drawing.Point(998, 15);
            this.BtnCopyToClipboard.Name = "BtnCopyToClipboard";
            this.BtnCopyToClipboard.Size = new System.Drawing.Size(99, 23);
            this.BtnCopyToClipboard.TabIndex = 9;
            this.BtnCopyToClipboard.Text = "复制到剪贴板";
            this.BtnCopyToClipboard.UseVisualStyleBackColor = true;
            this.BtnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
            // 
            // GrpHash
            // 
            this.GrpHash.Controls.Add(this.BtnSHA256);
            this.GrpHash.Controls.Add(this.CboChooseEncodingForHash);
            this.GrpHash.Controls.Add(this.ChkToLower);
            this.GrpHash.Controls.Add(this.BtnSHA1);
            this.GrpHash.Controls.Add(this.BtnMD5);
            this.GrpHash.Location = new System.Drawing.Point(19, 382);
            this.GrpHash.Name = "GrpHash";
            this.GrpHash.Size = new System.Drawing.Size(435, 131);
            this.GrpHash.TabIndex = 9;
            this.GrpHash.TabStop = false;
            this.GrpHash.Text = "常用散列算法";
            // 
            // BtnSHA256
            // 
            this.BtnSHA256.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSHA256.Location = new System.Drawing.Point(294, 31);
            this.BtnSHA256.Name = "BtnSHA256";
            this.BtnSHA256.Size = new System.Drawing.Size(121, 35);
            this.BtnSHA256.TabIndex = 9;
            this.BtnSHA256.Text = "SHA256加密";
            this.BtnSHA256.UseVisualStyleBackColor = true;
            this.BtnSHA256.Click += new System.EventHandler(this.BtnSHA256_Click);
            // 
            // CboChooseEncodingForHash
            // 
            this.CboChooseEncodingForHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboChooseEncodingForHash.FormattingEnabled = true;
            this.CboChooseEncodingForHash.Items.AddRange(new object[] {
            "UTF-8",
            "GBK"});
            this.CboChooseEncodingForHash.Location = new System.Drawing.Point(152, 84);
            this.CboChooseEncodingForHash.Name = "CboChooseEncodingForHash";
            this.CboChooseEncodingForHash.Size = new System.Drawing.Size(121, 25);
            this.CboChooseEncodingForHash.TabIndex = 8;
            // 
            // ChkToLower
            // 
            this.ChkToLower.AutoSize = true;
            this.ChkToLower.Location = new System.Drawing.Point(15, 86);
            this.ChkToLower.Name = "ChkToLower";
            this.ChkToLower.Size = new System.Drawing.Size(99, 21);
            this.ChkToLower.TabIndex = 8;
            this.ChkToLower.Text = "转为英文小写";
            this.ChkToLower.UseVisualStyleBackColor = true;
            // 
            // BtnSHA1
            // 
            this.BtnSHA1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSHA1.Location = new System.Drawing.Point(152, 31);
            this.BtnSHA1.Name = "BtnSHA1";
            this.BtnSHA1.Size = new System.Drawing.Size(121, 35);
            this.BtnSHA1.TabIndex = 7;
            this.BtnSHA1.Text = "SHA-1加密";
            this.BtnSHA1.UseVisualStyleBackColor = true;
            this.BtnSHA1.Click += new System.EventHandler(this.BtnSHA1_Click);
            // 
            // BtnMD5
            // 
            this.BtnMD5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMD5.Location = new System.Drawing.Point(15, 31);
            this.BtnMD5.Name = "BtnMD5";
            this.BtnMD5.Size = new System.Drawing.Size(121, 35);
            this.BtnMD5.TabIndex = 6;
            this.BtnMD5.Text = "MD5加密";
            this.BtnMD5.UseVisualStyleBackColor = true;
            this.BtnMD5.Click += new System.EventHandler(this.BtnMD5_Click);
            // 
            // GrpTimestamp
            // 
            this.GrpTimestamp.Controls.Add(this.BtnToTimestamp);
            this.GrpTimestamp.Controls.Add(this.BtnToSecondTimestamp);
            this.GrpTimestamp.Controls.Add(this.CboChooseUnitForToTimestamp);
            this.GrpTimestamp.Controls.Add(this.TxtInputTimeString);
            this.GrpTimestamp.Controls.Add(this.label4);
            this.GrpTimestamp.Controls.Add(this.BtnTimestampToString);
            this.GrpTimestamp.Controls.Add(this.TxtInputTimestamp);
            this.GrpTimestamp.Controls.Add(this.label3);
            this.GrpTimestamp.Location = new System.Drawing.Point(19, 522);
            this.GrpTimestamp.Name = "GrpTimestamp";
            this.GrpTimestamp.Size = new System.Drawing.Size(435, 187);
            this.GrpTimestamp.TabIndex = 10;
            this.GrpTimestamp.TabStop = false;
            this.GrpTimestamp.Text = "时间戳转换";
            // 
            // BtnToTimestamp
            // 
            this.BtnToTimestamp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToTimestamp.Location = new System.Drawing.Point(182, 132);
            this.BtnToTimestamp.Name = "BtnToTimestamp";
            this.BtnToTimestamp.Size = new System.Drawing.Size(106, 35);
            this.BtnToTimestamp.TabIndex = 14;
            this.BtnToTimestamp.Text = "毫秒时间戳";
            this.BtnToTimestamp.UseVisualStyleBackColor = true;
            this.BtnToTimestamp.Click += new System.EventHandler(this.BtnToTimestamp_Click);
            // 
            // BtnToSecondTimestamp
            // 
            this.BtnToSecondTimestamp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToSecondTimestamp.Location = new System.Drawing.Point(309, 132);
            this.BtnToSecondTimestamp.Name = "BtnToSecondTimestamp";
            this.BtnToSecondTimestamp.Size = new System.Drawing.Size(106, 35);
            this.BtnToSecondTimestamp.TabIndex = 13;
            this.BtnToSecondTimestamp.Text = "秒时间戳";
            this.BtnToSecondTimestamp.UseVisualStyleBackColor = true;
            this.BtnToSecondTimestamp.Click += new System.EventHandler(this.BtnToSecondTimestamp_Click);
            // 
            // CboChooseUnitForToTimestamp
            // 
            this.CboChooseUnitForToTimestamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboChooseUnitForToTimestamp.FormattingEnabled = true;
            this.CboChooseUnitForToTimestamp.Items.AddRange(new object[] {
            "毫秒",
            "秒"});
            this.CboChooseUnitForToTimestamp.Location = new System.Drawing.Point(174, 55);
            this.CboChooseUnitForToTimestamp.Name = "CboChooseUnitForToTimestamp";
            this.CboChooseUnitForToTimestamp.Size = new System.Drawing.Size(75, 25);
            this.CboChooseUnitForToTimestamp.TabIndex = 12;
            // 
            // TxtInputTimeString
            // 
            this.TxtInputTimeString.Location = new System.Drawing.Point(15, 139);
            this.TxtInputTimeString.Name = "TxtInputTimeString";
            this.TxtInputTimeString.Size = new System.Drawing.Size(137, 23);
            this.TxtInputTimeString.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "时间字符串（yyyy-MM-dd HH:mm:ss） 转 时间戳";
            // 
            // BtnTimestampToString
            // 
            this.BtnTimestampToString.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTimestampToString.Location = new System.Drawing.Point(294, 50);
            this.BtnTimestampToString.Name = "BtnTimestampToString";
            this.BtnTimestampToString.Size = new System.Drawing.Size(121, 35);
            this.BtnTimestampToString.TabIndex = 9;
            this.BtnTimestampToString.Text = "转时间字符串";
            this.BtnTimestampToString.UseVisualStyleBackColor = true;
            this.BtnTimestampToString.Click += new System.EventHandler(this.BtnTimestampToString_Click);
            // 
            // TxtInputTimestamp
            // 
            this.TxtInputTimestamp.Location = new System.Drawing.Point(15, 57);
            this.TxtInputTimestamp.Name = "TxtInputTimestamp";
            this.TxtInputTimestamp.Size = new System.Drawing.Size(137, 23);
            this.TxtInputTimestamp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "时间戳 转 时间字符串";
            // 
            // GrpTimeSpan
            // 
            this.GrpTimeSpan.Controls.Add(this.BtnCalaulateTimeSpan);
            this.GrpTimeSpan.Controls.Add(this.label6);
            this.GrpTimeSpan.Controls.Add(this.DptEnd);
            this.GrpTimeSpan.Controls.Add(this.label5);
            this.GrpTimeSpan.Controls.Add(this.DptStart);
            this.GrpTimeSpan.Location = new System.Drawing.Point(19, 718);
            this.GrpTimeSpan.Name = "GrpTimeSpan";
            this.GrpTimeSpan.Size = new System.Drawing.Size(435, 109);
            this.GrpTimeSpan.TabIndex = 11;
            this.GrpTimeSpan.TabStop = false;
            this.GrpTimeSpan.Text = "时间差计算";
            // 
            // BtnCalaulateTimeSpan
            // 
            this.BtnCalaulateTimeSpan.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalaulateTimeSpan.Location = new System.Drawing.Point(309, 43);
            this.BtnCalaulateTimeSpan.Name = "BtnCalaulateTimeSpan";
            this.BtnCalaulateTimeSpan.Size = new System.Drawing.Size(106, 35);
            this.BtnCalaulateTimeSpan.TabIndex = 15;
            this.BtnCalaulateTimeSpan.Text = "计算时间差";
            this.BtnCalaulateTimeSpan.UseVisualStyleBackColor = true;
            this.BtnCalaulateTimeSpan.Click += new System.EventHandler(this.BtnCalaulateTimeSpan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "结束时间：";
            // 
            // DptEnd
            // 
            this.DptEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DptEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DptEnd.Location = new System.Drawing.Point(99, 67);
            this.DptEnd.Name = "DptEnd";
            this.DptEnd.Size = new System.Drawing.Size(174, 23);
            this.DptEnd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "起始时间：";
            // 
            // DptStart
            // 
            this.DptStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DptStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DptStart.Location = new System.Drawing.Point(99, 31);
            this.DptStart.Name = "DptStart";
            this.DptStart.Size = new System.Drawing.Size(174, 23);
            this.DptStart.TabIndex = 0;
            // 
            // ChkAutoCopyResultToCipboard
            // 
            this.ChkAutoCopyResultToCipboard.AutoSize = true;
            this.ChkAutoCopyResultToCipboard.Checked = true;
            this.ChkAutoCopyResultToCipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAutoCopyResultToCipboard.Location = new System.Drawing.Point(118, 843);
            this.ChkAutoCopyResultToCipboard.Name = "ChkAutoCopyResultToCipboard";
            this.ChkAutoCopyResultToCipboard.Size = new System.Drawing.Size(207, 21);
            this.ChkAutoCopyResultToCipboard.TabIndex = 12;
            this.ChkAutoCopyResultToCipboard.Text = "将转换后的结果直接复制到剪贴板";
            this.ChkAutoCopyResultToCipboard.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 843);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "工具选项：";
            // 
            // ChkIsCRLF
            // 
            this.ChkIsCRLF.AutoSize = true;
            this.ChkIsCRLF.Location = new System.Drawing.Point(118, 873);
            this.ChkIsCRLF.Name = "ChkIsCRLF";
            this.ChkIsCRLF.Size = new System.Drawing.Size(157, 21);
            this.ChkIsCRLF.TabIndex = 14;
            this.ChkIsCRLF.Text = "将输入框中的\\n转为\\r\\n";
            this.ChkIsCRLF.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 877);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "字符数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(911, 877);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "字符数：";
            // 
            // LblOriginalTextLength
            // 
            this.LblOriginalTextLength.AutoSize = true;
            this.LblOriginalTextLength.Location = new System.Drawing.Point(536, 877);
            this.LblOriginalTextLength.Name = "LblOriginalTextLength";
            this.LblOriginalTextLength.Size = new System.Drawing.Size(15, 17);
            this.LblOriginalTextLength.TabIndex = 17;
            this.LblOriginalTextLength.Text = "0";
            // 
            // LblResultTextLength
            // 
            this.LblResultTextLength.AutoSize = true;
            this.LblResultTextLength.Location = new System.Drawing.Point(973, 877);
            this.LblResultTextLength.Name = "LblResultTextLength";
            this.LblResultTextLength.Size = new System.Drawing.Size(15, 17);
            this.LblResultTextLength.TabIndex = 18;
            this.LblResultTextLength.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 903);
            this.Controls.Add(this.LblResultTextLength);
            this.Controls.Add(this.LblOriginalTextLength);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChkIsCRLF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChkAutoCopyResultToCipboard);
            this.Controls.Add(this.GrpTimeSpan);
            this.Controls.Add(this.GrpTimestamp);
            this.Controls.Add(this.GrpHash);
            this.Controls.Add(this.BtnCopyToClipboard);
            this.Controls.Add(this.GrpBase64);
            this.Controls.Add(this.GrpUnicode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RtxResult);
            this.Controls.Add(this.GrpUrl);
            this.Controls.Add(this.GrpJson);
            this.Controls.Add(this.RtxOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编解码转换工具集合 by 张齐 （http://github.com/zhangqi-ulua）";
            this.GrpJson.ResumeLayout(false);
            this.GrpUrl.ResumeLayout(false);
            this.GrpUnicode.ResumeLayout(false);
            this.GrpBase64.ResumeLayout(false);
            this.GrpHash.ResumeLayout(false);
            this.GrpHash.PerformLayout();
            this.GrpTimestamp.ResumeLayout(false);
            this.GrpTimestamp.PerformLayout();
            this.GrpTimeSpan.ResumeLayout(false);
            this.GrpTimeSpan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RtxOriginal;
        private GroupBox GrpJson;
        private Button BtnJsonAntiPrettyPrint;
        private Button BtnJsonToPrettyPrint;
        private GroupBox GrpUrl;
        private ComboBox CboChooseEncodingForUrl;
        private Button BtnUrlDecode;
        private Button BtnUrlEncode;
        private RichTextBox RtxResult;
        private Label label1;
        private Label label2;
        private GroupBox GrpUnicode;
        private Button BtnUnicodeDecode;
        private Button BtnUnicodeEncode;
        private GroupBox GrpBase64;
        private Button BtnBase64Decode;
        private Button BtnBase64Encode;
        private Button BtnCopyToClipboard;
        private GroupBox GrpHash;
        private CheckBox ChkToLower;
        private Button BtnSHA1;
        private Button BtnMD5;
        private GroupBox GrpTimestamp;
        private TextBox TxtInputTimeString;
        private Label label4;
        private Button BtnTimestampToString;
        private TextBox TxtInputTimestamp;
        private Label label3;
        private ComboBox CboChooseUnitForToTimestamp;
        private Button BtnToTimestamp;
        private Button BtnToSecondTimestamp;
        private GroupBox GrpTimeSpan;
        private DateTimePicker DptStart;
        private Label label5;
        private Button BtnCalaulateTimeSpan;
        private Label label6;
        private DateTimePicker DptEnd;
        private CheckBox ChkAutoCopyResultToCipboard;
        private Label label7;
        private CheckBox ChkIsCRLF;
        private Label label8;
        private Label label9;
        private Label LblOriginalTextLength;
        private Label LblResultTextLength;
        private ComboBox CboChooseEncodingForBase64;
        private Button BtnSHA256;
        private ComboBox CboChooseEncodingForHash;
    }
}