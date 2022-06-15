namespace MyErp.Models {
    public class Incoterm {
        public string Code { get; set; }
        public string Name { get; set; }

        public Incoterm(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}