using System;
using TextFile;
namespace salary
{
	public class CustomEnum
	{
		public struct Employee
		{
			public string name;
			public double salary;

			public Employee()
			{
                name = "";
                salary = 0;
            }

			public override string ToString()
			{
				return name + " " + salary;
			}
		}
		public enum Status {
			norm, abnorm
		}

        private TextFileReader x;
		public Status st;
		public Employee e;
		private Employee curr;
		private bool end;

		public CustomEnum(String filename)
		{
			x = new TextFileReader(filename);
        }

        public void read()
		{
			x.ReadString(out e.name);
			bool l = x.ReadDouble(out e.salary);
			st = l ? Status.norm : Status.abnorm;
        }
	}
}

