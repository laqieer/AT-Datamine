// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardTermMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DEC")]
  [Serializable]
  public sealed class ArenaDailyRewardTermMaster : BaseMaster<ArenaDailyRewardTermData>
  {
    [Token(Token = "0x60054F6")]
    [Address(RVA = "0x3AA9C50", Offset = "0x3AA9C50", VA = "0x3AA9C50")]
    public IReadOnlyDictionary<int, ArenaDailyRewardTermData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaDailyRewardTermData>) null;
    }

    [Token(Token = "0x60054F7")]
    [Address(RVA = "0x3AA9C58", Offset = "0x3AA9C58", VA = "0x3AA9C58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054F8")]
    [Address(RVA = "0x3AA9CB8", Offset = "0x3AA9CB8", VA = "0x3AA9CB8", Slot = "5")]
    protected override ArenaDailyRewardTermData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaDailyRewardTermData) null;
    }

    [Token(Token = "0x60054F9")]
    [Address(RVA = "0x3AA9D10", Offset = "0x3AA9D10", VA = "0x3AA9D10")]
    public ArenaDailyRewardTermMaster()
    {
    }
  }
}
