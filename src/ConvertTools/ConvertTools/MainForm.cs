using ConvertTools.Utils;
using System.Text;

namespace ConvertTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // 初始化支持GB2312编码
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // 编码选择框默认选第1项
            CboChooseEncoding.SelectedIndex = 0;

            DateTime now = DateTime.Now;
            // 默认填入当前毫秒时间戳和时间字符串
            TxtInputTimestamp.Text = DateTimeUtil.DateTimeToTimestamp(now).ToString();
            TxtInputTimeString.Text = DateTimeUtil.DateTimeToLongDateString(now);
            // 时间戳单位默认选第1项
            CboChooseUnitForToTimestamp.SelectedIndex = 0;
        }

        private void BtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RtxResult.Text);
        }

        #region Json相关

        private void BtnJsonToPrettyPrint_Click(object sender, EventArgs e)
        {
            string inputJson = RtxOriginal.Text;
            bool isJsonError;
            string jsonResult = JsonUtil.ToPrettyPrint(inputJson, out isJsonError);
            if (isJsonError == true)
                MessageBox.Show(this, "Json解析失败，请修正Json格式错误后重试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RtxResult.Text = jsonResult;
                if (ChkAutoCopyResultToCipboard.Checked == true)
                    Clipboard.SetText(RtxResult.Text);
            }
        }

        private void BtnJsonAntiPrettyPrint_Click(object sender, EventArgs e)
        {
            string inputJson = RtxOriginal.Text;
            bool isJsonError;
            string jsonResult = JsonUtil.AntiPrettyPrint(inputJson, out isJsonError);
            if (isJsonError == true)
                MessageBox.Show(this, "Json解析失败，请修正Json格式错误后重试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RtxResult.Text = jsonResult;
                if (ChkAutoCopyResultToCipboard.Checked == true)
                    Clipboard.SetText(RtxResult.Text);
            }
        }

        #endregion

        #region URL编解码

        private void BtnUrlEncode_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(CboChooseEncoding.SelectedItem.ToString());
            string inputString = ChkIsCRLF.Checked == true ? RtxOriginal.Text.Replace("\n", "\r\n") : RtxOriginal.Text;
            RtxResult.Text = EncodeUtil.UrlEncode(inputString, encoding);
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        private void BtnUrlDecode_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(CboChooseEncoding.SelectedItem.ToString());
            RtxResult.Text = EncodeUtil.UrlDecode(RtxOriginal.Text, encoding);
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion

        #region Unicode编解码

        private void BtnUnicodeEncode_Click(object sender, EventArgs e)
        {
            string inputString = ChkIsCRLF.Checked == true ? RtxOriginal.Text.Replace("\n", "\r\n") : RtxOriginal.Text;
            RtxResult.Text = EncodeUtil.UnicodeEncode(inputString);
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        private void BtnUnicodeDecode_Click(object sender, EventArgs e)
        {
            RtxResult.Text = EncodeUtil.UnicodeDecode(RtxOriginal.Text);
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion

        #region Base64编解码

        private void BtnBase64Encode_Click(object sender, EventArgs e)
        {
            string inputString = ChkIsCRLF.Checked == true ? RtxOriginal.Text.Replace("\n", "\r\n") : RtxOriginal.Text;
            RtxResult.Text = EncodeUtil.Base64Encode(inputString);
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        private void BtnBase64Decode_Click(object sender, EventArgs e)
        {
            RtxResult.Text = EncodeUtil.Base64Decode(RtxOriginal.Text);
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion

        #region 常用散列算法

        private void BtnMD5_Click(object sender, EventArgs e)
        {
            string inputString = ChkIsCRLF.Checked == true ? RtxOriginal.Text.Replace("\n", "\r\n") : RtxOriginal.Text;
            string md5Result = EncodeUtil.MD5Encrypt(inputString);
            RtxResult.Text = ChkToLower.Checked == true ? md5Result.ToLower() : md5Result;
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        private void BtnSHA1_Click(object sender, EventArgs e)
        {
            string inputString = ChkIsCRLF.Checked == true ? RtxOriginal.Text.Replace("\n", "\r\n") : RtxOriginal.Text;
            string sha1Result = EncodeUtil.SHA1Encrypt(inputString);
            RtxResult.Text = ChkToLower.Checked == true ? sha1Result.ToLower() : sha1Result;
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion

        #region 时间戳转换

        private void BtnTimestampToString_Click(object sender, EventArgs e)
        {
            string inputTimestampString = TxtInputTimestamp.Text.Trim();
            long timestamp;
            if (long.TryParse(inputTimestampString, out timestamp) == false)
            {
                MessageBox.Show(this, "输入的时间戳不是合法数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timestamp < 0)
            {
                MessageBox.Show(this, "输入的时间戳不能小于0", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CboChooseUnitForToTimestamp.SelectedItem.ToString() == "毫秒")
            {
                RtxResult.Text = DateTimeUtil.TimestampToLongDateString(timestamp);
                if (ChkAutoCopyResultToCipboard.Checked == true)
                    Clipboard.SetText(RtxResult.Text);
            }
            else
            {
                if (timestamp > int.MaxValue)
                {
                    MessageBox.Show(this, "输入的秒时间戳超过上限，请确认是否为毫秒时间戳", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int timestampSecond = (int)timestamp;
                RtxResult.Text = DateTimeUtil.TimestampSecondToLongDateString(timestampSecond);
                if (ChkAutoCopyResultToCipboard.Checked == true)
                    Clipboard.SetText(RtxResult.Text);
            }
        }

        private void BtnToTimestamp_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            try
            {
                dateTime = Convert.ToDateTime(TxtInputTimeString.Text.Trim());
            }
            catch
            {
                MessageBox.Show(this, "输入的时间格式错误，请按yyyy-MM-dd HH:mm:ss", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RtxResult.Text = DateTimeUtil.DateTimeToTimestamp(dateTime).ToString();
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        private void BtnToSecondTimestamp_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            try
            {
                dateTime = Convert.ToDateTime(TxtInputTimeString.Text.Trim());
            }
            catch
            {
                MessageBox.Show(this, "输入的时间格式错误，请按yyyy-MM-dd HH:mm:ss", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RtxResult.Text = DateTimeUtil.DateTimeToTimestampSecond(dateTime).ToString();
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion

        #region 计算时间差

        private void BtnCalaulateTimeSpan_Click(object sender, EventArgs e)
        {
            DateTime start = DptStart.Value;
            DateTime end = DptEnd.Value;
            // 需要去掉毫秒数，否则因为在WinForm的Designer.cs中因为先生成的DptEnd，导致其读取的Value毫秒数比DptStart小
            start = new DateTime(start.Year, start.Month, start.Day, start.Hour, start.Minute, start.Second, 0);
            end = new DateTime(end.Year, end.Month, end.Day, end.Hour, end.Minute, end.Second, 0);
            if (start > end)
            {
                if (DialogResult.No == MessageBox.Show(this, "输入的开始时间晚于结束时间，是否自动将它们交换后计算？\n点击“是”交换后计算，点击“否”取消操作", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;
                else
                {
                    DateTime temp = start;
                    start = end;
                    end = temp;
                }
            }
            TimeSpan timeSpan = end - start;
            StringBuilder sb = new StringBuilder();
            long totalSecond = (long)timeSpan.TotalSeconds;
            long remainSecond = totalSecond;
            long day = remainSecond / (60 * 60 * 24);
            remainSecond -= day * (60 * 60 * 24);
            long hour = remainSecond / (60 * 60);
            remainSecond -= hour * (60 * 60);
            long minute = remainSecond / 60;
            remainSecond -= minute * 60;
            sb.AppendLine($"时间差：{day}天{hour}时{minute}分{remainSecond}秒");
            sb.AppendLine($"总秒数相差：{totalSecond}秒");
            RtxResult.Text = sb.ToString();
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion
    }
}