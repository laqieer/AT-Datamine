// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBgTemplateData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D0")]
  [Serializable]
  public sealed class StoryBgTemplateData : IMasterDataEntity
  {
    [Token(Token = "0x400594E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400594F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bgArea;
    [Token(Token = "0x4005950")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int noonSunny;
    [Token(Token = "0x4005951")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int noonRain;
    [Token(Token = "0x4005952")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int noonSnow;
    [Token(Token = "0x4005953")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int noonCloudy;
    [Token(Token = "0x4005954")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int eveningSunny;
    [Token(Token = "0x4005955")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int eveningRain;
    [Token(Token = "0x4005956")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int eveningSnow;
    [Token(Token = "0x4005957")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int eveningCloudy;
    [Token(Token = "0x4005958")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int nightSunny;
    [Token(Token = "0x4005959")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int nightRain;
    [Token(Token = "0x400595A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int nightSnow;
    [Token(Token = "0x400595B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int nightCloudy;
    [Token(Token = "0x400595C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int eclipse;
    [Token(Token = "0x400595D")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int blizzard;
    [Token(Token = "0x400595E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int type;
    [Token(Token = "0x400595F")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int template;
    [Token(Token = "0x4005960")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int defaultMob;

    [Token(Token = "0x17001017")]
    public int Key
    {
      [Token(Token = "0x6006A94"), Address(RVA = "0x48DA084", Offset = "0x48DA084", VA = "0x48DA084", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A95")]
    [Address(RVA = "0x48DA08C", Offset = "0x48DA08C", VA = "0x48DA08C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A96")]
    [Address(RVA = "0x48DA7F8", Offset = "0x48DA7F8", VA = "0x48DA7F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A97")]
    [Address(RVA = "0x48DA98C", Offset = "0x48DA98C", VA = "0x48DA98C")]
    public StoryBgTemplateData()
    {
    }
  }
}
