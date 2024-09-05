// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.SelectInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitEquipmentView
{
  [Token(Token = "0x2000423")]
  public class SelectInfo
  {
    [Token(Token = "0x170002A5")]
    public SelectInfo.Data First
    {
      [Token(Token = "0x6001765"), Address(RVA = "0x248C268", Offset = "0x248C268", VA = "0x248C268")] get
      {
        return (SelectInfo.Data) null;
      }
    }

    [Token(Token = "0x170002A6")]
    public SelectInfo.Data Second
    {
      [Token(Token = "0x6001766"), Address(RVA = "0x248C270", Offset = "0x248C270", VA = "0x248C270")] get
      {
        return (SelectInfo.Data) null;
      }
    }

    [Token(Token = "0x170002A7")]
    public ItemEasyDataUI FirstItem
    {
      [Token(Token = "0x6001767"), Address(RVA = "0x248C278", Offset = "0x248C278", VA = "0x248C278")] get
      {
        return (ItemEasyDataUI) null;
      }
    }

    [Token(Token = "0x170002A8")]
    public ItemEasyDataUI SecondItem
    {
      [Token(Token = "0x6001768"), Address(RVA = "0x248C294", Offset = "0x248C294", VA = "0x248C294")] get
      {
        return (ItemEasyDataUI) null;
      }
    }

    [Token(Token = "0x6001769")]
    [Address(RVA = "0x248C2B0", Offset = "0x248C2B0", VA = "0x248C2B0")]
    public void SetFirst(ItemEasyDataUI itemUI, SelectInfo.ItemFrameType itemFrameType)
    {
    }

    [Token(Token = "0x600176A")]
    [Address(RVA = "0x248C2D4", Offset = "0x248C2D4", VA = "0x248C2D4")]
    public void SetSecond(ItemEasyDataUI itemUI, SelectInfo.ItemFrameType itemFrameType)
    {
    }

    [Token(Token = "0x600176B")]
    [Address(RVA = "0x248C2F0", Offset = "0x248C2F0", VA = "0x248C2F0")]
    public bool IsSameCategory() => new bool();

    [Token(Token = "0x600176C")]
    [Address(RVA = "0x248C354", Offset = "0x248C354", VA = "0x248C354")]
    public void Clear()
    {
    }

    [Token(Token = "0x600176D")]
    [Address(RVA = "0x248C384", Offset = "0x248C384", VA = "0x248C384")]
    public SelectInfo()
    {
    }

    [Token(Token = "0x2000424")]
    public abstract class ItemFrameType
    {
      [Token(Token = "0x170002A9")]
      public bool IsEquipped
      {
        [Token(Token = "0x600176E"), Address(RVA = "0x248C410", Offset = "0x248C410", VA = "0x248C410")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002AA")]
      public bool IsBelong
      {
        [Token(Token = "0x600176F"), Address(RVA = "0x248C418", Offset = "0x248C418", VA = "0x248C418")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170002AB")]
      public bool IsInventory
      {
        [Token(Token = "0x6001770"), Address(RVA = "0x248C420", Offset = "0x248C420", VA = "0x248C420")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6001771")]
      [Address(RVA = "0x248C428", Offset = "0x248C428", VA = "0x248C428")]
      private ItemFrameType(int bit)
      {
      }

      [Token(Token = "0x2000425")]
      public class Equipped : SelectInfo.ItemFrameType
      {
        [Token(Token = "0x6001772")]
        [Address(RVA = "0x248C544", Offset = "0x248C544", VA = "0x248C544")]
        public Equipped()
        {
        }
      }

      [Token(Token = "0x2000426")]
      public class Belong : SelectInfo.ItemFrameType
      {
        [Token(Token = "0x6001773")]
        [Address(RVA = "0x248C54C", Offset = "0x248C54C", VA = "0x248C54C")]
        public Belong()
        {
        }
      }

      [Token(Token = "0x2000427")]
      public class Inventory : SelectInfo.ItemFrameType
      {
        [Token(Token = "0x6001774")]
        [Address(RVA = "0x248C554", Offset = "0x248C554", VA = "0x248C554")]
        public Inventory()
        {
        }
      }
    }

    [Token(Token = "0x2000429")]
    public class Data
    {
      [Token(Token = "0x170002AC")]
      public ItemEasyDataUI ItemUI
      {
        [Token(Token = "0x6001777"), Address(RVA = "0x248C578", Offset = "0x248C578", VA = "0x248C578")] get
        {
          return (ItemEasyDataUI) null;
        }
        [Token(Token = "0x6001778"), Address(RVA = "0x248C580", Offset = "0x248C580", VA = "0x248C580")] private set
        {
        }
      }

      [Token(Token = "0x170002AD")]
      public SelectInfo.ItemFrameType ItemFrameType
      {
        [Token(Token = "0x6001779"), Address(RVA = "0x248C588", Offset = "0x248C588", VA = "0x248C588")] get
        {
          return (SelectInfo.ItemFrameType) null;
        }
        [Token(Token = "0x600177A"), Address(RVA = "0x248C590", Offset = "0x248C590", VA = "0x248C590")] private set
        {
        }
      }

      [Token(Token = "0x600177B")]
      [Address(RVA = "0x248C2CC", Offset = "0x248C2CC", VA = "0x248C2CC")]
      public void Set(ItemEasyDataUI itemUI, SelectInfo.ItemFrameType itemFrameType)
      {
      }

      [Token(Token = "0x600177C")]
      [Address(RVA = "0x248C37C", Offset = "0x248C37C", VA = "0x248C37C")]
      public void Clear()
      {
      }

      [Token(Token = "0x600177D")]
      [Address(RVA = "0x248C408", Offset = "0x248C408", VA = "0x248C408")]
      public Data()
      {
      }
    }
  }
}
