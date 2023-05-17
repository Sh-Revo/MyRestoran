using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectsSO kitchenObjectsSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //There is not a KitchenObject here
            if (player.HasKitchenObject())
            {
                //Player is carrying smth
                player.GetKitchenObjects().SetKitchenObjectParent(this);
            } 
            else
            {
                //Player not carrying anything

            }
        }
        else
        {
            //There is a KitchenObject here
            if (player.HasKitchenObject())
            {
                //Player is carrying smth
                if (player.GetKitchenObjects().TryGetPlates(out PlateKitchenObject plateKitchenObject))
                {
                    //Player is holding a plate
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObjects().GetKitchenObjectsSO()))
                    {
                        GetKitchenObjects().DestroySelf();
                    }
                }
                else
                {
                    //Player is not carrying Plate but something else
                    if (GetKitchenObjects().TryGetPlates(out plateKitchenObject))
                    {
                        //Counter is holding a plate
                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObjects().GetKitchenObjectsSO()))
                        {
                            player.GetKitchenObjects().DestroySelf();
                        }

                    }
                }
            } 
            else
            {
                //Player is not carrying anything
                GetKitchenObjects().SetKitchenObjectParent(player);
            }
        }
    }
}
