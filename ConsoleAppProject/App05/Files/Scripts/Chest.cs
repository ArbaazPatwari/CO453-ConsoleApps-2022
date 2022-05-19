using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int rupeesAmount = 10;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.rupees += rupeesAmount;
            GameManager.instance.ShowText("+" + rupeesAmount + " rupees!", 25, Color.yellow, transform.position, Vector3.up * 40, 1.0f);
        }
    }
}
