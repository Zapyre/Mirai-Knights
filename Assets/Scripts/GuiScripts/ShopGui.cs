using UnityEngine;
using System.Collections;
using System;

public class ShopGui {
	public void Draw(){
		string invStr = "You currently have ";
		ArrayList charItemList = new ArrayList ();
		ArrayList shopItemList = new ArrayList ();
		ArrayList buyingItemList = new ArrayList ();
		ArrayList sellingItemList = new ArrayList ();

		if (charItemList != null){
			foreach (Item item in charItemList){
				if (invStr != "You currently have "){
					invStr += ", \n";
				}
				invStr += item.GetAmount() + "x " + item.GetName() + "(" + item.GetType() + ")";
			}
		}
		
		string shopInvStr = "The shop currently has ";
		if (shopItemList != null){
			foreach (Item item in shopItemList){
				if (shopInvStr != "The shop currently has "){
					shopInvStr += ", \n";
				}
				shopInvStr += item.GetAmount() + "x " + item.GetName() + "(" + item.GetType() + ")";
			}
		}
		
		//GUI.Label(new Rect (0,0,500,100), invStr);
		//GUI.Label(new Rect (0,100,500,100), shopInvStr);
		
		// Store's Items
		GUI.Label(new Rect (0,0,Screen.width/2,100), "Store Items");
		int divider = 0;
		foreach (Item item in shopItemList){
			if (item.GetAmount() > 0){
				if (GUI.Button(new Rect(0 + divider, 50, Screen.width/16, Screen.width/16), item.GetName() + "\nx" + item.GetAmount())){
					item.SetAmount(item.GetAmount() - 1);
					if (!ItemListContainsItem(buyingItemList, item)){
						Item i = item.DupItem();
						i.SetAmount(1);
						buyingItemList.Add(i);
					}
					else {
						Item i = GetItemFromList(buyingItemList, item.GetName());
						if (i != null){
							i.SetAmount(i.GetAmount() + 1);
						}
					}
				}
				divider += Screen.width/16 + 10;
			}
		}
		
		
		// Your Items
		GUI.Label(new Rect (Screen.width/2,0,Screen.width/2,100), "Your Items");
		divider = 0;
		foreach (Item item in charItemList){
			if (item.GetAmount() > 0){
				if (GUI.Button(new Rect(Screen.width/2 + divider, 50, Screen.width/16, Screen.width/16), item.GetName() + "\nx" + item.GetAmount())){
					item.SetAmount(item.GetAmount() - 1);
					if (!ItemListContainsItem(sellingItemList, item)){
						Item i = item.DupItem();
						i.SetAmount(1);
						sellingItemList.Add(i);
					}
					else {
						Item i = GetItemFromList(sellingItemList, item.GetName());
						if (i != null){
							i.SetAmount(i.GetAmount() + 1);
						}
					}
				}
				divider += Screen.width/16 + 10;
			}
		}
		
		// Your Buying Items
		GUI.Label(new Rect (0,Screen.height/2,Screen.width/2,100), "Items you are Buying");
		divider = 0;
		foreach (Item item in buyingItemList){
			if (item.GetAmount() > 0){
				if (GUI.Button(new Rect(0 + divider, Screen.height/2 + 50, Screen.width/16, Screen.width/16), item.GetName() + "\nx" + item.GetAmount())){
					item.SetAmount(item.GetAmount() - 1);
					if (!ItemListContainsItem(shopItemList,item)){
						Item i = item.DupItem();
						i.SetAmount(1);
						shopItemList.Add(i);
					}
					else {
						Item i = GetItemFromList(shopItemList, item.GetName());
						if (i != null){
							i.SetAmount(i.GetAmount() + 1);
						}
					}
				}
				divider += Screen.width/16 + 10;
			}
		}
		
		// Your Selling Items
		GUI.Label(new Rect (Screen.width/2,Screen.height/2,Screen.width/2,100), "Items you are Selling");
		divider = 0;
		foreach (Item item in sellingItemList){
			if (item.GetAmount() > 0){
				if (GUI.Button(new Rect(Screen.width/2 + divider, Screen.height/2 + 50, Screen.width/16, Screen.width/16), item.GetName() + "\nx" + item.GetAmount())){
					item.SetAmount(item.GetAmount() - 1);
					if (!ItemListContainsItem(charItemList,item)){
						Item i = item.DupItem();
						i.SetAmount(1);
						charItemList.Add(i);
					}
					else {
						Item i = GetItemFromList(charItemList, item.GetName());
						if (i != null){
							i.SetAmount(i.GetAmount() + 1);
						}
					}
				}
				divider += Screen.width/16 + 10;
			}
		}
		
		// Setting up game GUI here, may refactor outside later
		if (GUI.Button(new Rect(Screen.width - Screen.width/8,Screen.height - Screen.height/8,Screen.width/8,Screen.height/8), "Return to Town!")){
		}
		if (GUI.Button(new Rect(0,Screen.height - Screen.height/8,Screen.width/8,Screen.height/8), "Complete Transaction")){
			bool success = false;
			foreach (Item item in buyingItemList){
				Item shopi = GetItemFromList (shopItemList, item.GetName());
				Item iDup = shopi.DupItem();
				int addedAmount = 0;
				Item sellListi = GetItemFromList(sellingItemList, item.GetName ());
				if (sellListi != null){
					addedAmount = sellListi.GetAmount();
				}
				iDup.SetAmount(shopi.GetAmount() + addedAmount);
				// Remove item from shop here
			}
			foreach (Item item in sellingItemList){
				Item i = GetItemFromList (charItemList, item.GetName());
				Item iDup = i.DupItem();
				int addedAmount = 0;
				Item buyListi = GetItemFromList(buyingItemList, item.GetName ());
				if (buyListi != null){
					addedAmount = buyListi.GetAmount();
				}
				iDup.SetAmount(i.GetAmount() + addedAmount);
				// Remove item from character here
			}
			if (success){
				shopItemList = new ArrayList ();
				charItemList = new ArrayList ();
				buyingItemList = new ArrayList ();
				sellingItemList = new ArrayList ();
			}
		}
	}

	private bool ItemListContainsItem (ArrayList aList, Item i){
		bool contains = false;
		foreach (Item i2 in aList) {
			if (i != null && i.GetName().Equals(i2.GetName())){
				contains = true;
			}
		}
		return contains;
	}
	
	private Item GetItemFromList (ArrayList aList, string name){
		Item i = null;
		foreach (Item i2 in aList) {
			if (name != null && name.Equals(i2.GetName())){
				i = i2;
			}
		}
		return i;
	}
}