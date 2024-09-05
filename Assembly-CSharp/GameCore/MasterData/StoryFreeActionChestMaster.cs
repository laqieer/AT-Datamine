// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionChestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200124E")]
  [Serializable]
  public sealed class StoryFreeActionChestMaster : BaseMaster<StoryFreeActionChestData>
  {
    [Token(Token = "0x600681B")]
    [Address(RVA = "0x4D35B4C", Offset = "0x4D35B4C", VA = "0x4D35B4C")]
    public IReadOnlyDictionary<int, StoryFreeActionChestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionChestData>) null;
    }

    [Token(Token = "0x600681C")]
    [Address(RVA = "0x4D35B54", Offset = "0x4D35B54", VA = "0x4D35B54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600681D")]
    [Address(RVA = "0x4D35BB4", Offset = "0x4D35BB4", VA = "0x4D35BB4", Slot = "5")]
    protected override StoryFreeActionChestData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionChestData) null;
    }

    [Token(Token = "0x600681E")]
    [Address(RVA = "0x4D35C28", Offset = "0x4D35C28", VA = "0x4D35C28")]
    private void OnLoadEntity(StoryFreeActionChestData entity)
    {
    }

    [Token(Token = "0x600681F")]
    [Address(RVA = "0x4D35C60", Offset = "0x4D35C60", VA = "0x4D35C60")]
    public StoryFreeActionChestMaster()
    {
    }
  }
}
