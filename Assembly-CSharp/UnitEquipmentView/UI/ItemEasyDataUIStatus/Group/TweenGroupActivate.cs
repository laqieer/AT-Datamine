// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemEasyDataUIStatus.Group.TweenGroupActivate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI.ItemEasyDataUIStatus.Group
{
  [Token(Token = "0x200046E")]
  public class TweenGroupActivate : ITweenGroupName
  {
    [Token(Token = "0x400182C")]
    [FieldOffset(Offset = "0x10")]
    private ITweenGroupName current;

    [Token(Token = "0x17000301")]
    public string Group
    {
      [Token(Token = "0x6001902"), Address(RVA = "0x2493874", Offset = "0x2493874", VA = "0x2493874", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000302")]
    private TweenGroupActivate.Enable enable
    {
      [Token(Token = "0x6001903"), Address(RVA = "0x2493E64", Offset = "0x2493E64", VA = "0x2493E64")] get
      {
        return (TweenGroupActivate.Enable) null;
      }
    }

    [Token(Token = "0x17000303")]
    private TweenGroupActivate.Disable disable
    {
      [Token(Token = "0x6001904"), Address(RVA = "0x2493E6C", Offset = "0x2493E6C", VA = "0x2493E6C")] get
      {
        return (TweenGroupActivate.Disable) null;
      }
    }

    [Token(Token = "0x6001905")]
    [Address(RVA = "0x2493B14", Offset = "0x2493B14", VA = "0x2493B14")]
    public TweenGroupActivate()
    {
    }

    [Token(Token = "0x6001906")]
    [Address(RVA = "0x2491118", Offset = "0x2491118", VA = "0x2491118")]
    public void ToEnable()
    {
    }

    [Token(Token = "0x6001907")]
    [Address(RVA = "0x2491124", Offset = "0x2491124", VA = "0x2491124")]
    public void ToDisable()
    {
    }

    [Token(Token = "0x200046F")]
    private class Enable : ITweenGroupName
    {
      [Token(Token = "0x17000304")]
      public string Group
      {
        [Token(Token = "0x6001908"), Address(RVA = "0x2493E84", Offset = "0x2493E84", VA = "0x2493E84", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6001909")]
      [Address(RVA = "0x2493E74", Offset = "0x2493E74", VA = "0x2493E74")]
      public Enable()
      {
      }
    }

    [Token(Token = "0x2000470")]
    private class Disable : ITweenGroupName
    {
      [Token(Token = "0x17000305")]
      public string Group
      {
        [Token(Token = "0x600190A"), Address(RVA = "0x2493EC4", Offset = "0x2493EC4", VA = "0x2493EC4", Slot = "4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600190B")]
      [Address(RVA = "0x2493E7C", Offset = "0x2493E7C", VA = "0x2493E7C")]
      public Disable()
      {
      }
    }
  }
}
