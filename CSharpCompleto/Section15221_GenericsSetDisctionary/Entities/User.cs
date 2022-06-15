namespace Section15221_GenericsSetDisctionary.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is User))
            {
                return false;
            }
            User other = obj as User;
            return Id.Equals(other.Id);
        }
    }
}
