// Decompiled with JetBrains decompiler
// Type: GameCore.Utility.UnitNames
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Utility
{
  [Token(Token = "0x2000BD2")]
  public static class UnitNames
  {
    [Token(Token = "0x2000BD3")]
    private class CacheKey : IEquatable<UnitNames.CacheKey>
    {
      [Token(Token = "0x40035D3")]
      [FieldOffset(Offset = "0x10")]
      private int category;
      [Token(Token = "0x40035D4")]
      [FieldOffset(Offset = "0x14")]
      private int uniqueId;

      [Token(Token = "0x60043A5")]
      [Address(RVA = "0x36428F4", Offset = "0x36428F4", VA = "0x36428F4", Slot = "4")]
      private bool System\u002EIEquatable\u003CGameCore\u002EUtility\u002EUnitNames\u002ECacheKey\u003E\u002EEquals(
        UnitNames.CacheKey other)
      {
        return new bool();
      }

      [Token(Token = "0x60043A6")]
      [Address(RVA = "0x3642930", Offset = "0x3642930", VA = "0x3642930")]
      public CacheKey()
      {
      }
    }
  }
}
