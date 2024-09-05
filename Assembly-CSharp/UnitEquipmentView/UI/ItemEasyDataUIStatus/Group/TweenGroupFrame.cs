// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemEasyDataUIStatus.Group.TweenGroupFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI.ItemEasyDataUIStatus.Group
{
  [Token(Token = "0x2000471")]
  public class TweenGroupFrame : ITweenGroupName
  {
    [Token(Token = "0x400182F")]
    [FieldOffset(Offset = "0x10")]
    private ITweenGroupName current;
    [Token(Token = "0x4001830")]
    [FieldOffset(Offset = "0x18")]
    private TweenGroupFrame.None none;
    [Token(Token = "0x4001831")]
    [FieldOffset(Offset = "0x20")]
    private TweenGroupFrame.Change change;
    [Token(Token = "0x4001832")]
    [FieldOffset(Offset = "0x28")]
    private TweenGroupFrame.Select select;
    [Token(Token = "0x4001833")]
    [FieldOffset(Offset = "0x30")]
    private TweenGroupFrame.Equip equip;

    [Token(Token = "0x17000306")]
    public string Group
    {
      [Token(Token = "0x600190C"), Address(RVA = "0x2493914", Offset = "0x2493914", VA = "0x2493914", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600190D")]
    [Address(RVA = "0x2493BB8", Offset = "0x2493BB8", VA = "0x2493BB8")]
    public TweenGroupFrame()
    {
    }

    [Token(Token = "0x600190E")]
    [Address(RVA = "0x249118C", Offset = "0x249118C", VA = "0x249118C")]
    public void ToNone()
    {
    }

    [Token(Token = "0x600190F")]
    [Address(RVA = "0x2491174", Offset = "0x2491174", VA = "0x2491174")]
    public void ToChange()
    {
    }

    [Token(Token = "0x6001910")]
    [Address(RVA = "0x2491130", Offset = "0x2491130", VA = "0x2491130")]
    public void ToSelect()
    {
    }

    [Token(Token = "0x6001911")]
    [Address(RVA = "0x24911B0", Offset = "0x24911B0", VA = "0x24911B0")]
    public void ToEquip()
    {
    }

    [Token(Token = "0x2000472")]
    private class None : ITweenGroupName
    {
      [Token(Token = "0x17000307")]
      public string Group
      {
        [Token(Token = "0x6001912"), Address(RVA = "0x2493F24", Offset = "0x2493F24", VA = "0x2493F24", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001913")]
      [Address(RVA = "0x2493F04", Offset = "0x2493F04", VA = "0x2493F04")]
      public None()
      {
      }
    }

    [Token(Token = "0x2000473")]
    private class Change : ITweenGroupName
    {
      [Token(Token = "0x17000308")]
      public string Group
      {
        [Token(Token = "0x6001914"), Address(RVA = "0x2493F64", Offset = "0x2493F64", VA = "0x2493F64", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001915")]
      [Address(RVA = "0x2493F0C", Offset = "0x2493F0C", VA = "0x2493F0C")]
      public Change()
      {
      }
    }

    [Token(Token = "0x2000474")]
    private class Select : ITweenGroupName
    {
      [Token(Token = "0x17000309")]
      public string Group
      {
        [Token(Token = "0x6001916"), Address(RVA = "0x2493FA4", Offset = "0x2493FA4", VA = "0x2493FA4", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001917")]
      [Address(RVA = "0x2493F14", Offset = "0x2493F14", VA = "0x2493F14")]
      public Select()
      {
      }
    }

    [Token(Token = "0x2000475")]
    private class Equip : ITweenGroupName
    {
      [Token(Token = "0x1700030A")]
      public string Group
      {
        [Token(Token = "0x6001918"), Address(RVA = "0x2493FE4", Offset = "0x2493FE4", VA = "0x2493FE4", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001919")]
      [Address(RVA = "0x2493F1C", Offset = "0x2493F1C", VA = "0x2493F1C")]
      public Equip()
      {
      }
    }
  }
}
