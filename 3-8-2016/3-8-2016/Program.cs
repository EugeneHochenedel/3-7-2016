using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IStudent
{
	string School
	{
		get;
		set;
	}
	int Year
	{
		get;
		set;
	}

	void SenpaiRadar(IStudent senpai);
}

public interface IMechaPilot
{
	string MechName
	{
		get;
		set;
	}
	int Attack
	{
		get;
		set;
	}
	int Defense
	{
		get;
		set;
	}

	void ItsAnAngel(IMonster angel);
}

public interface IMonster
{
	int Level
	{
		get;
		set;
	}
}

public class Protagonist : IStudent, IMechaPilot
{
	private string Uni;
	private int iGrade;
	private string ArmorName;
	private int iPower;
	private int iGuard;
	
	public Protagonist(string Class, int iLevel, string Name, int iStrength, int iShield)
	{
		Uni = Class;
		iGrade = iLevel;
		ArmorName = Name;
		iPower = iStrength;
		iGuard = iShield;
	}

	public string School
	{
		get
		{
			return Uni;
		}
		set
		{
			Uni = value;
		}
	}

	public int Year
	{
		get
		{
			return iGrade;
		}
		set
		{
			iGrade = value;
		}
	}

	public string MechName
	{
		get
		{
			return ArmorName;
		}
		set
		{
			ArmorName = value;
		}
	}

	public int Attack
	{
		get
		{
			return iPower;
		}
		set
		{
			iPower = value;
		}
	}

	public int Defense
	{
		get
		{
			return iGuard;
		}
		set
		{
			iGuard = value;
		}
	}

	public void SenpaiRadar(IStudent senpai)
	{
		if (senpai.School == this.Uni && senpai.Year > this.iGrade)
		{
			Console.WriteLine("Senpai doesn't notice the protagonist... Senpai never will. \n");
		}
		else if (senpai.School == this.Uni && senpai.Year <= this.iGrade || senpai.School != this.Uni && senpai.Year <= this.iGrade)
		{
			Console.WriteLine("That isn't Senpai! That's an imposter! \n");
		}
		else if (senpai.School != this.Uni && senpai.Year > this.iGrade)
		{
			Console.WriteLine("Senpai noticed the protagonist, but just doesn't care. \n");
		}
	}

	public void ItsAnAngel(IMonster Sadness)
	{
		if(Sadness.Level > 4/3 * this.iGuard)
		{
			Console.WriteLine(this.MechName + " was lost in Battle. \n");
		}
		else
		{
			Console.WriteLine(this.MechName + " fights on! \n");
		}
		if (Sadness.Level > 5 / 4 * this.iPower)
		{
			Console.WriteLine(this.MechName + " attacks did nothing!");
		}
		else
		{
			Console.WriteLine(this.MechName + " defeated the monster! :D");
		}
	}
}

public class SadTwist : IStudent, IMonster
{
	private string Univ;
	private int iGrades;
	private int iTier;

	public string School
	{
		get
		{
			return Univ;
		}
		set
		{
			Univ = "A School";
		}
	}
	public int Year
	{
		get
		{
			return iGrades;
		}
		set
		{
			iGrades = value;
		}
	}
	public int Level
	{
		get
		{
			return iTier;
		}
		set
		{
			iTier = value;
		}
	}
	public SadTwist(string Class, int iYear, int iRank)
	{
		Univ = Class;
		iGrades = iYear;
		iTier = iRank;
	}
	public void SenpaiRadar(IStudent senpai)
	{
		throw new NotImplementedException();
	}
}

class Program
{
	static void Main(string[] args)
	{
		Protagonist sitsByWindow = new Protagonist("Temp", 2, "Mecha", 25, 20);
		SadTwist childFriend = new SadTwist("Temp", 3, 20);

		sitsByWindow.SenpaiRadar(childFriend);
		sitsByWindow.ItsAnAngel(childFriend);
		Console.ReadLine();
	}
}