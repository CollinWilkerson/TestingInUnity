public interface IPlayer
{
    public void TakeDamage();
    public int Health { get; set; }
    public bool IsPlayer();
}