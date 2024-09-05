// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceRouteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E8")]
  [Serializable]
  public sealed class StoryMainQuestSequenceRouteData : IMasterDataEntity
  {
    [Token(Token = "0x40059A2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059A3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sequenceID;
    [Token(Token = "0x40059A4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int routeID;

    [Token(Token = "0x1700102C")]
    public int Key
    {
      [Token(Token = "0x6006B06"), Address(RVA = "0x48DE7CC", Offset = "0x48DE7CC", VA = "0x48DE7CC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B07")]
    [Address(RVA = "0x48DE7D4", Offset = "0x48DE7D4", VA = "0x48DE7D4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B08")]
    [Address(RVA = "0x48DE940", Offset = "0x48DE940", VA = "0x48DE940", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B09")]
    [Address(RVA = "0x48DE9D4", Offset = "0x48DE9D4", VA = "0x48DE9D4")]
    public StoryMainQuestSequenceRouteData()
    {
    }
  }
}
