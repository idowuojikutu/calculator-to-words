# Unity-Facebook-Soscial-Share
Developer: Anthony A. Castor

This Source does not give any warranty please use at your own risk </br>

Calculator: Number to Words Application that will output any number to words </br>

This application is free of virus or malware </br>

<h3>Software Requirment </h3>
Unity 5.6<br/>
Unity C#<br/>

<h3>Online Portfolio</h3>
Distribution itch(Web and Desktop): https://goo.gl/Wq1nuD </br>
Distribution Google Play: https://goo.gl/uKIIr4 </br>
Distribution Itunes AppStore: https://goo.gl/54yJPi </br>
Distribution Amazon Store: https://goo.gl/RUp1Od </br>
Distribution Windows Store: https://goo.gl/rCxsH6   (No Direct link to Dev Page) </br>
Distribution WearVR: https://goo.gl/y0X1nR  (No Direct link to Dev Page) </br>

<h3>More Information and Demo Videos </h3>
Facebook: https://goo.gl/vvDSIL </br>
Linkedin: https://goo.gl/c9Fh6n </br>
YouTube: https://goo.gl/BFZ7C5 </br>
StackOverFlow: https://goo.gl/J1hFqL </br>
Github: https://goo.gl/jPHFPe </br>


<h3>Application Functions</h3>
Calculator </br>
Convert Number into Word </br>


<h3>Source Code</h3>

	//Calulation to Words
	public string DecimalToWords(decimal number)
	{
		if (number == 0)
			return "zero";

		if (number < 0)
			return "minus " + DecimalToWords(Math.Abs(number));

		string words = "";

		long intPortion = (long)number;
		decimal fraction = (number - intPortion)*100;
		long decPortion = (long)fraction;

		words = NumberToWords(intPortion);
		if (decPortion > 0)
		{
			words += " and ";
			words += NumberToWords(decPortion);
		}
		return words;
	}

	public static string NumberToWords(long number)
	{
		if (number == 0)
			return "zero";

		if (number < 0)
			return "minus " + NumberToWords(Math.Abs(number));

		string words = "";

		if ((number / 1000000000000) > 0)
		{
			words += NumberToWords(number / 1000000000000) + " trillion ";
			number %= 1000000000000;
		}

		if ((number / 1000000000) > 0)
		{
			words += NumberToWords(number / 1000000000) + " billion ";
			number %= 1000000000;
		}

		if ((number / 1000000) > 0)
		{
			words += NumberToWords(number / 1000000) + " million ";
			number %= 1000000;
		}

		if ((number / 1000) > 0)
		{
			words += NumberToWords(number / 1000) + " thousand ";
			number %= 1000;
		}

		if ((number / 100) > 0)
		{
			words += NumberToWords(number / 100) + " hundred ";
			number %= 100;
		}

		if (number > 0)
		{
			if (words != "")
				words += "and ";

			var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
			var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

			if (number < 20)
				words += unitsMap[number];
			else
			{
				words += tensMap[number / 10];
				if ((number % 10) > 0)
					words += "-" + unitsMap[number % 10];
			}
		}

		return words;
	}

<h3>Screenshot</h3>

![alt text](screenshots/1.png "Scene1")
![alt text](screenshots/2.png "Scene2")
![alt text](screenshots/3.png "Scene3")