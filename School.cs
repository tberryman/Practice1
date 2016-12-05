using System;

public class Class1
{
    private String title;
    private int startTime;
    private int endTime;
    private int day;

public Class1()
	{
        //this refers to the current instance of the class and qualify fields
        this.title = title;
        this.startTime = startTime;
        this.endTime = endTime;
        this.day = day;

	}
    public int startTime
    {
        get { return this.startTime; }
    }
    public int endTime
    {
        get { return this.endTime; }
    }
    public string title
    {
        get { return this.title; }
    }
    public int day
    {
        get { return this.day; }
    }
}
