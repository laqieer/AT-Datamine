// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemEasyDataUIStatus.Group.TweenGroupEquipButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI.ItemEasyDataUIStatus.Group
{
  [Token(Token = "0x200047B")]
  public class TweenGroupEquipButton : ITweenGroupName
  {
    [Token(Token = "0x4001839")]
    [FieldOffset(Offset = "0x10")]
    private ITweenGroupName current;
    [Token(Token = "0x400183A")]
    [FieldOffset(Offset = "0x18")]
    private TweenGroupEquipButton.Enable enable;
    [Token(Token = "0x400183B")]
    [FieldOffset(Offset = "0x20")]
    private TweenGroupEquipButton.Disable disable;

    [Token(Token = "0x17000310")]
    public string Group
    {
      [Token(Token = "0x6001928"), Address(RVA = "0x2493A54", Offset = "0x2493A54", VA = "0x2493A54", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6001929")]
    [Address(RVA = "0x2493DC0", Offset = "0x2493DC0", VA = "0x2493DC0")]
    public TweenGroupEquipButton()
    {
    }

    [Token(Token = "0x600192A")]
    [Address(RVA = "0x24911F0", Offset = "0x24911F0", VA = "0x24911F0")]
    public void ToEnable()
    {
    }

    [Token(Token = "0x600192B")]
    [Address(RVA = "0x24911FC", Offset = "0x24911FC", VA = "0x24911FC")]
    public void ToDisable()
    {
    }

    [Token(Token = "0x200047C")]
    private class Enable : ITweenGroupName
    {
      [Token(Token = "0x17000311")]
      public string Group
      {
        [Token(Token = "0x600192C"), Address(RVA = "0x2494154", Offset = "0x2494154", VA = "0x2494154", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600192D")]
      [Address(RVA = "0x2494144", Offset = "0x2494144", VA = "0x2494144")]
      public Enable()
      {
      }
    }

    [Token(Token = "0x200047D")]
    private class Disable : ITweenGroupName
    {
      [Token(Token = "0x17000312")]
      public string Group
      {
        [Token(Token = "0x600192E"), Address(RVA = "0x2494194", Offset = "0x2494194", VA = "0x2494194", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600192F")]
      [Address(RVA = "0x249414C", Offset = "0x249414C", VA = "0x249414C")]
      public Disable()
      {
      }
    }
  }
}
