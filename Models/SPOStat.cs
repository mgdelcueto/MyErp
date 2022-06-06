namespace MyErp.Models {
    public class SPOStat {
        public int? Code { get; set; }
        public string Name { get; set; }

        public SPOStat(int? code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}