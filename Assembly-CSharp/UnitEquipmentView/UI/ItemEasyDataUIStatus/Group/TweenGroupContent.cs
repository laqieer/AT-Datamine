// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemEasyDataUIStatus.Group.TweenGroupContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI.ItemEasyDataUIStatus.Group
{
  [Token(Token = "0x2000476")]
  public class TweenGroupContent : ITweenGroupName
  {
    [Token(Token = "0x4001834")]
    [FieldOffset(Offset = "0x10")]
    private ITweenGroupName current;
    [Token(Token = "0x4001835")]
    [FieldOffset(Offset = "0x18")]
    private TweenGroupContent.Default _default;
    [Token(Token = "0x4001836")]
    [FieldOffset(Offset = "0x20")]
    private TweenGroupContent.Blank blank;
    [Token(Token = "0x4001837")]
    [FieldOffset(Offset = "0x28")]
    private TweenGroupContent.Remove remove;
    [Token(Token = "0x4001838")]
    [FieldOffset(Offset = "0x30")]
    private TweenGroupContent.UnEquip unequip;

    [Token(Token = "0x1700030B")]
    public string Group
    {
      [Token(Token = "0x600191A"), Address(RVA = "0x24939B4", Offset = "0x24939B4", VA = "0x24939B4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600191B")]
    [Address(RVA = "0x2493CBC", Offset = "0x2493CBC", VA = "0x2493CBC")]
    public TweenGroupContent()
    {
    }

    [Token(Token = "0x600191C")]
    [Address(RVA = "0x2491198", Offset = "0x2491198", VA = "0x2491198")]
    public void ToDefault()
    {
    }

    [Token(Token = "0x600191D")]
    [Address(RVA = "0x24911A4", Offset = "0x24911A4", VA = "0x24911A4")]
    public void ToBlank()
    {
    }

    [Token(Token = "0x600191E")]
    [Address(RVA = "0x24911BC", Offset = "0x24911BC", VA = "0x24911BC")]
    public void ToRemove()
    {
    }

    [Token(Token = "0x600191F")]
    [Address(RVA = "0x2491180", Offset = "0x2491180", VA = "0x2491180")]
    public void ToUnEquip()
    {
    }

    [Token(Token = "0x2000477")]
    private class Default : ITweenGroupName
    {
      [Token(Token = "0x1700030C")]
      public string Group
      {
        [Token(Token = "0x6001920"), Address(RVA = "0x2494044", Offset = "0x2494044", VA = "0x2494044", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001921")]
      [Address(RVA = "0x2494024", Offset = "0x2494024", VA = "0x2494024")]
      public Default()
      {
      }
    }

    [Token(Token = "0x2000478")]
    private class Blank : ITweenGroupName
    {
      [Token(Token = "0x1700030D")]
      public string Group
      {
        [Token(Token = "0x6001922"), Address(RVA = "0x2494084", Offset = "0x2494084", VA = "0x2494084", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001923")]
      [Address(RVA = "0x249402C", Offset = "0x249402C", VA = "0x249402C")]
      public Blank()
      {
      }
    }

    [Token(Token = "0x2000479")]
    private class Remove : ITweenGroupName
    {
      [Token(Token = "0x1700030E")]
      public string Group
      {
        [Token(Token = "0x6001924"), Address(RVA = "0x24940C4", Offset = "0x24940C4", VA = "0x24940C4", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001925")]
      [Address(RVA = "0x2494034", Offset = "0x2494034", VA = "0x2494034")]
      public Remove()
      {
      }
    }

    [Token(Token = "0x200047A")]
    private class UnEquip : ITweenGroupName
    {
      [Token(Token = "0x1700030F")]
      public string Group
      {
        [Token(Token = "0x6001926"), Address(RVA = "0x2494104", Offset = "0x2494104", VA = "0x2494104", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001927")]
      [Address(RVA = "0x249403C", Offset = "0x249403C", VA = "0x249403C")]
      public UnEquip()
      {
      }
    }
  }
}
