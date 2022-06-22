namespace FormVer2.Models.BL.ComponentBL
{
    public class ComponentDTO
    {
        public ComponentDTO(string co_id, string co_name, bool co_value)
        {
            this.Id = co_id;
            this.Name = co_name;
            this.ContainValue = co_value;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool ContainValue { get; set; }
    }
}
