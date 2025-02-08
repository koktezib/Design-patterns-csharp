namespace Patterns.Patterns.CreationalPatterns.Singleton;

public class Singleton
{
    private static Singleton _instance;
    
    public string Name = "Rider";
    private Singleton(){}

    public static Singleton Instance => _instance ??= new Singleton();

}