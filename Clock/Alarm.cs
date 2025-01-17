﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm : IComparable<Alarm>
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week WeekDays { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }
		public Alarm()
		{
			WeekDays = new Week();//62

		}
		public Alarm(DateTime date, TimeSpan time, Week week, string filenae, string massage)
		{
			this.Date = date;
			this.Time = time;
			this.WeekDays = week;
			this.Filename = filenae;
			this.Message = Message;
			Console.WriteLine($"Constructor:{this.GetHashCode()}");

		}
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.WeekDays = other.WeekDays;
			this.Filename = other.Filename;
			this.Message = other.Message;
			Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");

		}
		public override string ToString()
		{
			string info = "";
			if (Date != DateTime.MinValue) info += $"{Date}\t";
			info += DateTime.Today.Add(Time).ToString("hh:mm:ss tt");//.ToString(@"hh\:mm\:cc ");
																	 //info += Time;//.ToString(@"hh\:mm\:cc ");
			info += "\t";
			info += $"{WeekDays}\t";
			info += $"{Filename}\t";
			info += $"{Message}\t";

			return info;
		}
		//public static bool operator ==(Alarm left, Alarm right)
		//{
		//	return
		//		left.Date == right.Date &&
		//		left.Time == right.Time &&
		//		left.WeekDays == right.WeekDays &&
		//		left.Filename == right.Filename &&
		//		left.Message == right.Message;
		//}
		//public static bool operator !=(Alarm left, Alarm right)
		//{ 
		//	return !(left==right);
		//}
		//public static bool operator> (Alarm left, Alarm right)
		//{
		//	if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
		//	{
		//		return
		//			(left.Date == DateTime.MinValue ? DateTime.Today : left.Date) >=
		//			(right.Date >= DateTime.MinValue ? DateTime.Today : right.Date) &&
		//			left.Time > right.Time;
		//		//(left.Date > right.Date && left.Time > right.Time;
		//	}
		//	else return left.Time > right.Time;
		//}
		//public static bool operator <(Alarm left, Alarm right)
		//{
		//	if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
		//	{
		//		return (left.Date == DateTime.MinValue ? DateTime.Today : left.Date) >=
		//			(right.Date <= DateTime.MinValue ? DateTime.Today : right.Date) &&
		//			left.Time < right.Time;
		//	}
		//	else return left.Time < right.Time;
		//}
		public int CompareTo(Alarm other)
		{
			//Console.WriteLine("Alarm comparison");
			return this.Time.CompareTo(other.Time);
		}
	}
}
