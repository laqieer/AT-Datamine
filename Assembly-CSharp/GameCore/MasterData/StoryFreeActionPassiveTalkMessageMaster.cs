// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPassiveTalkMessageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200126B")]
  [Serializable]
  public sealed class StoryFreeActionPassiveTalkMessageMaster : 
    BaseMaster<StoryFreeActionPassiveTalkMessageData>
  {
    [Token(Token = "0x4005819")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x60068B4")]
    [Address(RVA = "0x48C9264", Offset = "0x48C9264", VA = "0x48C9264")]
    public IReadOnlyDictionary<int, StoryFreeActionPassiveTalkMessageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionPassiveTalkMessageData>) null;
    }

    [Token(Token = "0x60068B5")]
    [Address(RVA = "0x48C926C", Offset = "0x48C926C", VA = "0x48C926C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068B6")]
    [Address(RVA = "0x48C92CC", Offset = "0x48C92CC", VA = "0x48C92CC", Slot = "5")]
    protected override StoryFreeActionPassiveTalkMessageData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionPassiveTalkMessageData) null;
    }

    [Token(Token = "0x60068B7")]
    [Address(RVA = "0x48C9324", Offset = "0x48C9324", VA = "0x48C9324")]
    public StoryFreeActionPassiveTalkMessageMaster()
    {
    }
  }
}
