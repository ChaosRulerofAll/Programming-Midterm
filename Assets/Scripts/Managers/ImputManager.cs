using UnityEngine;

public static class ImputManager
{

    private static Controlls _controls;



    public static void init(Player myPlayer)
    {
        _controls = new Controlls();

        _controls.Game.Movement.performed += ctx => 
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        };


        _controls.Permanant.Enable();

    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();


    }

    public static void UIMode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();


    }


}
