﻿namespace GW2Scratch.EVTCAnalytics.Parsed.Enums
{
	public enum Activation : byte
	{
		None         = 0,
		Normal       = 1,
		Quickness    = 2,
		CancelFire   = 3,
		CancelCancel = 4,
		Reset        = 5,

		Unknown
	}
}