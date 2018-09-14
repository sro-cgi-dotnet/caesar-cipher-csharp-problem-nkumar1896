using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string s="";
            foreach(char c in text)
            {
                int p=(int)c;
                int k=p+(shiftKey%26);
                if(p>=97 && p<123)
                {
                if(k>122)
                {
                    k=k-122+96;
                }
                s+=(char)k;
                }
             else if(p>=65 && p<91)
                {
                if(k>90)
                {
                    k=k-90+64;
                }
                    s+=(char)k;
                }

                else{
                    s+=c;
                }
                
            }
            return s;
        }
    }
}
