using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2023
{
    internal class Birthday
    {
        DateTime dt;
        public DateTime Date { get; }
        Birthday(DateTime dt) => this.dt = dt;
        Birthday(int sec) => this.dt = new DateTime(sec);
        Birthday() : this(0) { }
        public void Change(DateTime dt) => this.dt = dt;
        public void Change(int sec) => this.dt = new DateTime(sec);
        public DayOfWeek GetDatWeek() => dt.DayOfWeek;
        public DayOfWeek GetDatWeek(int year)
        {
            return new DateTime(year, dt.Month, dt.Day).DayOfWeek;
        }
        public int Until(DateTime date)
        {
            return date.Subtract(dt).Days;
        }
    }
}
