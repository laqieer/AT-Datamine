// Decompiled with JetBrains decompiler
// Type: UI.Scroll.ItemControllerLoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace UI.Scroll
{
  [Token(Token = "0x20008B3")]
  [RequireComponent(typeof (InfiniteScroll))]
  public class ItemControllerLoop : UIBehaviour, IInfiniteScrollSetup
  {
    [Token(Token = "0x40028CE")]
    [FieldOffset(Offset = "0x20")]
    private bool isSetuped;

    [Token(Token = "0x17000729")]
    public List<Sprite> tipsList
    {
      [Token(Token = "0x600316C"), Address(RVA = "0x3C1789C", Offset = "0x3C1789C", VA = "0x3C1789C")] get
      {
        return (List<Sprite>) null;
      }
      [Token(Token = "0x600316D"), Address(RVA = "0x3C178A4", Offset = "0x3C178A4", VA = "0x3C178A4")] set
      {
      }
    }

    [Token(Token = "0x600316E")]
    [Address(RVA = "0x3C178AC", Offset = "0x3C178AC", VA = "0x3C178AC", Slot = "17")]
    public void OnPostSetupItems()
    {
    }

    [Token(Token = "0x600316F")]
    [Address(RVA = "0x3C1790C", Offset = "0x3C1790C", VA = "0x3C1790C", Slot = "19")]
    public virtual void OnUpdateItem(int itemCount, GameObject obj)
    {
    }

    [Token(Token = "0x6003170")]
    [Address(RVA = "0x3C179C8", Offset = "0x3C179C8", VA = "0x3C179C8")]
    public ItemControllerLoop()
    {
    }
  }
}
