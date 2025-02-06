using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validators.Test.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = new RequestRegisterExpenseJson
        {
            Amount = 100,
            Date = DateTime.Now.AddDays(-1),
            Description = "description",
            Title = "title",
            PaymentType = CashFlow.Communication.Enums.PaymentType.Pix
        };
        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);
    }
}
