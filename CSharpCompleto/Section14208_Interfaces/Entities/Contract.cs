using System;
using System.Collections.Generic;

namespace Section14208_Interfaces.Entities
{
    public class Contract
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }

        public Contract(int id, DateTime date, double totalValue)
        {
            Id = id;
            Date = date;
            TotalValue = totalValue;
        }

    }
}