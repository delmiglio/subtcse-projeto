namespace Avanade.SUBTCSE.Projeto.Domain
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }

    // private set - só essa classe pode setar valor pra ela
}
