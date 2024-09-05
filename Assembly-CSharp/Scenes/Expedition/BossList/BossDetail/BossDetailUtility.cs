// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.BossDetailUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D38")]
  public static class BossDetailUtility
  {
    [Token(Token = "0x400C1E9")]
    [FieldOffset(Offset = "0x0")]
    private const Decimal FACTOR_BATTLE_SUPERIORITY = 1.35M;

    [Token(Token = "0x6011AEA")]
    [Address(RVA = "0x42B0380", Offset = "0x42B0380", VA = "0x42B0380")]
    public static BattleSuperiority CalcBattleSuperiority(int ownPower, int recommendPower)
    {
      return new BattleSuperiority();
    }

    [Token(Token = "0x6011AEB")]
    [Address(RVA = "0x42B049C", Offset = "0x42B049C", VA = "0x42B049C")]
    static BossDetailUtility()
    {
    }
  }
}
