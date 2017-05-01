﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GraphData : MonoBehaviour {

	//All the values to be accessed for the graph being shown
	public List<Entry> database = new List<Entry>();
	public static int numEntries = 0;

	public struct Entry
	{

		//what else to include?
		public int userID;
		public int sampleID;
		public int verdict;
		public DateTime addedOn;

		// x + y + z add up to 1
		//These are set to 0 by default in case this day does no exist?
		public float insertCost;
		public float substituteCost;
		public float deleteCost;

		public Entry(int uid, int sid, int ver, DateTime date, float x, float y, float z)
		{
			userID = uid;
			sampleID = sid;
			verdict = ver;
			addedOn = date;
			insertCost = x;
			substituteCost = y;
			deleteCost = z;
		}
	}

	// Request this upon graph tab being clicked
	public void RequestData()
	{
		// Reset the list
		database.Clear();

		// Request data from server

		//For moment, use test data
		TestData();

		// Add all points to list
		//e.g. database.Add(new Entry(,,,,,,));

		//Finally, get number of total entries
		numEntries = database.Count;

	}

	public void TestData()
	{
		database.Add(new Entry(15, 16, 0, DateTime.Today, 0f, 0.022043f, 0f));
		database.Add(new Entry(17, 16, 2, DateTime.Today, 0.8f, 0.0406216f, 1.6f));
		database.Add(new Entry(16, 16, 1, DateTime.Today, 1.6f, 0.0120743f, 0f));
		database.Add(new Entry(15, 17, 0, DateTime.Today, 0f, 0.019543f, 0.8f));
		database.Add(new Entry(17, 17, 2, DateTime.Today, 0.8f, 0.0381216f, 1.2f));
		database.Add(new Entry(16, 17, 1, DateTime.Today, 0.4f, 0.0095743f, 0f));
		database.Add(new Entry(15, 18, 0, DateTime.Today, 0.4f, 0.017043f, 1.2f));
		database.Add(new Entry(17, 18, 2, DateTime.Today, 1.6f, 0.0356216f, 0.8f));
		database.Add(new Entry(16, 18, 1, DateTime.Today, 0f, 0.0070743f, 0.4f));
	}
}
