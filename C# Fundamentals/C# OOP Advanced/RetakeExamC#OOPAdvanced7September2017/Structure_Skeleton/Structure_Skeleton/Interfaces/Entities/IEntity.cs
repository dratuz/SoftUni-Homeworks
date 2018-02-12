public interface IEntity
{
    string ID { get; }

    double Durability { get; }

    double Produce();

    void Broke();
}