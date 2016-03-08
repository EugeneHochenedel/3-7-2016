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
	
	public Protagonist(string Class, int iLevel, string Name, int iStrength)
	{
		Class = Uni;
		iLevel = iGrade;
		Name = ArmorName;
		iStrength = iPower;
	}

	public string School
	{
		get
		{
			return Uni;
		}
		set
		{
			Uni = "A School";
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

	public void SenpaiRadar(IStudent Hm)
	{
		if (Hm.School == this.Uni && Hm.Year > this.iGrade)
		{
			Console.WriteLine("Senpai doesn't notice the protagonist... Senpai never will.");
		}
		else if (Hm.School == this.Uni && Hm.Year <= this.iGrade || Hm.School != this.School && Hm.Year <= this.iGrade)
		{
			Console.WriteLine("That isn't Senpai! That's an imposter!");
		}
		else if(Hm.School != this.Uni && Hm.Year > this.iGrade)
		{
			Console.WriteLine("Senpai noticed the protagonist, but just doesn't care.");
		}
	}

	public void ItsAnAngel(IMonster Sadness)
	{
		if(Sadness.Level > 1/3 * iPower)
		{

		}
	}
}

public class SadTwist : IStudent, IMonster
{
	private string Uni;
	private int iGrade;
	private int iTier;

	public SadTwist(string Class, int iYear, int iRank)
	{
		Class = Uni;
		iYear = iGrade;
		iRank = iTier;
	}

	public string School
	{
		get
		{
			return Uni;
		}
		set
		{
			Uni = "A School";
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

	public void SenpaiRadar(IStudent senpai)
	{
		throw new NotImplementedException("I don't think Ineed this here.");
	}
}

