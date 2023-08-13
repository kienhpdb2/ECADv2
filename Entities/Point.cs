﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECAD.Entities
{
    public class Point
		: EntityObject
    {
		public Vector3 position;
		private double thickness;

		public Point()
			: this(Vector3.Zero)
		{
		}

		public Point(Vector3 position)
			:base(EntityType.Point)
		{
			this.Position = position;
			this.Thickness = 0.0;
		}

		public double Thickness
		{
			get { return thickness; }
			set { thickness = value; }
		}

		public Vector3 Position
		{
			get { return position; }
			set { position = value; }
		}
		public override object CopyOrMove(Vector3 fromPoint, Vector3 toPoint)
		{
			Vector3 p = this.position.CopyOrMove(fromPoint, toPoint);

			return new Entities.Point
			{
				Position = p,
				Thickness = this.thickness,
				IsVisible = this.isVisible
			};
		}
        public override object Clone()
        {
			return new Entities.Point
			{
				Position = this.position,
				Thickness = this.thickness,
				//EntityObject properties
				IsVisible = this.isVisible
			};
        }
    }
}
