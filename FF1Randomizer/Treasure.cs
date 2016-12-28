﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1Randomizer
{
	public enum QuestItems
	{
		Tnt = 0x06,
		Crown = 0x02,
		Ruby = 0x09,
		Floater = 0x0b,
		Tail = 0x0d,
		Slab = 0x08,
		Adamant = 0x07
	}

	public static class TreasureConditions
	{
		public static readonly List<byte> AllQuestItems = new List<byte>
		{
			(byte)QuestItems.Tnt,
			(byte)QuestItems.Crown,
			(byte)QuestItems.Ruby,
			(byte)QuestItems.Floater,
			(byte)QuestItems.Tail,
			(byte)QuestItems.Slab,
			(byte)QuestItems.Adamant
		};

		public static readonly List<int> UnusedIndices =
			Enumerable.Range(0, 1).Concat(
			Enumerable.Range(145, 4)).Concat(
			Enumerable.Range(187, 9)).Concat(
			Enumerable.Range(255, 1)).ToList();

		public static readonly List<int> UsedIndices = Enumerable.Range(0, 256).Except(UnusedIndices).ToList(); // This maps a compacted list back to the game's array, skipping the unused slots.

		public static readonly List<int> Beginning =
			Enumerable.Range(7, 3).Concat(
			Enumerable.Range(20, 10)).Concat(
			Enumerable.Range(33, 2)).Concat(
			Enumerable.Range(43, 3)).ToList();

		public static readonly List<int> EarlyCrown =
			Enumerable.Range(1, 6).Concat( // Coneria
			Enumerable.Range(10, 3)).Concat( // ToF east side
			Enumerable.Range(13, 4)).Concat( // Elfland
			Enumerable.Range(17, 3)).Concat( // Northwest Castle
			Enumerable.Range(30, 3)).Concat( // Marsh Cave
			Enumerable.Range(35, 8)).ToList(); // Dwarf Cave

		public static readonly List<int> Tnt = Enumerable.Range(46, 16).ToList(); // Earth Cave B1-B3

		public static readonly List<int> Rod = Enumerable.Range(62, 12).ToList(); // Earth Cave B4, Titan's Tunnel

		public static readonly List<int> FireAndIce = Enumerable.Range(74, 49).ToList();

		public static readonly List<int> Ordeals = Enumerable.Range(123, 9).ToList();

		public static readonly List<int> Airship =
			Enumerable.Range(132, 13).Concat( // Cardia Islands
			Enumerable.Range(149, 32).Except(new[] { 165 })).Concat( // Sea Shrine
			Enumerable.Range(181, 6)).ToList(); // Waterfall

		public static readonly List<int> LateCrown = new List<int> { 165 };

		public static readonly List<int> Chime = Enumerable.Range(196, 52).ToList(); // Mirage Tower + Sky Castle

		public static readonly List<int> ToFR = Enumerable.Range(248, 7).ToList(); // Anything that blocks an ORB will also block these.
	}
}
