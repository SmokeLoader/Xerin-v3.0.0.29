using System.Text;

namespace KoiVM.Core.AST;

public class ASTConstant : ASTExpression
{
	public object Value { get; set; }

	public static void EscapeString(StringBuilder sb, string s, bool addQuotes)
	{
		if (s == null)
		{
			sb.Append("null");
			return;
		}
		if (addQuotes)
		{
			sb.Append('"');
		}
		foreach (char c in s)
		{
			if (c < ' ')
			{
				switch (c)
				{
				case '\a':
					sb.Append("\\a");
					break;
				case '\b':
					sb.Append("\\b");
					break;
				case '\f':
					sb.Append("\\f");
					break;
				case '\n':
					sb.Append("\\n");
					break;
				case '\r':
					sb.Append("\\r");
					break;
				case '\t':
					sb.Append("\\t");
					break;
				case '\v':
					sb.Append("\\v");
					break;
				default:
					sb.Append($"\\u{(int)c:X4}");
					break;
				}
			}
			else if (c == '\\' || c == '"')
			{
				sb.Append('\\');
				sb.Append(c);
			}
			else
			{
				sb.Append(c);
			}
		}
		if (addQuotes)
		{
			sb.Append('"');
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Value == null)
		{
			stringBuilder.Append("<<<NULL>>>");
		}
		else if (Value is string)
		{
			EscapeString(stringBuilder, (string)Value, addQuotes: true);
		}
		else
		{
			stringBuilder.Append(Value);
		}
		return stringBuilder.ToString();
	}
}
