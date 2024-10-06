// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionAreaSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001076")]
  [Serializable]
  public sealed class LobbyFreeActionAreaSettingData : IMasterDataEntity, ILocationCollectData
  {
    [Token(Token = "0x4005162")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005163")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int areaSettingLabel;
    [Token(Token = "0x4005164")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionID;
    [Token(Token = "0x4005165")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int backGroundID;
    [Token(Token = "0x4005166")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int playerID;
    [Token(Token = "0x4005167")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string startAnchorName;
    [Token(Token = "0x4005168")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string bgmBank;
    [Token(Token = "0x4005169")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string bgmEvent;
    [Token(Token = "0x400516A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string bgmSubEvent;

    [Token(Token = "0x17000E2B")]
    public int Key
    {
      [Token(Token = "0x6005F6C"), Address(RVA = "0x28CE1D0", Offset = "0x28CE1D0", VA = "0x28CE1D0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F6D")]
    [Address(RVA = "0x28CE1D8", Offset = "0x28CE1D8", VA = "0x28CE1D8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F6E")]
    [Address(RVA = "0x28CE584", Offset = "0x28CE584", VA = "0x28CE584", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005F6F")]
    [Address(RVA = "0x28CE688", Offset = "0x28CE688", VA = "0x28CE688", Slot = "19")]
    public FreeMapAreaBGMData CreateBGMData() => new FreeMapAreaBGMData();

    [Token(Token = "0x17000E2C")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EBackGroundID
    {
      [Token(Token = "0x6005F70"), Address(RVA = "0x28CE69C", Offset = "0x28CE69C", VA = "0x28CE69C", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E2D")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EPlacementID
    {
      [Token(Token = "0x6005F71"), Address(RVA = "0x28CE750", Offset = "0x28CE750", VA = "0x28CE750", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E2E")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002ECameraFieldID
    {
      [Token(Token = "0x6005F72"), Address(RVA = "0x28CE768", Offset = "0x28CE768", VA = "0x28CE768", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E2F")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EMovableRouteID
    {
      [Token(Token = "0x6005F73"), Address(RVA = "0x28CE780", Offset = "0x28CE780", VA = "0x28CE780", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E30")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002ETransitionAreaID
    {
      [Token(Token = "0x6005F74"), Address(RVA = "0x28CE798", Offset = "0x28CE798", VA = "0x28CE798", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E31")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EEnvironmentalSoundID
    {
      [Token(Token = "0x6005F75"), Address(RVA = "0x28CE7B0", Offset = "0x28CE7B0", VA = "0x28CE7B0", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E32")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EAreaID
    {
      [Token(Token = "0x6005F76"), Address(RVA = "0x28CE7C8", Offset = "0x28CE7C8", VA = "0x28CE7C8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E33")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EMinimapID
    {
      [Token(Token = "0x6005F77"), Address(RVA = "0x28CE7D0", Offset = "0x28CE7D0", VA = "0x28CE7D0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E34")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EUniqueObjectSettingLabel
    {
      [Token(Token = "0x6005F78"), Address(RVA = "0x28CE7D8", Offset = "0x28CE7D8", VA = "0x28CE7D8", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E35")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EMovableSettingID
    {
      [Token(Token = "0x6005F79"), Address(RVA = "0x28CE7E0", Offset = "0x28CE7E0", VA = "0x28CE7E0", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E36")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EIntroductionTableID
    {
      [Token(Token = "0x6005F7A"), Address(RVA = "0x28CE7E8", Offset = "0x28CE7E8", VA = "0x28CE7E8", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E37")]
    private bool FreeMap\u002EData\u002EILocationCollectData\u002EIsIndoor
    {
      [Token(Token = "0x6005F7B"), Address(RVA = "0x28CE7F0", Offset = "0x28CE7F0", VA = "0x28CE7F0", Slot = "18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E38")]
    public StoryFreeActionBackgroundData BackgroundData
    {
      [Token(Token = "0x6005F7C"), Address(RVA = "0x28CE6B4", Offset = "0x28CE6B4", VA = "0x28CE6B4")] get
      {
        return (StoryFreeActionBackgroundData) null;
      }
    }

    [Token(Token = "0x6005F7D")]
    [Address(RVA = "0x28CE7F8", Offset = "0x28CE7F8", VA = "0x28CE7F8")]
    public LobbyFreeActionAreaSettingData()
    {
    }
  }
}
