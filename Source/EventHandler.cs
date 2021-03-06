﻿
/*
 * Author : Samuel "MrOverkill" Meyers
 * Last Modified : 01/06/2015
 * License : Simplified BSD
 * 
 * Description:
 * 	Basic structure for an event handler.
 */

using System;

namespace EventSharp
{
	public class EventHandler
	{
		public virtual EventResult OnEvent(Event evt)
		{
			return EventResult.IGNORED;
		}
	}
}

