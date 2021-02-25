using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
    Dos Cambio reaalidos:
    1. el numero de la lista siempre regrese 8 
    2. borras nameTxt.text y IconImg.sprite -> ya que si no lo haces aparecera el numero indexado en texto  y cambiara el source image por diferentes botones 
    IMPORTANTE: Cambiar el length de la list al requerido.
    */

public class CircleItemContent
{
    public string name;
    public Sprite icon;
}
//Overide
public class CircleTestItem : CircleScrollRectItemBase
{
    public Text nameTxt;
    public Image iconImg;

    //Override following three functions 
    public override void RefreshItemContent(object data)
    {
        var contentItem = data as CircleItemContent;
     //   if(null != contentItem)
     //   {
     //       if(null != nameTxt)
     //       {
     //           nameTxt.text = contentItem.name;
     //       }
     //       if(null != iconImg)
     //       {
     //           iconImg.sprite = contentItem.icon;
    //        }          
    //    }
        
    }



    public override object GetContentListItem(int index)
    {
        return 0;
        //  return TestMono.ins.GetItem(index);
    }

    public override int GetContentListLength()
    {
        return 8;
     //   return TestMono.ins.GetItemLength();
    }

}
