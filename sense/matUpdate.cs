using Godot;
using System;

public class matUpdate : CanvasLayer
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public void updateMat(int quantity, string[] mat); {
        switch (mat) {
            
            case "mat1":
            
            break;

            case "mat2":

            break;

            case "mat3":

            break;

            case "mat4":
            
            break;


            default:
            GD.print("invaled mat");
            break;
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
