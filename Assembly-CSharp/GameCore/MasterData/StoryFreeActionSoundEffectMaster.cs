// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSoundEffectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200127D")]
  [Serializable]
  public sealed class StoryFreeActionSoundEffectMaster : BaseMaster<StoryFreeActionSoundEffectData>
  {
    [Token(Token = "0x4005864")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionSoundEffectData>> groupingTable;

    [Token(Token = "0x600691A")]
    [Address(RVA = "0x48CCD14", Offset = "0x48CCD14", VA = "0x48CCD14")]
    public IReadOnlyDictionary<int, StoryFreeActionSoundEffectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionSoundEffectData>) null;
    }

    [Token(Token = "0x600691B")]
    [Address(RVA = "0x48CCD1C", Offset = "0x48CCD1C", VA = "0x48CCD1C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600691C")]
    [Address(RVA = "0x48CCDD4", Offset = "0x48CCDD4", VA = "0x48CCDD4", Slot = "5")]
    protected override StoryFreeActionSoundEffectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionSoundEffectData) null;
    }

    [Token(Token = "0x600691D")]
    [Address(RVA = "0x48CCD84", Offset = "0x48CCD84", VA = "0x48CCD84")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x600691E")]
    [Address(RVA = "0x48CCE44", Offset = "0x48CCE44", VA = "0x48CCE44")]
    private void OnLoadEntity(StoryFreeActionSoundEffectData entity)
    {
    }

    [Token(Token = "0x600691F")]
    [Address(RVA = "0x48CCFC0", Offset = "0x48CCFC0", VA = "0x48CCFC0")]
    public IReadOnlyList<StoryFreeActionSoundEffectData> GetAreaSettingDataListByLabel(int label)
    {
      return (IReadOnlyList<StoryFreeActionSoundEffectData>) null;
    }

    [Token(Token = "0x6006920")]
    [Address(RVA = "0x48CD07C", Offset = "0x48CD07C", VA = "0x48CD07C")]
    public StoryFreeActionSoundEffectMaster()
    {
    }
  }
}
