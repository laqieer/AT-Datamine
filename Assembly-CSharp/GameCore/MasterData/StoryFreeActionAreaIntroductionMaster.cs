// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaIntroductionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200123E")]
  [Serializable]
  public sealed class StoryFreeActionAreaIntroductionMaster : 
    BaseMaster<StoryFreeActionAreaIntroductionData>
  {
    [Token(Token = "0x60067BA")]
    [Address(RVA = "0x4D323A0", Offset = "0x4D323A0", VA = "0x4D323A0")]
    public IReadOnlyDictionary<int, StoryFreeActionAreaIntroductionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionAreaIntroductionData>) null;
    }

    [Token(Token = "0x60067BB")]
    [Address(RVA = "0x4D323A8", Offset = "0x4D323A8", VA = "0x4D323A8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067BC")]
    [Address(RVA = "0x4D32408", Offset = "0x4D32408", VA = "0x4D32408", Slot = "5")]
    protected override StoryFreeActionAreaIntroductionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionAreaIntroductionData) null;
    }

    [Token(Token = "0x60067BD")]
    [Address(RVA = "0x4D32460", Offset = "0x4D32460", VA = "0x4D32460")]
    public StoryFreeActionAreaIntroductionMaster()
    {
    }
  }
}
