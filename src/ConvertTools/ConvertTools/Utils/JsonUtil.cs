using Newtonsoft.Json;

namespace ConvertTools.Utils
{
    internal class JsonUtil
    {
        public static string ToPrettyPrint(string json, out bool isJsonError)
        {
            TextReader textReader = new StringReader(json);
            JsonTextReader jsonTextReader = new JsonTextReader(textReader);

            JsonSerializer jsonSerializer = new JsonSerializer();
            object obj = null;
            try
            {
                obj = jsonSerializer.Deserialize(jsonTextReader);
                if (obj == null)
                {
                    isJsonError = true;
                    return null;
                }
            }
            catch
            {
                isJsonError = true;
                return null;
            }

            StringWriter stringWriter = new StringWriter();
            JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
            jsonTextWriter.Formatting = Formatting.Indented;
            jsonTextWriter.IndentChar = ' ';
            jsonTextWriter.Indentation = 4;

            jsonSerializer.Serialize(jsonTextWriter, obj);
            isJsonError = false;
            return stringWriter.ToString();
        }

        public static string AntiPrettyPrint(string json, out bool isJsonError)
        {
            TextReader textReader = new StringReader(json);
            JsonTextReader jsonTextReader = new JsonTextReader(textReader);

            JsonSerializer jsonSerializer = new JsonSerializer();
            object obj = null;
            try
            {
                obj = jsonSerializer.Deserialize(jsonTextReader);
                if (obj == null)
                {
                    isJsonError = true;
                    return null;
                }
            }
            catch
            {
                isJsonError = true;
                return null;
            }

            StringWriter stringWriter = new StringWriter();
            JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
            jsonTextWriter.Formatting = Formatting.None;

            jsonSerializer.Serialize(jsonTextWriter, obj);
            isJsonError = false;
            return stringWriter.ToString();
        }
    }
}
