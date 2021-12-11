using System;

public class User
{
	private string Name;
	private string Password;
	private string Type;
	public string name { 
		get 
		{
			return Name;
		}
	}
	public string password { 
		get
        {
			return Password;
        } 
	}
	public string type
	{
		get
		{
			return Type;
		}
	}

	public User(string name, string password, string type)
	{
		this.Name = name;
		this.Password = password;
		this.Type = type;
	}
}
