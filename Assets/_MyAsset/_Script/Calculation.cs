using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculation : MonoBehaviour {

	public InputField NumberToWord;
	public InputField NumbersOutPut;
	public InputField NumbersInX;
	public InputField NumbersInY;

	private double _InputData1, _InputData2, _SumTotal;
	private string _Formula;
	private bool _isErase,_isSignPress;

	public void Start(){
		NumberToWord.text = "Zero";
		NumbersOutPut.text = 0 + "";
		_InputData1 = _InputData2 = _SumTotal = 0;

		Screen.SetResolution(640, 960, false);
	}

	public void Update(){
		Screen.SetResolution(640, 960, false);
	}

	public void Number1(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 1 + "";
				NumbersInX.text = 1 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 1 + "";
				NumbersInX.text = NumbersInX.text + 1 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 1 + "";
				NumbersInY.text = 1 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 1 + "";
				NumbersInY.text = NumbersInY.text + 1 + "";
			}
		}
	}

	public void Number2(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 2 + "";
				NumbersInX.text = 2 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 2 + "";
				NumbersInX.text = NumbersInX.text + 2 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 2 + "";
				NumbersInY.text = 2 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 2 + "";
				NumbersInY.text = NumbersInY.text + 2 + "";
			}
		}
	}

	public void Number3(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 3 + "";
				NumbersInX.text = 3 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 3 + "";
				NumbersInX.text = NumbersInX.text + 3 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 3 + "";
				NumbersInY.text = 3 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 3 + "";
				NumbersInY.text = NumbersInY.text + 3 + "";
			}
		}
	}

	public void Number4(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 4 + "";
				NumbersInX.text = 4 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 4 + "";
				NumbersInX.text = NumbersInX.text + 4 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 4 + "";
				NumbersInY.text = 4 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 4 + "";
				NumbersInY.text = NumbersInY.text + 4 + "";
			}
		}
	}

	public void Number5(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 5 + "";
				NumbersInX.text = 5 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 5 + "";
				NumbersInX.text = NumbersInX.text + 5 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 5 + "";
				NumbersInY.text = 5 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 5 + "";
				NumbersInY.text = NumbersInY.text + 5 + "";
			}
		}
	}

	public void Number6(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 6 + "";
				NumbersInX.text = 6 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 6 + "";
				NumbersInX.text = NumbersInX.text + 6 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 6 + "";
				NumbersInY.text = 6 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 6 + "";
				NumbersInY.text = NumbersInY.text + 6 + "";
			}
		}
	}

	public void Number7(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 7 + "";
				NumbersInX.text = 7 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 7 + "";
				NumbersInX.text = NumbersInX.text + 7 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 7 + "";
				NumbersInY.text = 7 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 7 + "";
				NumbersInY.text = NumbersInY.text + 7 + "";
			}
		}
	}

	public void Number8(){

		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 8 + "";
				NumbersInX.text = 8 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 8 + "";
				NumbersInX.text = NumbersInX.text + 8 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 8 + "";
				NumbersInY.text = 8 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 8 + "";
				NumbersInY.text = NumbersInY.text + 8 + "";
			}
		}
	}

	public void Number9(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 9 + "";
				NumbersInX.text = 9 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 9 + "";
				NumbersInX.text = NumbersInX.text + 9 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 9 + "";
				NumbersInY.text = 9 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 9 + "";
				NumbersInY.text = NumbersInY.text + 9 + "";
			}
		}
	}

	public void Number0(){
		if (_isSignPress == false) {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 0 + "";
				NumbersInX.text = 0 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 0 + "";
				NumbersInX.text = NumbersInX.text + 0 + "";
			}
		} else {
			if (NumbersOutPut.text == "0" || _isErase == true) {
				NumbersOutPut.text = 0 + "";
				NumbersInY.text = 0 + "";
				_isErase = false;
			} else {
				NumbersOutPut.text = NumbersOutPut.text + 0 + "";
				NumbersInY.text = NumbersInY.text + 0 + "";
			}
		}
	}

	public void NumberDot(){
		if (NumbersOutPut.text == "0") {
			NumbersOutPut.text =  0 + ".";
		} else {
			NumbersOutPut.text = NumbersOutPut.text + ".";
		}

	}

	public void Add(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);

		NumbersOutPut.text = NumbersOutPut.text+" + ";
		//NumberToWord.text = "Zero";
		_Formula = "ADD";
		_isSignPress = true;
	}

	public void Sub(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);

		NumbersOutPut.text = NumbersOutPut.text+" - ";
		//NumberToWord.text = "Zero";
		_Formula = "SUB";
		_isSignPress = true;
	}

	public void Mul(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);

		NumbersOutPut.text = NumbersOutPut.text+" X ";
		//NumberToWord.text = "Zero";
		_Formula = "MUL";
		_isSignPress = true;
	}

	public void Div(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);

		NumbersOutPut.text = NumbersOutPut.text+" / ";
		//NumberToWord.text = "Zero";
		_Formula = "DIV";
		_isSignPress = true;
	}

	public void Per(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);

		NumbersOutPut.text = NumbersOutPut.text+" % ";
		//NumberToWord.text = "Zero";
		_Formula = "PER";
		_isSignPress = true;
	}

	public void PassNeg(){
		if(NumbersOutPut.text != "0"){
			_InputData1 = Convert.ToDouble(NumbersOutPut.text);
			if (_InputData1 < 0) {
				double x = Math.Abs(_InputData1);
				NumbersOutPut.text = x +"";
				NumbersInX.text = x +"";
			} else {
				NumbersOutPut.text = "-" + _InputData1;
				NumbersInX.text = "-" + _InputData1;
			}
		}
	}



	public void Equal(){
		_InputData1 = Convert.ToDouble(NumbersInX.text);
		if (_isSignPress == true) {
			if (NumbersInY.text != "") {
				_InputData2 = Convert.ToDouble (NumbersInY.text);
				if (_Formula == "ADD") {
					if (_InputData1 < 0) {
						_SumTotal = _InputData2 - _InputData1;
					} else {
						_SumTotal = _InputData1 + _InputData2;
					}

					NumbersOutPut.text = _SumTotal + "";
					NumberToWord.text = DecimalToWords (Convert.ToDecimal (_SumTotal));	
				} else if (_Formula == "SUB") {
					if (_InputData1 < 0) {
						_SumTotal = _InputData1 - _InputData2;
						_SumTotal = Math.Abs (_SumTotal);
					} else {
						_SumTotal = _InputData1 - _InputData2;
					}


					NumbersOutPut.text = _SumTotal + "";
					NumberToWord.text = DecimalToWords (Convert.ToDecimal (_SumTotal));	
				} else if (_Formula == "MUL") {
					_SumTotal = _InputData1 * _InputData2;

					NumbersOutPut.text = _SumTotal + "";
					NumberToWord.text = DecimalToWords (Convert.ToDecimal (_SumTotal));	
				} else if (_Formula == "DIV") {
					if (_InputData1 == 0) {
						NumbersOutPut.text = "Error";
					} else {
						_SumTotal = _InputData1 / _InputData2;

						NumbersOutPut.text = _SumTotal + "";
						NumberToWord.text = DecimalToWords (Convert.ToDecimal (_SumTotal));	
					}

				} else if (_Formula == "PER") {
					_SumTotal = (_InputData2 * _InputData1) / 100;

					NumbersOutPut.text = _SumTotal + "";
					NumberToWord.text = DecimalToWords (Convert.ToDecimal (_SumTotal));	
				} 

				_isErase = true;
				_InputData1 = 0;
				_InputData2 = 0;

				_Formula = "";
				_isSignPress = false;
				NumbersInX.text = "";
				NumbersInY.text = "";
			} else {
				_isSignPress = true;
			}
				
		}
		else if(_isSignPress == false){
			NumberToWord.text = DecimalToWords (Convert.ToDecimal(_InputData1));

			_isErase = true;
			_InputData1 = 0;
			_InputData2 = 0;

			_Formula = "";
			_isSignPress = false;
			NumbersInX.text = "";
			NumbersInY.text = "";
		}
	}

	public void Erase(){
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_InputData1 = 0;
		_InputData2 = 0;
		NumbersInX.text = "0";
		NumbersInY.text = "0";
		_isSignPress = false;
	}


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
}
