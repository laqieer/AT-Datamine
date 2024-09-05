// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestTimeZoneElapsedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B4")]
  [Serializable]
  public sealed class StoryMainQuestTimeZoneElapsedData : IMasterDataEntity
  {
    [Token(Token = "0x400590D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400590E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string label;
    [Token(Token = "0x400590F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4005910")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int paramID;

    [Token(Token = "0x1700100B")]
    public int Key
    {
      [Token(Token = "0x6006A2D"), Address(RVA = "0x48D6FEC", Offset = "0x48D6FEC", VA = "0x48D6FEC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A2E")]
    [Address(RVA = "0x48D6FF4", Offset = "0x48D6FF4", VA = "0x48D6FF4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A2F")]
    [Address(RVA = "0x48D71C0", Offset = "0x48D71C0", VA = "0x48D71C0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A30")]
    [Address(RVA = "0x48D7268", Offset = "0x48D7268", VA = "0x48D7268")]
    public StoryMainQuestTimeZoneElapsedData()
    {
    }
  }
}
