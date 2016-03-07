using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfacePractice
{
	public interface IBattle
	{
		void Information();
		int iPain(int iDamage);
	}
	public interface IStats
	{
		int iHealth
		{
			get;
			set;
		}
		int iStrength
		{
			get;
			set;
		}
		bool Status
		{
			get;
			set;
		}
	}
	
	public class Ninja : IBattle, IStats
	{
		private int iLife;
		private int iAttack;
		private bool bLiving;
		public string Class;

		public int iHealth
		{
			get
			{
				return iLife;
			}

			set
			{
				iLife = 20;
			}
		}

		public int iStrength
		{
			get
			{
				return iAttack;
			}

			set
			{
				iAttack = value;
			}
		}

		public bool Status
		{
			get
			{
				return bLiving;
			}
			set
			{
				if (iLife > 0)
				{
					bLiving = value;
				}
				else if (iLife <= 0)
				{
					bLiving = value;
				}
			}
		}

		public Ninja(int Health, string Title, int Strength, bool Life)
		{
			iLife = Health;
			Class = Title;
			iAttack = Strength;
			bLiving = Life;
		}

		public void Information()
		{
			if (bLiving == true)
			{
				Console.WriteLine(Class + " has " + iLife + "HP. Strength: " + iAttack);
			}
			else if (bLiving == false)
			{
				Console.WriteLine(Class + " has perished.");
			}
		}

		public int iPain(int iD)
		{
			for()


			return iLife;
		}
	}

	public class Duck : IBattle
	{
		private int Life2;
		public string Class2;
		public Duck(int Health, string Title)
		{
			Life2 = Health;
			Class2 = Title;
		}

		public void Information()
		{
			Console.WriteLine(Class2 + " has " + Life2 + "HP");
		}
		public void Action()
		{

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<IBattle> Fighters = new List<IBattle>();
			for (int iFights = 0; iFights <= 15; iFights++)
			{
				Ninja Man = new Ninja(20, "Ninja " + iFights, 50, false);
				Duck Animal = new Duck(5, "Duck " + iFights/*.ToString()*/);

				Fighters.Add(Man);
				Fighters.Add(Animal);
			}
			foreach(IBattle w in Fighters)
			{
				w.Information();
			}

			Console.ReadLine();
		}
	}
}