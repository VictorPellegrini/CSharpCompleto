namespace Section15221_GenericsSetDisctionary.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Users(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Users))
            {
                return false;
            }

            Users other = obj as Users;
            return Id.Equals(other.Id);
        }
    }
}
