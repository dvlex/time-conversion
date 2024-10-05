// See https://aka.ms/new-console-template for more information

String inTime1 = "12:00:00PM";
String inTime2 = "12:00:00aM";
String inTime3 = "07:05:45PM";
String inTime4 = "07:05:45am";
String inTime5 = "13:52:00PM";

Console.WriteLine(Result.TimeConversion(inTime1));
Console.WriteLine(Result.TimeConversion(inTime2));
Console.WriteLine(Result.TimeConversion(inTime3));
Console.WriteLine(Result.TimeConversion(inTime4));
Console.WriteLine(Result.TimeConversion(inTime5));

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversion(string s)
    {
        return TimeOnly.Parse(s).ToString("HH:mm:ss");
    }

}