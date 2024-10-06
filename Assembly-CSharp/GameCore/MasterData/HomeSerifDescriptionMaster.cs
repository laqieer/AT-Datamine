// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeSerifDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001028")]
  [Serializable]
  public sealed class HomeSerifDescriptionMaster : BaseMaster<HomeSerifDescriptionData>
  {
    [Token(Token = "0x400503E")]
    public const string TEXT_AB = "text_masterdata_home";

    [Token(Token = "0x6005E00")]
    [Address(RVA = "0x27990E8", Offset = "0x27990E8", VA = "0x27990E8")]
    public IReadOnlyDictionary<int, HomeSerifDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, HomeSerifDescriptionData>) null;
    }

    [Token(Token = "0x6005E01")]
    [Address(RVA = "0x27990F0", Offset = "0x27990F0", VA = "0x27990F0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E02")]
    [Address(RVA = "0x2799150", Offset = "0x2799150", VA = "0x2799150", Slot = "5")]
    protected override HomeSerifDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (HomeSerifDescriptionData) null;
    }

    [Token(Token = "0x6005E03")]
    [Address(RVA = "0x27991A8", Offset = "0x27991A8", VA = "0x27991A8")]
    public HomeSerifDescriptionMaster()
    {
    }
  }
}
