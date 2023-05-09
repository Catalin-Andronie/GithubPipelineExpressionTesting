using Xunit;

namespace SkipSpecificTests;

public class UnitTest1
{
    [Fact]
    [Trait("Category", "Integration")]
    public void Should_Only_Run_When_Environment_Variable_IsReleaseCandidate()
    {
        string environmentVaribable =
            Environment.GetEnvironmentVariable("IS_RELEASE_CANDIDATE") ?? "false";

        Assert.True(
            condition: environmentVaribable == "true",
            userMessage: "Expected variabel `IS_RELEASE_CANDIDATE` to have a `true` value.");
    }

    [Fact]
    public void Should_Allways_Run()
    {
        // Skipped
    }
}