using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RobotForm
{
	public enum Direction : int
	{
		West = 231,
		North = 233,
		East = 232,
		South = 234
	}
	class Robot
    {
		public Direction direction;

		public Robot()
		{
			this.location = new System.Drawing.Point();
			direction = Direction.North;
		}

		public Point location { get; set; }
		public void move(int unit)
		{
			Point change = new Point();
			switch (direction)
			{
				case Direction.North:
					change.X = this.location.X;
					change.Y = this.location.Y - unit;
					break;
				case Direction.South:
					change.X = this.location.X;
					change.Y = this.location.Y + unit;
					break;
				case Direction.West:
					change.X = this.location.X - unit;
					change.Y = this.location.Y;
					break;
				case Direction.East:
					change.X = this.location.X + unit;
					change.Y = this.location.Y;
					break;
			}
			this.location = change;
		}
		 
		public override string ToString()
		{
			return ((char)direction).ToString();
		}
		public string GetFormattedLocation()
		{
			string locationString = "{X=" + Convert.ToString(this.location.X) + ",Y=" + Convert.ToString(this.location.Y) + "}";
			return locationString;
		}
	}
}
