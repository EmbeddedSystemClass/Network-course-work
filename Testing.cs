using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace HamCode
{
    class Testing
    {
        /// <summary>
        /// Процедура кодирования 
        /// циклическим кодом с образующим полиномом g(x)=x^3+x+1
        /// </summary>
        /// <param name="a">информационные разряды</param>
        /// <param name="n">образующий полином</param>
        /// <param name="code">результат кодовая комбинация</param>
        /// 




       

        public static int[] GetCodeVector(int[] infoVector)
        {
            var codeVector = new int[7];
            codeVector[0] = infoVector[0];
            codeVector[1] = infoVector[1];
            codeVector[2] = infoVector[2];
            codeVector[4] = infoVector[3];
            codeVector[3] = Xor(infoVector[0], infoVector[1], infoVector[2], 0);
            codeVector[5] = Xor(infoVector[0], infoVector[1], infoVector[3], 0);
            codeVector[6] = Xor(infoVector[0], infoVector[2], infoVector[3], 0);
            return codeVector;
        }

        public static int Xor(int a, int b, int c, int d)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return d;
                    return d == 0 ? 1 : 0;
                }
                if (c == 0)
                    return d == 0 ? 1 : 0;
                return d;
            }
            if (b == 0)
            {
                if (c == 0)
                    return d == 0 ? 1 : 0;
                return d;
            }
            if (c == 0)
                return d;
            return d == 0 ? 1 : 0;
        }

        public static string Int32ToStringMod2(int a)
        {
            if (a == 0) return "0";
            return (a == 1) ? "1" : Int32ToStringMod2(a / 2) + a % 2;
        }

        public static int[] StringToIntPtr(string a)
        {
            var buf = a.ToCharArray();
            var bufIntPtr = new int[7];
            for (var i = 0; i < a.Length; i++)
            {
                switch (buf[i])
                {
                    case '0':
                        bufIntPtr[i] = 0;
                        break;
                    case '1':
                        bufIntPtr[i] = 1;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("bufIntPtr", "Info Vector must contain just 0 or 1");
                }
            }
            return bufIntPtr;
        }

        public static int[] GetErrorSyndrome(int[] resultVector)
        {
            var errorSyndrome = new int[3];
            errorSyndrome[0] = Xor(resultVector[0], resultVector[1], resultVector[2], resultVector[3]);
            errorSyndrome[1] = Xor(resultVector[0], resultVector[1], resultVector[4], resultVector[5]);
            errorSyndrome[2] = Xor(resultVector[0], resultVector[2], resultVector[4], resultVector[6]);
            return errorSyndrome;
        }

        public static bool IsSyndromNull(int[] errorSyndrom)
        {
            for (var i = 0; i < 3; i++)
            {
                if (errorSyndrom[i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetCountOf1(int[] vector)
        {
            var count = 0;
            for (var i = 0; i < 7; i++)
                if (vector[i] == 1)
                    count++;
            return count;
        }

        public static int GetCombination(int n, int i)
        {
            return Fact(n) / (Fact(n - i) * Fact(i));
        }

        public static int Fact(int a)
        {
            var result = 1;
            for (var i = 1; i <= a; i++)
                result *= i;
            return result;
        }

        public static float GetDetectingAbility(float comb, float count)
        {
            return (count / comb);
        }


        static void Hamming(int []infoVector)
        {
            var detectedErrors = new int[7];
            var mainInfoVector = infoVector;
            var mainCodeVector = GetCodeVector(mainInfoVector);
            for (var i = 1; i < 128; i++)
            {
                var resultVector = new int[7];
                var stringnumber = Int32ToStringMod2(i);
                var length = stringnumber.Length;
                if (stringnumber.Length < 7)
                {
                    for (var j = 0; j < 7 - length; j++)
                    {
                        stringnumber = "0" + stringnumber;
                    }
                }
                var errorVector = StringToIntPtr(stringnumber);
                for (var j = 0; j < 7; j++)
                    resultVector[j] = Xor(mainCodeVector[j], errorVector[j], 0, 0);
                var errorSyndrom = GetErrorSyndrome(resultVector);
                if (!IsSyndromNull(errorSyndrom))
                {
                    detectedErrors[GetCountOf1(errorVector) - 1]++;
                }
            }
            
           
        }
    








    static void HammingCode(byte a, byte n, out byte code)
        {
            a <<= 3;

            while (CountBit(a) != CountBit(n)) n <<= 1;
                code = a;
             
                do 
                {
                    a ^= n;
                    do
                    {                        
                        n >>= 1;
                    } 
                    while (CountBit(a) != CountBit(n));
                } while (a > 7);
                code |= a;                               
        }
       
        static int CountBit(byte a)
        {
            int count = 0;
            while(!(a==0))
            {                
                a /= 2; 
                ++count;
            }            
            
            return (count);
        }
        static bool HammingDecode(byte a,out byte code,byte n)
        {
            while (CountBit(a) != CountBit(n)) n <<= 1;
            code = a;
            do  
            {                
                code ^= n;
                do
                {
                    n >>= 1;                    
                }
                while (CountBit(code) != CountBit(n)) ;                
            } 
            while (code > 7);

            if (code == 0)
            {
                code =(byte) (a >> 3);
                return (true);
            }
            else return (false);
        }
        
        /// <summary>
        /// Процедура кодирования строки текста
        /// </summary>
        /// <param name="str">строка из текстбокса</param>
        static public List<byte> CodingStr(string str)
        {
            char[] ChrArr;

            ///////////////////////
            byte LShort, HShort;
            ///////////////////////
            byte LWord, HWord;//младшая и старшие части символа.(получаются накладыванием маски)
            byte Gx=11;//образующий полином
            byte Code;
            List<byte> CodingString=new List<byte>();

            
            ChrArr = str.ToCharArray();

            //////////////////////////////////////////////
            short[] ShortArr=new short[str.Length];
            
            for (int i = 0; i < ChrArr.Length; i++)
            {
                ShortArr[i] = (short)ChrArr[i];
            }

            for (int i = 0; i < ShortArr.Length; i++)
            {
                LShort = (byte)(ShortArr[i] & 0x00FF);//получаем младшие 4 разряда маской 0000000011111111;
                HShort = (byte)((ShortArr[i] & 0xFF00) >> 8);//получаем старшие(маска 1111111100000000) и сдвигаем вначало


           
                    LWord = (byte)(LShort & 0x0F);//получаем младшие 4 разряда маской 00001111;
                    HWord = (byte)((LShort & 0xF0) >> 4);//получаем старшие(маска 11110000) и сдвигаем вначало
                              
                    HammingCode(LWord, Gx, out Code);
                    CodingString.Add(Code);
                    HammingCode(HWord, Gx, out Code);
                    CodingString.Add(Code);

                /////////////////////////////////////
                    LWord = (byte)(HShort & 0x0F);//получаем младшие 4 разряда маской 00001111;
                    HWord = (byte)((HShort & 0xF0) >> 4);//получаем старшие(маска 11110000) и сдвигаем вначало

              
                    HammingCode(LWord, Gx, out Code);
                    CodingString.Add(Code);
                    HammingCode(HWord, Gx, out Code);
                    CodingString.Add(Code);

            }
            return(CodingString);
        }//CodingStr()        
        
        /// <summary>
        /// метод декодирования исходной строки байтов в строку, введенную пользователем
        /// </summary>
        /// <param name="str">закодированая строка байтов</param>
        /// <returns></returns>
        static public string DeCodingStr(byte[] str)
        {
            char ch;
            string DecodedString="";
            byte LWord, HWord;//младшая и старшие части символа.(получаются накладыванием маски)
            //////////////////////////
            short LShort, HShort;
            //////////////////////////

            byte Gx = 11;//образующий полином
            
            for (int i = 0; i < str.Length;i++)
            {
                if(!HammingDecode(str[i],out LWord,Gx)) return("");                              
                if(!HammingDecode(str[++i], out HWord, Gx)) return("");             

                ////////////////////////////////////
                LShort=(short)((HWord<<4) |LWord);
                ///////////////////////////////////
                
                if(!HammingDecode(str[++i], out LWord, Gx)) return("") ;                
                if(!HammingDecode(str[++i], out HWord, Gx)) return("");
                HShort = (short)((HWord << 4) | LWord);

                ch=Convert.ToChar((HShort<<8)|LShort);
                Console.WriteLine("ch={0}", ch);
                DecodedString+=ch;
                              
            }
            return (DecodedString);
        }
   
    }
}
