﻿using System;
using OpenTK;

namespace ClassicalSharp.Particles {

	public abstract class Particle {
		
		public Vector3 Position;
		public Vector3 Velocity;
		public float Lifetime;
		protected Vector3 lastPos, nextPos;

		public abstract void CountVertices( Game game, int[] counts );
		
		public abstract void Render( Game game, double delta, float t, 
		                            VertexPos3fTex2fCol4b[] vertices, ref int index );
		
		public virtual bool Tick( Game game, double delta ) {
			Lifetime -= (float)delta;
			return Lifetime < 0;
		}
	}
}