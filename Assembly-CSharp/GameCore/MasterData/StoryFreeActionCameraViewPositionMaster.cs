// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionCameraViewPositionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200124A")]
  [Serializable]
  public sealed class StoryFreeActionCameraViewPositionMaster : 
    BaseMaster<StoryFreeActionCameraViewPositionData>
  {
    [Token(Token = "0x6006805")]
    [Address(RVA = "0x4D34F34", Offset = "0x4D34F34", VA = "0x4D34F34")]
    public IReadOnlyDictionary<int, StoryFreeActionCameraViewPositionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionCameraViewPositionData>) null;
    }

    [Token(Token = "0x6006806")]
    [Address(RVA = "0x4D34F3C", Offset = "0x4D34F3C", VA = "0x4D34F3C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006807")]
    [Address(RVA = "0x4D34F9C", Offset = "0x4D34F9C", VA = "0x4D34F9C", Slot = "5")]
    protected override StoryFreeActionCameraViewPositionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionCameraViewPositionData) null;
    }

    [Token(Token = "0x6006808")]
    [Address(RVA = "0x4D34FF4", Offset = "0x4D34FF4", VA = "0x4D34FF4")]
    public IReadOnlyCollection<StoryFreeActionCameraViewPositionData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionCameraViewPositionData>) null;
    }

    [Token(Token = "0x6006809")]
    [Address(RVA = "0x4D35044", Offset = "0x4D35044", VA = "0x4D35044")]
    public StoryFreeActionCameraViewPositionMaster()
    {
    }
  }
}
