using System;

namespace TagLib.Id3v2
{
	/// <summary>
	/// 
	/// </summary>
	public class EventTimeCode : ICloneable
	{
		/// <summary>
		/// 
		/// </summary>
		public EventType TypeOfEvent { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int Time { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="typeOfEvent"></param>
		/// <param name="time"></param>
		public EventTimeCode (EventType typeOfEvent, int time)
		{
			TypeOfEvent = typeOfEvent;
			Time = time;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static EventTimeCode CreateEmpty ()
		{
			return new EventTimeCode (EventType.Padding, 0);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns><see cref="EventTimeCode" /></returns>
		public object Clone ()
		{
			return new EventTimeCode (TypeOfEvent, Time);
		}
	}
}