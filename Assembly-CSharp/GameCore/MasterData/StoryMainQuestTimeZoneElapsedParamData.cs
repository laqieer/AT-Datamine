// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestTimeZoneElapsedParamData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B2")]
  [Serializable]
  public sealed class StoryMainQuestTimeZoneElapsedParamData : IMasterDataEntity
  {
    [Token(Token = "0x400590A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400590B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string label;
    [Token(Token = "0x400590C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int imageID;

    [Token(Token = "0x1700100A")]
    public int Key
    {
      [Token(Token = "0x6006A25"), Address(RVA = "0x48D6CD0", Offset = "0x48D6CD0", VA = "0x48D6CD0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A26")]
    [Address(RVA = "0x48D6CD8", Offset = "0x48D6CD8", VA = "0x48D6CD8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A27")]
    [Address(RVA = "0x48D6E44", Offset = "0x48D6E44", VA = "0x48D6E44", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A28")]
    [Address(RVA = "0x48D6EDC", Offset = "0x48D6EDC", VA = "0x48D6EDC")]
    public StoryMainQuestTimeZoneElapsedParamData()
    {
    }
  }
}
