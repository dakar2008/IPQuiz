using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPQuiz
{
    public class Helper
    {
        public static string GetTimeFromTS(TimeSpan ts)
        {
            string result;

            if (ts.Days > 0)
            {
                result = string.Format("{0}:{1}:{2}:{3}:{4}", ts.Days.ToString().PadLeft(2, '0'), ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(3, '0'));
            }
            else
            {
                if (ts.Hours > 0)
                {
                    result = string.Format("{0}:{1}:{2}:{3}", ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(3, '0'));
                }
                else
                {
                    if (ts.Minutes > 0)
                    {
                        result = string.Format("{0}:{1}:{2}", ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(3, '0'));
                    }
                    else
                    {
                        if (ts.Seconds > 0)
                        {
                            result = string.Format("{0}:{1}", ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(3, '0'));
                        }
                        else
                        {
                            result = string.Format("{0}", ts.Milliseconds.ToString().PadLeft(3, '0'));
                        }
                    }
                }
            }
            return result;
        }
        public static string GenerateRandomIP()
        {
            Random RandomNumber = new Random();
            int ip_part1 = RandomNumber.Next(1, 256);
            int ip_part2 = RandomNumber.Next(1, 256);
            int ip_part3 = RandomNumber.Next(1, 256);
            int ip_part4 = RandomNumber.Next(1, 256);
            return string.Format("{0}.{1}.{2}.{3}", ip_part1.ToString(), ip_part2.ToString(), ip_part3.ToString(), ip_part4.ToString());
        }
        public static string ShowResult(string IP)
        {
            string[] splitip = IP.Split('.');
            string ippart1 = String.Empty;
            string ippart2 = String.Empty;
            string ippart3 = String.Empty;
            string ippart4 = String.Empty;
            for (int i = 0; i < splitip.Length; i++)
            {
                int number = int.Parse(splitip[i]);
                if(i == 0)
                {
                    ippart1 = Convert.ToString(number, 2).PadLeft(8, '0');
                }
                else if(i == 1)
                {
                    ippart2 = Convert.ToString(number, 2).PadLeft(8, '0');
                }
                else if(i == 2)
                {
                    ippart3 = Convert.ToString(number, 2).PadLeft(8, '0');
                }
                else
                {
                    ippart4 = Convert.ToString(number, 2).PadLeft(8, '0');
                }
            }
            return string.Format("{0}.{1}.{2}.{3}", ippart1, ippart2, ippart3, ippart4);
        }
        public static bool IsAnswerCorrect(string IP, string UserInput)
        {
            string binaryip = ShowResult(IP);
            if(binaryip == UserInput)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}