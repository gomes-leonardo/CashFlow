﻿using CashFlow.Application.UseCases.Expenses.Register;
using Shouldly;



namespace Validators.Test.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange

        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.ShouldBeTrue();
    }
}
