/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/3/2024
 * Time: 1:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace accidenteFindSpotsOnMap
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		//List<List<tip>> i yill create new classes better
		public List<string>Countries=new List<string>();
		public List<string>Cities=new List<string>();
		public List<street>streets=new List<street>();
		
		public class street
		{
			public string name;
			public List<pairsInt>path = new List<pairsInt>();
		}
		public class pairsInt
		{
			public int x;
			public int y;
			
			public pairsInt(){}
			public pairsInt(int px, int py)
			{
				this.x = px;
				this.y = py;
				
			}
		}
		public class pair
		{
			public int streetAindex;
			public int streetBindex;
			public int nrOfAccidents = 0;
			public List<string>dateaccidente = new List<string>();
			public string name;
			public pair(){}
			public pair(int px, int py, string pname)
			{
				this.streetAindex = px;
				this.streetBindex = py;
				this.name = pname;
			}
		}
		public class mapOfStreets{
			public List<pair>mapxy = new List<pair>();	//here are indexes inside a list of streets
			public bool addNewCoords(int x, int y, string name)
			{
				mapxy.Add(new pair(x,y,name));
				return true;
			}
			public bool addNewAccident(int intersectioncode, string x)
			{
				mapxy[intersectioncode].dateaccidente.Add(x);
				return true;
			}
			public bool drawMap(ref Graphics g,ref List<street> sx)
			{
				for(int i = 0; i < mapxy.Count ; i++)
				{
					//here you can test how many line exists in path or dots
					g.DrawLine(new Pen(Color.Black),sx[mapxy[i].streetAindex].path[0].x,sx[mapxy[i].streetBindex].path[0].x,sx[mapxy[i].streetAindex].path[1].y,sx[mapxy[i].streetBindex].path[1].y);
					          
				}
				return true;
			}
		}
		
		
		
	
		
	}
}
