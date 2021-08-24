using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamunaCreditCardValidation
{
    public class CardClass
    {
        public string CardNo;
        public string CardType;
        public string BankName;


    }
    public class CardCheck
    {
        CardClass card=new CardClass();

        public bool validatecard(string cardno,string cardtype)
        {
            bool bIsValid = false;
            if (cardno.Length != 16)
            {
                return false;
            }
            else if (cardno.Length == 16)
            {
                if (cardtype.Equals("MASTER") || cardtype.Equals("VISA"))
                {
                   
                    int iSum = 0;
                    for (int i = 15; i >= 0; i--)
                    {
                        int iNum = Convert.ToInt32(cardno[i].ToString());
                        if (i % 2 == 0)
                        {
                            iNum *= 2;
                            if (iNum > 9)
                                iNum -= 9;
                        }
                        iSum += iNum;
                    }
                    if (iSum % 10 == 0)
                        bIsValid = true;
                    card.CardNo = cardno;
                    card.CardType = cardtype;
                    //refer to another DLL which will connect to the bank application here
                    return bIsValid;
                }
                else
                    return false;
            }
       
                return false;

        }
    }
}
