// Decompiled with JetBrains decompiler
// Type: UnitView.WeaponsInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitView
{
  [Token(Token = "0x20003C3")]
  public class WeaponsInfo : UIReferences.IProperty
  {
    [Token(Token = "0x17000240")]
    public Equipment Equipment
    {
      [Token(Token = "0x60015DC"), Address(RVA = "0x2484238", Offset = "0x2484238", VA = "0x2484238")] get
      {
        return (Equipment) null;
      }
    }

    [Token(Token = "0x17000241")]
    public List<ItemDetailData> BelongingItemEntities
    {
      [Token(Token = "0x60015DD"), Address(RVA = "0x2484240", Offset = "0x2484240", VA = "0x2484240")] get
      {
        return (List<ItemDetailData>) null;
      }
    }

    [Token(Token = "0x17000242")]
    public IEnumerable<ItemDetailData> BelongingItems
    {
      [Token(Token = "0x60015DE"), Address(RVA = "0x2484248", Offset = "0x2484248", VA = "0x2484248", Slot = "4")] get
      {
        return (IEnumerable<ItemDetailData>) null;
      }
    }

    [Token(Token = "0x17000243")]
    public List<ItemDetailData> InventoryItems
    {
      [Token(Token = "0x60015DF"), Address(RVA = "0x2484250", Offset = "0x2484250", VA = "0x2484250")] get
      {
        return (List<ItemDetailData>) null;
      }
    }

    [Token(Token = "0x60015E0")]
    [Address(RVA = "0x2484258", Offset = "0x2484258", VA = "0x2484258")]
    public WeaponsInfo()
    {
    }

    [Token(Token = "0x60015E1")]
    [Address(RVA = "0x24843A0", Offset = "0x24843A0", VA = "0x24843A0")]
    public void CreateDummy()
    {
    }

    [Token(Token = "0x60015E2")]
    [Address(RVA = "0x2484AE8", Offset = "0x2484AE8", VA = "0x2484AE8")]
    public void DetatchItem(ItemEasyDataUI itemUI)
    {
    }

    [Token(Token = "0x60015E3")]
    [Address(RVA = "0x2484830", Offset = "0x2484830", VA = "0x2484830")]
    private ItemDetailData CreateDetailDataDummy() => new ItemDetailData();
  }
}
