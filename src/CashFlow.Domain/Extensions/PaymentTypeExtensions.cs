using CashFlow.Domain.Enums;
using CashFlow.Domain.PaymentTypeName;

namespace CashFlow.Domain.Extensions;
public static class PaymentTypeExtensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourcePaymentTypeName.CASH,
            PaymentType.CreditCard => ResourcePaymentTypeName.CREDIT_CARD,
            PaymentType.DebitCard => ResourcePaymentTypeName.DEBIT_CARD,
            PaymentType.EletronicTransfer => ResourcePaymentTypeName.ELECTRONIC_TRANSFER,
            PaymentType.Pix => ResourcePaymentTypeName.PIX,
            _ => string.Empty,
        };
    }
}
