// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.Durability
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000443")]
  public struct Durability
  {
    [Token(Token = "0x170002D2")]
    public int Current
    {
      [Token(Token = "0x600182E"), Address(RVA = "0x2490244", Offset = "0x2490244", VA = "0x2490244")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600182F"), Address(RVA = "0x249024C", Offset = "0x249024C", VA = "0x249024C")] private set
      {
      }
    }

    [Token(Token = "0x170002D3")]
    public int Max
    {
      [Token(Token = "0x6001830"), Address(RVA = "0x2490254", Offset = "0x2490254", VA = "0x2490254")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6001831"), Address(RVA = "0x249025C", Offset = "0x249025C", VA = "0x249025C")] private set
      {
      }
    }

    [Token(Token = "0x170002D4")]
    public bool IsBroken
    {
      [Token(Token = "0x6001832"), Address(RVA = "0x2490264", Offset = "0x2490264", VA = "0x2490264")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6001833")]
    [Address(RVA = "0x248FF90", Offset = "0x248FF90", VA = "0x248FF90")]
    public Durability(int current, int max)
    {
    }
  }
}
