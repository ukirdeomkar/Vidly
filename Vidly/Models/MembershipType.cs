﻿namespace Vidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string Name { get; set; }

        public static readonly int Unknown = 1;
        public static readonly int PayAsYouGo = 2;

    }
}
