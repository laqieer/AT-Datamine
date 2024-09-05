// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookEffectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D5")]
  [Serializable]
  public sealed class StoryBookEffectMaster : BaseMaster<StoryBookEffectData>
  {
    [Token(Token = "0x400596B")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006AAA")]
    [Address(RVA = "0x48DB25C", Offset = "0x48DB25C", VA = "0x48DB25C")]
    public IReadOnlyDictionary<int, StoryBookEffectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBookEffectData>) null;
    }

    [Token(Token = "0x6006AAB")]
    [Address(RVA = "0x48DB264", Offset = "0x48DB264", VA = "0x48DB264", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AAC")]
    [Address(RVA = "0x48DB2C4", Offset = "0x48DB2C4", VA = "0x48DB2C4", Slot = "5")]
    protected override StoryBookEffectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBookEffectData) null;
    }

    [Token(Token = "0x6006AAD")]
    [Address(RVA = "0x48DB31C", Offset = "0x48DB31C", VA = "0x48DB31C")]
    public StoryBookEffectMaster()
    {
    }
  }
}
