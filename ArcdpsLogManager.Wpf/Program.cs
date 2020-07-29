﻿using System;
using Eto.Forms;
using GW2Scratch.ArcdpsLogManager;

namespace GW2Scratch.ArcdpsLogManager.Wpf
{
	class Startup
	{
		[STAThread]
		static void Main(string[] args)
		{
			// optional - enables GDI text display mode
			/*
			Style.Add<Eto.Wpf.Forms.FormHandler>(null, handler => TextOptions.SetTextFormattingMode(handler.Control, TextFormattingMode.Display));
			Style.Add<Eto.Wpf.Forms.DialogHandler>(null, handler => TextOptions.SetTextFormattingMode(handler.Control, TextFormattingMode.Display));
			*/

			new Application().Run(new LoadingForm());
		}

	}
}

