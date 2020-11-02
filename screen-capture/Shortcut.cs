using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Shortcut
{
	enum MOD
	{
		ALT = 0x1,
		CTRL = 0x2,
		SHIFT = 0x4,
		WIN = 0x8
	}

	struct Hotkey
	{
		public int MOD;
		public int KEY;
		public string TEXT;

		public Hotkey(int mod, int key, string text)
		{
			MOD = mod;
			KEY = key;
			TEXT = text;
		}

		public void RemoveMOD(int mod)
		{
			MOD = MOD ^ mod;
		}
		public void RemoveMOD(MOD mod)
		{
			RemoveMOD((int)mod);
		}

		public static List<MOD> GetMOD(int mod)
		{
			List<MOD> result = new List<MOD>();
			Type type = typeof(MOD);
			var flags = BindingFlags.Static | BindingFlags.Public;
			var fields = type.GetFields(flags).Where(f => f.IsLiteral);

			foreach (FieldInfo field in fields)
			{
				int currentMod = (int)field.GetRawConstantValue();
				if ((currentMod & mod) == currentMod)
				{
					result.Add((MOD)currentMod);
				}
			}

			return result;
		}
	}
}
