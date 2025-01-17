﻿namespace Microsoft.Maui.TestUtils.DeviceTests.Sample;

public class UnitTests
{
	[Fact]
	public void SuccessfulTest()
	{
		Assert.True(true);
	}

	[Fact(Skip = "This test is skipped.")]
	public void SkippedTest()
	{
	}

	[Fact]
	public void FailingTest()
	{
		throw new Exception("This is meant to fail.");
	}

	[Theory]
	[InlineData(1)]
	[InlineData(2)]
	[InlineData(3)]
	public void ParameterizedTest(int number)
	{
		Assert.NotEqual(0, number);
	}

	[Fact]
	public async Task LongRunningSuccess()
	{
		await Task.Delay(2000);
		Assert.True(true);
	}

	[Fact]
	public async Task LongRunningFail()
	{
		await Task.Delay(2000);
		throw new Exception("This is meant to fail.");
	}
}
