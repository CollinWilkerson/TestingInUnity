public interface IPlayer
{
    public void TakeDamage();
    public int Health { get; set; }
    public bool IsPlayer();
    public IEquipment weapon { get; set; }
    public IEquipment armor { get; set; }
}