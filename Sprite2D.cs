using Godot;
using System;

public partial class Sprite2D : Godot.Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello Godot!!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print($"Process: {delta}");
		var pos = Position;
		pos.X += Convert.ToSingle(delta * 10);
		Position = pos;
	}
}
