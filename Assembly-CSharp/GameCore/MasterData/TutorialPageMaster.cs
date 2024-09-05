// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TutorialPageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001320")]
  [Serializable]
  public sealed class TutorialPageMaster : BaseMaster<TutorialPageData>
  {
    [Token(Token = "0x4005A68")]
    public const string TEXT_AB = "text_masterdata_tutorial";

    [Token(Token = "0x6006BFD")]
    [Address(RVA = "0x48E781C", Offset = "0x48E781C", VA = "0x48E781C")]
    public IReadOnlyDictionary<int, TutorialPageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TutorialPageData>) null;
    }

    [Token(Token = "0x6006BFE")]
    [Address(RVA = "0x48E7824", Offset = "0x48E7824", VA = "0x48E7824", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BFF")]
    [Address(RVA = "0x48E7884", Offset = "0x48E7884", VA = "0x48E7884", Slot = "5")]
    protected override TutorialPageData LoadEntity(IMasterDataReader reader)
    {
      return (TutorialPageData) null;
    }

    [Token(Token = "0x6006C00")]
    [Address(RVA = "0x48E78DC", Offset = "0x48E78DC", VA = "0x48E78DC")]
    public TutorialPageMaster()
    {
    }
  }
}
