namespace MyErp.Models {
    public class CPlanStat {
        public string Code { get; set; }
        public string Name { get; set; }

        public CPlanStat(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}