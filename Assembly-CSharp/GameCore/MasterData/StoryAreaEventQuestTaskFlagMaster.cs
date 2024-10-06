// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestTaskFlagMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E0")]
  [Serializable]
  public sealed class StoryAreaEventQuestTaskFlagMaster : BaseMaster<StoryAreaEventQuestTaskFlagData>
  {
    [Token(Token = "0x6006632")]
    [Address(RVA = "0x4D23268", Offset = "0x4D23268", VA = "0x4D23268")]
    public IReadOnlyDictionary<int, StoryAreaEventQuestTaskFlagData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaEventQuestTaskFlagData>) null;
    }

    [Token(Token = "0x6006633")]
    [Address(RVA = "0x4D23270", Offset = "0x4D23270", VA = "0x4D23270", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006634")]
    [Address(RVA = "0x4D232D0", Offset = "0x4D232D0", VA = "0x4D232D0", Slot = "5")]
    protected override StoryAreaEventQuestTaskFlagData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaEventQuestTaskFlagData) null;
    }

    [Token(Token = "0x6006635")]
    [Address(RVA = "0x4D23328", Offset = "0x4D23328", VA = "0x4D23328")]
    public StoryAreaEventQuestTaskFlagMaster()
    {
    }
  }
}
