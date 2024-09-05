// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestYearData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B9")]
  [Serializable]
  public sealed class StoryMainQuestYearData : IMasterDataEntity
  {
    [Token(Token = "0x4005916")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005917")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005918")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int year;
    [Token(Token = "0x4005919")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int useTexture;

    [Token(Token = "0x1700100C")]
    public int Key
    {
      [Token(Token = "0x6006A3F"), Address(RVA = "0x48D7830", Offset = "0x48D7830", VA = "0x48D7830", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A40")]
    [Address(RVA = "0x48D7838", Offset = "0x48D7838", VA = "0x48D7838", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A41")]
    [Address(RVA = "0x48D7A04", Offset = "0x48D7A04", VA = "0x48D7A04", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700100D")]
    public string Text
    {
      [Token(Token = "0x6006A42"), Address(RVA = "0x48D7AAC", Offset = "0x48D7AAC", VA = "0x48D7AAC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700100E")]
    public string Era
    {
      [Token(Token = "0x6006A43"), Address(RVA = "0x48D7B88", Offset = "0x48D7B88", VA = "0x48D7B88")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006A44")]
    [Address(RVA = "0x48D7C64", Offset = "0x48D7C64", VA = "0x48D7C64")]
    public StoryMainQuestYearData()
    {
    }
  }
}
