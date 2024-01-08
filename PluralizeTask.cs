namespace Pluralize;

public static class PluralizeTask
{
	public static string PluralizeRubles(int count)
	{
		if ((count == 1 || count % 10 == 1) && count % 100 != 11)
		{
			return "рубль";
        }
		else if ((count > 1 && count <= 4) || (count % 10 > 1 && count % 10 <= 4))
		{
			if (count % 100 != 12 && count % 100 != 13 && count % 100 != 14)
			{
                return "рубля";
            }

            return "рублей";
        }
		else
		{
			return "рублей";
		}
	}
}