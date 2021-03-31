using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Tree
    {
        [Key]
        public string TreeType { get; set; }
        public int NumTreeInStock { get; set; }
        public DateTime ArrivalDate { get; set; }

        /************************************************
         * Consider what all a tree needs to be bought: *
         *  1. ID                                       *
         *  2. Title                                    *
         *  3. Inventory                                *
         *  4. (Optioonal) Number in orders             *
         *************************************************/
    }
}