// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaSettingData
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
  [Token(Token = "0x2001243")]
  [Serializable]
  public sealed class StoryFreeActionAreaSettingData : IMasterDataEntity, ILocationCollectData
  {
    [Token(Token = "0x4005763")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005764")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int AreaSettingLabel;
    [Token(Token = "0x4005765")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int Area;
    [Token(Token = "0x4005766")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int BackGround;
    [Token(Token = "0x4005767")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int MovableSetting;
    [Token(Token = "0x4005768")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string BGMBank;
    [Token(Token = "0x4005769")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string BGMEvent;
    [Token(Token = "0x400576A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string BGMSubEvent;
    [Token(Token = "0x400576B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int MinimapID;
    [Token(Token = "0x400576C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int Introduction;
    [Token(Token = "0x400576D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public bool isIndoor;

    [Token(Token = "0x17000F9F")]
    public int Key
    {
      [Token(Token = "0x60067D4"), Address(RVA = "0x4D3329C", Offset = "0x4D3329C", VA = "0x4D3329C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067D5")]
    [Address(RVA = "0x4D332A4", Offset = "0x4D332A4", VA = "0x4D332A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067D6")]
    [Address(RVA = "0x4D33714", Offset = "0x4D33714", VA = "0x4D33714", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60067D7")]
    [Address(RVA = "0x4D33834", Offset = "0x4D33834", VA = "0x4D33834", Slot = "19")]
    public FreeMapAreaBGMData CreateBGMData() => new FreeMapAreaBGMData();

    [Token(Token = "0x17000FA0")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EBackGroundID
    {
      [Token(Token = "0x60067D8"), Address(RVA = "0x4D33848", Offset = "0x4D33848", VA = "0x4D33848", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA1")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EPlacementID
    {
      [Token(Token = "0x60067D9"), Address(RVA = "0x4D338FC", Offset = "0x4D338FC", VA = "0x4D338FC", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA2")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002ECameraFieldID
    {
      [Token(Token = "0x60067DA"), Address(RVA = "0x4D33914", Offset = "0x4D33914", VA = "0x4D33914", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA3")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EMovableRouteID
    {
      [Token(Token = "0x60067DB"), Address(RVA = "0x4D3392C", Offset = "0x4D3392C", VA = "0x4D3392C", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA4")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002ETransitionAreaID
    {
      [Token(Token = "0x60067DC"), Address(RVA = "0x4D33944", Offset = "0x4D33944", VA = "0x4D33944", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA5")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EUniqueObjectSettingLabel
    {
      [Token(Token = "0x60067DD"), Address(RVA = "0x4D3395C", Offset = "0x4D3395C", VA = "0x4D3395C", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA6")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EEnvironmentalSoundID
    {
      [Token(Token = "0x60067DE"), Address(RVA = "0x4D33974", Offset = "0x4D33974", VA = "0x4D33974", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA7")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EAreaID
    {
      [Token(Token = "0x60067DF"), Address(RVA = "0x4D3398C", Offset = "0x4D3398C", VA = "0x4D3398C", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA8")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EMinimapID
    {
      [Token(Token = "0x60067E0"), Address(RVA = "0x4D33994", Offset = "0x4D33994", VA = "0x4D33994", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FA9")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EMovableSettingID
    {
      [Token(Token = "0x60067E1"), Address(RVA = "0x4D3399C", Offset = "0x4D3399C", VA = "0x4D3399C", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FAA")]
    private int FreeMap\u002EData\u002EILocationCollectData\u002EIntroductionTableID
    {
      [Token(Token = "0x60067E2"), Address(RVA = "0x4D339A4", Offset = "0x4D339A4", VA = "0x4D339A4", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FAB")]
    private bool FreeMap\u002EData\u002EILocationCollectData\u002EIsIndoor
    {
      [Token(Token = "0x60067E3"), Address(RVA = "0x4D339AC", Offset = "0x4D339AC", VA = "0x4D339AC", Slot = "18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000FAC")]
    public StoryFreeActionBackgroundData BackgroundData
    {
      [Token(Token = "0x60067E4"), Address(RVA = "0x4D33860", Offset = "0x4D33860", VA = "0x4D33860")] get
      {
        return (StoryFreeActionBackgroundData) null;
      }
    }

    [Token(Token = "0x17000FAD")]
    public StoryFreeActionMinimapData MinimapData
    {
      [Token(Token = "0x60067E5"), Address(RVA = "0x4D339B4", Offset = "0x4D339B4", VA = "0x4D339B4")] get
      {
        return (StoryFreeActionMinimapData) null;
      }
    }

    [Token(Token = "0x60067E6")]
    [Address(RVA = "0x4D33A50", Offset = "0x4D33A50", VA = "0x4D33A50")]
    public StoryFreeActionAreaSettingData()
    {
    }
  }
}
