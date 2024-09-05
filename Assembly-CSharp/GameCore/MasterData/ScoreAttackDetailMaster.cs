// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001132")]
  [Serializable]
  public sealed class ScoreAttackDetailMaster : BaseMaster<ScoreAttackDetailData>
  {
    [Token(Token = "0x60062F9")]
    [Address(RVA = "0x4AE42D0", Offset = "0x4AE42D0", VA = "0x4AE42D0")]
    public IReadOnlyDictionary<int, ScoreAttackDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackDetailData>) null;
    }

    [Token(Token = "0x60062FA")]
    [Address(RVA = "0x4AE42D8", Offset = "0x4AE42D8", VA = "0x4AE42D8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062FB")]
    [Address(RVA = "0x4AE4338", Offset = "0x4AE4338", VA = "0x4AE4338", Slot = "5")]
    protected override ScoreAttackDetailData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackDetailData) null;
    }

    [Token(Token = "0x60062FC")]
    [Address(RVA = "0x4AE4390", Offset = "0x4AE4390", VA = "0x4AE4390")]
    public ScoreAttackDetailMaster()
    {
    }
  }
}
