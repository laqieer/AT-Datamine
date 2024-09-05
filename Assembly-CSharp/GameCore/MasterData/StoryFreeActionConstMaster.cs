// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001252")]
  [Serializable]
  public sealed class StoryFreeActionConstMaster : BaseMaster<StoryFreeActionConstData>
  {
    [Token(Token = "0x600682F")]
    [Address(RVA = "0x4D36574", Offset = "0x4D36574", VA = "0x4D36574")]
    public IReadOnlyDictionary<int, StoryFreeActionConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionConstData>) null;
    }

    [Token(Token = "0x6006830")]
    [Address(RVA = "0x4D3657C", Offset = "0x4D3657C", VA = "0x4D3657C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006831")]
    [Address(RVA = "0x4D36658", Offset = "0x4D36658", VA = "0x4D36658", Slot = "5")]
    protected override StoryFreeActionConstData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionConstData) null;
    }

    [Token(Token = "0x6006832")]
    [Address(RVA = "0x4D365E4", Offset = "0x4D365E4", VA = "0x4D365E4")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000FB8")]
    public StoryFreeActionConstData Data
    {
      [Token(Token = "0x6006833"), Address(RVA = "0x4D366B0", Offset = "0x4D366B0", VA = "0x4D366B0")] get
      {
        return (StoryFreeActionConstData) null;
      }
      [Token(Token = "0x6006834"), Address(RVA = "0x4D366B8", Offset = "0x4D366B8", VA = "0x4D366B8")] private set
      {
      }
    }

    [Token(Token = "0x6006835")]
    [Address(RVA = "0x4D366C0", Offset = "0x4D366C0", VA = "0x4D366C0")]
    public StoryFreeActionConstMaster()
    {
    }
  }
}
