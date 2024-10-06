// Decompiled with JetBrains decompiler
// Type: Battle.Data.TroopsDataSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002733")]
  public struct TroopsDataSource : ITroopsData
  {
    [Token(Token = "0x400A7A3")]
    [FieldOffset(Offset = "0x0")]
    private int troops;
    [Token(Token = "0x400A7A4")]
    [FieldOffset(Offset = "0x4")]
    private bool initial;
    [Token(Token = "0x400A7A5")]
    [FieldOffset(Offset = "0x5")]
    private bool quick;

    [Token(Token = "0x1700342D")]
    public static ITroopsData Empty
    {
      [Token(Token = "0x600F436"), Address(RVA = "0x1FA86EC", Offset = "0x1FA86EC", VA = "0x1FA86EC")] get
      {
        return (ITroopsData) null;
      }
    }

    [Token(Token = "0x1700342E")]
    public int Troops
    {
      [Token(Token = "0x600F437"), Address(RVA = "0x1FA873C", Offset = "0x1FA873C", VA = "0x1FA873C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700342F")]
    public bool IsInitial
    {
      [Token(Token = "0x600F438"), Address(RVA = "0x1FA8744", Offset = "0x1FA8744", VA = "0x1FA8744", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003430")]
    public bool IsQuick
    {
      [Token(Token = "0x600F439"), Address(RVA = "0x1FA874C", Offset = "0x1FA874C", VA = "0x1FA874C", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F43A")]
    [Address(RVA = "0x1FA8388", Offset = "0x1FA8388", VA = "0x1FA8388")]
    public TroopsDataSource(int troops, bool initial, bool quick)
    {
    }
  }
}
