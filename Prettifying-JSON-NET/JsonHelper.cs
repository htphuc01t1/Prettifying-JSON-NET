using System.Text;

namespace Prettifying_JSON_NET
{
    class JsonHelper
    {
        public static string Indent = "    ";

        public static string FormatJson(string jsonString)
        {
            var output = new StringBuilder(jsonString.Length * 2);
            char? quote = null;
            int depth = 0;

            for (int i = 0; i < jsonString.Length; ++i)
            {
                char charactor = jsonString[i];

                switch (charactor)
                {
                    case '{':
                    case '[':
                        output.Append(charactor);
                        if (!quote.HasValue)
                        {
                            output.AppendLine();
                            output.Append(Indent.Repeat(++depth));
                        }
                        break;
                    case '}':
                    case ']':
                        if (quote.HasValue)
                            output.Append(charactor);
                        else
                        {
                            output.AppendLine();
                            output.Append(Indent.Repeat(--depth));
                            output.Append(charactor);
                        }
                        break;
                    case '"':
                    case '\'':
                        output.Append(charactor);
                        if (quote.HasValue)
                        {
                            if (!output.IsEscaped(i))
                                quote = null;
                        }
                        else quote = charactor;
                        break;
                    case ',':
                        output.Append(charactor);
                        if (!quote.HasValue)
                        {
                            output.AppendLine();
                            output.Append(Indent.Repeat(depth));
                        }
                        break;
                    case ':':
                        if (quote.HasValue) output.Append(charactor);
                        else output.Append(" : ");
                        break;
                    default:
                        if (quote.HasValue || !char.IsWhiteSpace(charactor))
                            output.Append(charactor);
                        break;
                }
            }
            return output.ToString();
        }
    }
}

static class Extensions
{
    public static bool IsEscaped(this string str, int index)
    {
        bool escaped = false;
        while (index > 0 && str[--index] == '\\') escaped = !escaped;
        return escaped;
    }
    public static string Repeat(this string str, int count)
    {
        return new StringBuilder().Insert(0, str, count).ToString();
    }   

    public static bool IsEscaped(this StringBuilder str, int index)
    {
        return str.ToString().IsEscaped(index);
    }
}
