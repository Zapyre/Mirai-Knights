using UnityEngine;
using System.Collections;

public abstract class ShopKeeper {
	protected string name;
	protected string greeting;
	protected ArrayList shopItemList;
	protected ArrayList charItemList;
	protected ArrayList buyingItemList;
	protected ArrayList sellingItemList;

	public ShopKeeper (string n, string g){
		name = n;
		greeting = g;
		shopItemList = new ArrayList ();
		charItemList = new ArrayList ();
		buyingItemList = new ArrayList ();
		sellingItemList = new ArrayList ();
	}

	public string GetGreeting (){
		return greeting;
	}

	public void PopulateShop (ArrayList sItemList){
		shopItemList = sItemList;
	}

	public void PopulateChar (ArrayList cItemList){
		charItemList = cItemList;
	}
}
