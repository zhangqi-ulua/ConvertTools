using ConvertTools.Utils;
using System.Text;

namespace ConvertTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // ��ʼ��֧��GB2312����
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // ����ѡ���Ĭ��ѡ��1��
            CboChooseEncoding.SelectedIndex = 0;

            DateTime now = DateTime.Now;
            // Ĭ�����뵱ǰ����ʱ�����ʱ���ַ���
            TxtInputTimestamp.Text = DateTimeUtil.DateTimeToTimestamp(now).ToString();
            TxtInputTimeString.Text = DateTimeUtil.DateTimeToLongDateString(now);
            // ʱ�����λĬ��ѡ��1��
            CboChooseUnitForToTimestamp.SelectedIndex = 0;
        }

        private void BtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RtxResult.Text);
        }

        #region Json���

        private void BtnJsonToPrettyPrint_Click(object sender, EventArgs e)
        {
            string inputJson = RtxOriginal.Text;
            bool isJsonError;
            string jsonResult = JsonUtil.ToPrettyPrint(inputJson, out isJsonError);
            if (isJsonError == true)
                MessageBox.Show(this, "Json����ʧ�ܣ�������Json��ʽ���������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "Json����ʧ�ܣ�������Json��ʽ���������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RtxResult.Text = jsonResult;
                if (ChkAutoCopyResultToCipboard.Checked == true)
                    Clipboard.SetText(RtxResult.Text);
            }
        }

        #endregion

        #region URL�����

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

        #region Unicode�����

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

        #region Base64�����

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

        #region ����ɢ���㷨

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

        #region ʱ���ת��

        private void BtnTimestampToString_Click(object sender, EventArgs e)
        {
            string inputTimestampString = TxtInputTimestamp.Text.Trim();
            long timestamp;
            if (long.TryParse(inputTimestampString, out timestamp) == false)
            {
                MessageBox.Show(this, "�����ʱ������ǺϷ�����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timestamp < 0)
            {
                MessageBox.Show(this, "�����ʱ�������С��0", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CboChooseUnitForToTimestamp.SelectedItem.ToString() == "����")
            {
                RtxResult.Text = DateTimeUtil.TimestampToLongDateString(timestamp);
                if (ChkAutoCopyResultToCipboard.Checked == true)
                    Clipboard.SetText(RtxResult.Text);
            }
            else
            {
                if (timestamp > int.MaxValue)
                {
                    MessageBox.Show(this, "�������ʱ����������ޣ���ȷ���Ƿ�Ϊ����ʱ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "�����ʱ���ʽ�����밴yyyy-MM-dd HH:mm:ss", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "�����ʱ���ʽ�����밴yyyy-MM-dd HH:mm:ss", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RtxResult.Text = DateTimeUtil.DateTimeToTimestampSecond(dateTime).ToString();
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion

        #region ����ʱ���

        private void BtnCalaulateTimeSpan_Click(object sender, EventArgs e)
        {
            DateTime start = DptStart.Value;
            DateTime end = DptEnd.Value;
            // ��Ҫȥ����������������Ϊ��WinForm��Designer.cs����Ϊ�����ɵ�DptEnd���������ȡ��Value��������DptStartС
            start = new DateTime(start.Year, start.Month, start.Day, start.Hour, start.Minute, start.Second, 0);
            end = new DateTime(end.Year, end.Month, end.Day, end.Hour, end.Minute, end.Second, 0);
            if (start > end)
            {
                if (DialogResult.No == MessageBox.Show(this, "����Ŀ�ʼʱ�����ڽ���ʱ�䣬�Ƿ��Զ������ǽ�������㣿\n������ǡ���������㣬�������ȡ������", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
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
            sb.AppendLine($"ʱ��{day}��{hour}ʱ{minute}��{remainSecond}��");
            sb.AppendLine($"��������{totalSecond}��");
            RtxResult.Text = sb.ToString();
            if (ChkAutoCopyResultToCipboard.Checked == true)
                Clipboard.SetText(RtxResult.Text);
        }

        #endregion
    }
}