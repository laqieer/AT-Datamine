// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvPersonalUpTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DBD")]
  [Serializable]
  public sealed class AdvPersonalUpTypeMaster : BaseMaster<AdvPersonalUpTypeData>
  {
    [Token(Token = "0x40041BF")]
    public const int InvalidTrackNum = -1;

    [Token(Token = "0x6005405")]
    [Address(RVA = "0x3AA0494", Offset = "0x3AA0494", VA = "0x3AA0494")]
    public IReadOnlyDictionary<int, AdvPersonalUpTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvPersonalUpTypeData>) null;
    }

    [Token(Token = "0x6005406")]
    [Address(RVA = "0x3AA049C", Offset = "0x3AA049C", VA = "0x3AA049C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005407")]
    [Address(RVA = "0x3AA04FC", Offset = "0x3AA04FC", VA = "0x3AA04FC", Slot = "5")]
    protected override AdvPersonalUpTypeData LoadEntity(IMasterDataReader reader)
    {
      return (AdvPersonalUpTypeData) null;
    }

    [Token(Token = "0x6005408")]
    [Address(RVA = "0x3AA0554", Offset = "0x3AA0554", VA = "0x3AA0554")]
    public AdvPersonalUpTypeData GetDataByExpRange(int exp) => (AdvPersonalUpTypeData) null;

    [Token(Token = "0x6005409")]
    [Address(RVA = "0x3AA06D8", Offset = "0x3AA06D8", VA = "0x3AA06D8")]
    public AdvPersonalUpTypeMaster()
    {
    }
  }
}
