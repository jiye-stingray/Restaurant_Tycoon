using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GoldManager 
{
    static readonly string[] CurrentGoldString = new string[] { "", "A", "B", "C","D","E","F","G","H" ,"I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

    public static string ToMoneyString(this double number)
    {
        string zero = "0";

        if (-1d < number && number < 1d)
        {
            return zero; 
        }

        if(double.IsInfinity(number))
        {
            return "Infinity";
        }

        string significant = (number < 0) ? "-" : string.Empty;     // 부호 출력 문자열

        string numberString = string.Empty;       // 보여줄 숫자

        string unitString = string.Empty;      // 단위 숫자

        string[] partsSplit = number.ToString("E").Split("+");      // 지수 표현식으로 변경

        if(partsSplit.Length < 2)       // 예외
        {
            return zero;
        }

        if (!int.TryParse(partsSplit[1],out int exponent))      // 지수가 존재하는지
        {
            return zero;
        }

        // 문자열 인덱스
        int quotient = exponent / 3;

        // 정수부 자리 수 계산에 사용
        int remainder = exponent % 3;

        if(exponent < 3)        // 1000 보다 작으면
        {
            // 문자열 그대로 출력
            numberString = System.Math.Truncate(number).ToString();
        }
        else
        {
            var temp = double.Parse(partsSplit[0].Replace("E", "")) * System.Math.Pow(10, remainder);

            numberString = temp.ToString("F").Replace(".00", "");
        }

        unitString = CurrentGoldString[quotient];

        return string.Format("{0}{1}{2}",significant,numberString, unitString); 

    }
    
}
