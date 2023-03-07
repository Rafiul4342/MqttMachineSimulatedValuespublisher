using System;

public class Status
{

	public string status { get; set; } = string.Empty;
	public int i { get; set; } = 0;

	public string stringGetStatus()
	{
		if (i >= 0 && i < 200)
		{
			status = "on";
			i = i + 1;
			return status;
		}
		else if (i >= 200 && i <= 300)
		{
			status = "off";
			i = i + 1;
			if(i == 300)
			{
				i = 0;
			}
            return status;
        }
		return string.Empty;
	}
}
		
	

