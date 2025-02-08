using Patterns.Patterns.CreationalPatterns.Singleton;

namespace PatternsTests;

[TestFixture]
public class SingletonTests
{
    [Test]
    public void Instance_ShouldNotBeNull()
    {
        // Act
        var instance = Singleton.Instance;
        
        // Assert
        Assert.IsNotNull(instance);
    }

    [Test]
    public void Instance_ShouldReturnSameObjectOnMultipleCalls()
    {
        // Act
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;
        
        // Assert
        Assert.That(instance2, Is.SameAs(instance1), "Оба вызова должны вернуть один и тот же экземпляр");
    }

    [Test]
    public void Singleton_DefaultName_ShouldBeRider()
    {
        // Act
        var instance = Singleton.Instance;
        
        // Assert
        Assert.That(instance.Name, Is.EqualTo("Rider"), "Значение Name должно быть 'Rider'");
    }
}