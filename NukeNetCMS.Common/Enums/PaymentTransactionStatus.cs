using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NukeNetCMS.Common.Enums
{
    public enum PaymentTransactionStatus
    {
        Fail,
        Success
    }

    public static partial class EnumUtils
    {
        public static bool GetPaymentTransactionStatusValue(this PaymentTransactionStatus value)
        {
            switch (value)
            {
                case PaymentTransactionStatus.Success: return true;
                case PaymentTransactionStatus.Fail: return false;
                default: throw new ArgumentOutOfRangeException("value");
            }
        }

        public static PaymentTransactionStatus SetPaymentTransactionStatusValue(this PaymentTransactionStatus key, bool value)
        {
            return value == true ? PaymentTransactionStatus.Success : PaymentTransactionStatus.Fail;
        }
    }
}
