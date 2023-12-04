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

        string significant = (number < 0) ? "-" : string.Empty;     // ��ȣ ��� ���ڿ�

        string numberString = string.Empty;       // ������ ����

        string unitString = string.Empty;      // ���� ����

        string[] partsSplit = number.ToString("E").Split("+");      // ���� ǥ�������� ����

        if(partsSplit.Length < 2)       // ����
        {
            return zero;
        }

        if (!int.TryParse(partsSplit[1],out int exponent))      // ������ �����ϴ���
        {
            return zero;
        }

        // ���ڿ� �ε���
        int quotient = exponent / 3;

        // ������ �ڸ� �� ��꿡 ���
        int remainder = exponent % 3;

        if(exponent < 3)        // 1000 ���� ������
        {
            // ���ڿ� �״�� ���
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
