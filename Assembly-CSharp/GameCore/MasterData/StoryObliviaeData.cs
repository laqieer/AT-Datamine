// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryObliviaeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012CD")]
  [Serializable]
  public sealed class StoryObliviaeData : IMasterDataEntity
  {
    [Token(Token = "0x4005943")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005944")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005945")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x4005946")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int totalClearCount;
    [Token(Token = "0x4005947")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseStoryAbility;
    [Token(Token = "0x4005948")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int seasonBegin;
    [Token(Token = "0x4005949")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int seasonEnd;
    [Token(Token = "0x400594A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int medalShopID;

    [Token(Token = "0x17001016")]
    public int Key
    {
      [Token(Token = "0x6006A87"), Address(RVA = "0x48D984C", Offset = "0x48D984C", VA = "0x48D984C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A88")]
    [Address(RVA = "0x48D9854", Offset = "0x48D9854", VA = "0x48D9854", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A89")]
    [Address(RVA = "0x48D9BA0", Offset = "0x48D9BA0", VA = "0x48D9BA0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A8A")]
    [Address(RVA = "0x48D9C88", Offset = "0x48D9C88", VA = "0x48D9C88")]
    public StoryObliviaeData()
    {
    }
  }
}
