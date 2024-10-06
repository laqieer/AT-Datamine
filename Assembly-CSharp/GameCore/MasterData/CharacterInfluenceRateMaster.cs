// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterInfluenceRateMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001362")]
  [Serializable]
  public sealed class CharacterInfluenceRateMaster : BaseMaster<CharacterInfluenceRateData>
  {
    [Token(Token = "0x6006D2E")]
    [Address(RVA = "0x46FA82C", Offset = "0x46FA82C", VA = "0x46FA82C")]
    public IReadOnlyDictionary<int, CharacterInfluenceRateData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CharacterInfluenceRateData>) null;
    }

    [Token(Token = "0x6006D2F")]
    [Address(RVA = "0x46FA834", Offset = "0x46FA834", VA = "0x46FA834", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D30")]
    [Address(RVA = "0x46FA894", Offset = "0x46FA894", VA = "0x46FA894", Slot = "5")]
    protected override CharacterInfluenceRateData LoadEntity(IMasterDataReader reader)
    {
      return (CharacterInfluenceRateData) null;
    }

    [Token(Token = "0x6006D31")]
    [Address(RVA = "0x46FA8EC", Offset = "0x46FA8EC", VA = "0x46FA8EC")]
    public CharacterInfluenceRateData GetByLevel(int rank) => (CharacterInfluenceRateData) null;

    [Token(Token = "0x6006D32")]
    [Address(RVA = "0x46FACF4", Offset = "0x46FACF4", VA = "0x46FACF4")]
    public CharacterInfluenceRateMaster()
    {
    }
  }
}
