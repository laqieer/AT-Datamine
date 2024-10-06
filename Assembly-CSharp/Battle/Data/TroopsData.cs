// Decompiled with JetBrains decompiler
// Type: Battle.Data.TroopsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002732")]
  public sealed class TroopsData
  {
    [Token(Token = "0x400A7A2")]
    [FieldOffset(Offset = "0x18")]
    private List<UnitParameterData> troopsUnits;

    [Token(Token = "0x17003428")]
    public ITroopsData Data
    {
      [Token(Token = "0x600F42D"), Address(RVA = "0x1FA8298", Offset = "0x1FA8298", VA = "0x1FA8298")] get
      {
        return (ITroopsData) null;
      }
      [Token(Token = "0x600F42E"), Address(RVA = "0x1FA82A0", Offset = "0x1FA82A0", VA = "0x1FA82A0")] private set
      {
      }
    }

    [Token(Token = "0x17003429")]
    public IReadOnlyList<UnitParameterData> TroopsUnits
    {
      [Token(Token = "0x600F42F"), Address(RVA = "0x1FA82A8", Offset = "0x1FA82A8", VA = "0x1FA82A8")] get
      {
        return (IReadOnlyList<UnitParameterData>) null;
      }
    }

    [Token(Token = "0x600F430")]
    [Address(RVA = "0x1FA82B0", Offset = "0x1FA82B0", VA = "0x1FA82B0")]
    public TroopsData(int troops, bool initial, bool quick)
    {
    }

    [Token(Token = "0x600F431")]
    [Address(RVA = "0x1FA83A0", Offset = "0x1FA83A0", VA = "0x1FA83A0")]
    public TroopsData(ITroopsData troopsInfo)
    {
    }

    [Token(Token = "0x1700342A")]
    public int TroopsNo
    {
      [Token(Token = "0x600F432"), Address(RVA = "0x1FA8430", Offset = "0x1FA8430", VA = "0x1FA8430")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700342B")]
    public bool IsInitial
    {
      [Token(Token = "0x600F433"), Address(RVA = "0x1FA84D0", Offset = "0x1FA84D0", VA = "0x1FA84D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700342C")]
    public bool IsQuick
    {
      [Token(Token = "0x600F434"), Address(RVA = "0x1FA8574", Offset = "0x1FA8574", VA = "0x1FA8574")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F435")]
    [Address(RVA = "0x1FA8618", Offset = "0x1FA8618", VA = "0x1FA8618")]
    public void AddTroopsUnit(UnitParameterData unit)
    {
    }
  }
}
