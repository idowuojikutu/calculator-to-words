using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalculationBackup : MonoBehaviour {

	public InputField NumberToWord;
	public InputField NumbersOutPut;
	public InputField NumbersOutPutTemp;

	private double _InputData1, _InputData2, _SumTotal;
	private string _Formula;
	private bool _isErase;

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
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 1 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 1 + "";
		}
	}

	public void Number2(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 2 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 2 + "";
		}
	}

	public void Number3(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 3 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 3 + "";
		}
	}

	public void Number4(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 4 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 4 + "";
		}
	}

	public void Number5(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 5 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 5 + "";
		}
	}

	public void Number6(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 6 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 6 + "";
		}
	}

	public void Number7(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 7 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 7 + "";
		}
	}

	public void Number8(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 8 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 8 + "";
		}
	}

	public void Number9(){
		if (NumbersOutPut.text == "0" || _isErase == true) {
			NumbersOutPut.text = 9 + "";
			_isErase = false;
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 9 + "";
		}

	}

	public void Number0(){
		if (NumbersOutPut.text == "0") {
			NumbersOutPut.text =  0 + "";
		} else {
			NumbersOutPut.text = NumbersOutPut.text + 0 + "";
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
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_Formula = "ADD";
	}

	public void Sub(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_Formula = "SUB";
	}

	public void Mul(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_Formula = "MUL";
	}

	public void Div(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_Formula = "DIV";
	}

	public void Per(){
		_InputData1 = Convert.ToDouble(NumbersOutPut.text);
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_Formula = "PER";
	}

	public void PassNeg(){
		if(NumbersOutPut.text != "0"){
			_InputData1 = Convert.ToDouble(NumbersOutPut.text);
			if (_InputData1 < 0) {
				double x = Math.Abs(_InputData1);
				NumbersOutPut.text = x +"";
			} else {
				NumbersOutPut.text = "-" + _InputData1;
			}
		}
	}



	public void Equal(){
		if(_Formula == "ADD"){
			_InputData2 = Convert.ToDouble(NumbersOutPut.text);
			_SumTotal = _InputData1 + _InputData2;

			NumbersOutPut.text = _SumTotal + "";
			NumberToWord.text = DecimalToWords (Convert.ToDecimal(_SumTotal));	
		} else if(_Formula == "SUB"){
			_InputData2 = Convert.ToDouble(NumbersOutPut.text);
			if (_InputData1 < 0) {
				_SumTotal = _InputData1 - _InputData2;
				_SumTotal = Math.Abs (_SumTotal);
			} else {
				_SumTotal = _InputData1 - _InputData2;
			}


			NumbersOutPut.text = _SumTotal + "";
			NumberToWord.text = DecimalToWords (Convert.ToDecimal(_SumTotal));	
		} else if(_Formula == "MUL"){
			_InputData2 = Convert.ToDouble(NumbersOutPut.text);
			_SumTotal = _InputData1 * _InputData2;

			NumbersOutPut.text = _SumTotal + "";
			NumberToWord.text = DecimalToWords (Convert.ToDecimal(_SumTotal));	
		} else if(_Formula == "DIV"){
			_InputData2 = Convert.ToDouble(NumbersOutPut.text);
			if (_InputData1 == 0) {
				NumbersOutPut.text = "Error";
			} else {
				_SumTotal = _InputData1 / _InputData2;

				NumbersOutPut.text = _SumTotal + "";
				NumberToWord.text = DecimalToWords (Convert.ToDecimal(_SumTotal));	
			}

		} else if(_Formula == "PER"){
			_InputData2 = Convert.ToDouble(NumbersOutPut.text);
			_SumTotal = ( _InputData2 * _InputData1) / 100;

			NumbersOutPut.text = _SumTotal + "";
			NumberToWord.text = DecimalToWords (Convert.ToDecimal(_SumTotal));	
		} 

		if(NumbersOutPut.text != "" || _InputData2 != 0){
			_InputData1 = Convert.ToDouble(NumbersOutPut.text);
			NumberToWord.text = DecimalToWords (Convert.ToDecimal(_InputData1));	
		}
		_isErase = true;
		_InputData1 = 0;
		_InputData2 = 0;
		_Formula = "";
	}

	public void Erase(){
		NumbersOutPut.text = 0 + "";
		NumberToWord.text = "Zero";
		_InputData1 = 0;
		_InputData2 = 0;
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
