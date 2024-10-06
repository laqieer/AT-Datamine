// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryHumanParameterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E3")]
  [Serializable]
  public sealed class StoryHumanParameterMaster : BaseMaster<StoryHumanParameterData>
  {
    [Token(Token = "0x6006AED")]
    [Address(RVA = "0x48DDBD0", Offset = "0x48DDBD0", VA = "0x48DDBD0")]
    public IReadOnlyDictionary<int, StoryHumanParameterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryHumanParameterData>) null;
    }

    [Token(Token = "0x6006AEE")]
    [Address(RVA = "0x48DDBD8", Offset = "0x48DDBD8", VA = "0x48DDBD8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AEF")]
    [Address(RVA = "0x48DDC38", Offset = "0x48DDC38", VA = "0x48DDC38", Slot = "5")]
    protected override StoryHumanParameterData LoadEntity(IMasterDataReader reader)
    {
      return (StoryHumanParameterData) null;
    }

    [Token(Token = "0x6006AF0")]
    [Address(RVA = "0x48DDC90", Offset = "0x48DDC90", VA = "0x48DDC90")]
    public StoryHumanParameterData[] GetHumamParameterByChapterID(int chapterId)
    {
      return (StoryHumanParameterData[]) null;
    }

    [Token(Token = "0x6006AF1")]
    [Address(RVA = "0x48DDDB4", Offset = "0x48DDDB4", VA = "0x48DDDB4")]
    public StoryHumanParameterMaster()
    {
    }
  }
}
