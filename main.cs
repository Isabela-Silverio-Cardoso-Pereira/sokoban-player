/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
  }
}


using Godot;
using System;

public partial class Jogador : Area2D
{    private int are_quadrado = 64;
     private Vector2 direcao;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}





public void Movimento(){
	direcao = new Vector2(0,0); // para garantir que ele não se mexa por outras teclas
	if(Input.IsActionJustPressed("esquerda")){
        direcao = new Vector2(-1,0);
	}if(Input.IsActionJustPressed("direita")){
        direcao = new Vector2(1,0);
	}if(Input.IsActionJustPressed("cima")){
        direcao = new Vector2(0,-1);
	}

	//detecta a diração desejada, substituindo o outro código
	if(Input.IsActionJustPressed("baixo")){
        direcao = new Vector2(0,1);
	}//if

			Position += direcao * are_quadrado; // para movimento em grade

	
	}
             
	public override void _UnhandledInput(InputEvent @event){ //só se move com esse código
           if(@event is InputEventKey eventkey){
			if(eventkey.Pressed){
				Movimento();
			}
		   }
	}//event
	
	}

