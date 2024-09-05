// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.MnemnographMedalModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003C00")]
  public class MnemnographMedalModel
  {
    [Token(Token = "0x40109D7")]
    private const int ConversionCountMax = 999;
    [Token(Token = "0x40109D8")]
    public const int ConversionCountMin = 1;
    [Token(Token = "0x40109DB")]
    [FieldOffset(Offset = "0x20")]
    private readonly MindEquipment _mindEquipment;
    [Token(Token = "0x40109DC")]
    [FieldOffset(Offset = "0x28")]
    private readonly int _medalExchangeId;
    [Token(Token = "0x40109DD")]
    [FieldOffset(Offset = "0x2C")]
    private readonly int _medalExchangeValue;
    [Token(Token = "0x40109DE")]
    [FieldOffset(Offset = "0x30")]
    private int _conversionCount;

    [Token(Token = "0x6017952")]
    [Address(RVA = "0x237D26C", Offset = "0x237D26C", VA = "0x237D26C")]
    public MnemnographMedalModel(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x17004C9E")]
    public int ConversionCount
    {
      [Token(Token = "0x6017953"), Address(RVA = "0x237D42C", Offset = "0x237D42C", VA = "0x237D42C")] get
      {
        return new int();
      }
      [Token(Token = "0x6017954"), Address(RVA = "0x237D434", Offset = "0x237D434", VA = "0x237D434")] set
      {
      }
    }

    [Token(Token = "0x17004C9F")]
    public Action<int> OnChangeCoversionCount
    {
      [Token(Token = "0x6017955"), Address(RVA = "0x237D538", Offset = "0x237D538", VA = "0x237D538")] private get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6017956"), Address(RVA = "0x237D540", Offset = "0x237D540", VA = "0x237D540")] set
      {
      }
    }

    [Token(Token = "0x17004CA0")]
    public int CapConversionCountMax
    {
      [Token(Token = "0x6017957"), Address(RVA = "0x237D548", Offset = "0x237D548", VA = "0x237D548")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004CA1")]
    public Action<ConversionContext> OnSuccessConvertion
    {
      [Token(Token = "0x6017958"), Address(RVA = "0x237D5B4", Offset = "0x237D5B4", VA = "0x237D5B4")] get
      {
        return (Action<ConversionContext>) null;
      }
      [Token(Token = "0x6017959"), Address(RVA = "0x237D5BC", Offset = "0x237D5BC", VA = "0x237D5BC")] set
      {
      }
    }

    [Token(Token = "0x17004CA2")]
    public MedalData MedalData
    {
      [Token(Token = "0x601795A"), Address(RVA = "0x237D5C4", Offset = "0x237D5C4", VA = "0x237D5C4")] get
      {
        return (MedalData) null;
      }
    }

    [Token(Token = "0x17004CA3")]
    public int MedalExchangeValue
    {
      [Token(Token = "0x601795B"), Address(RVA = "0x237D660", Offset = "0x237D660", VA = "0x237D660")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601795C")]
    [Address(RVA = "0x237D668", Offset = "0x237D668", VA = "0x237D668")]
    public void IncConversionCount()
    {
    }

    [Token(Token = "0x601795D")]
    [Address(RVA = "0x237D674", Offset = "0x237D674", VA = "0x237D674")]
    public void IncConversionCountToMax()
    {
    }

    [Token(Token = "0x601795E")]
    [Address(RVA = "0x237D690", Offset = "0x237D690", VA = "0x237D690")]
    public void DecConversionCount()
    {
    }

    [Token(Token = "0x601795F")]
    [Address(RVA = "0x237D69C", Offset = "0x237D69C", VA = "0x237D69C")]
    public void DecConversionCountToMin()
    {
    }

    [Token(Token = "0x6017960")]
    [Address(RVA = "0x237D6A4", Offset = "0x237D6A4", VA = "0x237D6A4")]
    public IEnumerator OnConversion() => (IEnumerator) null;

    [Token(Token = "0x6017961")]
    [Address(RVA = "0x237D438", Offset = "0x237D438", VA = "0x237D438")]
    private void SetConversionCount(int count)
    {
    }

    [Token(Token = "0x6017962")]
    [Address(RVA = "0x237D2AC", Offset = "0x237D2AC", VA = "0x237D2AC")]
    private (int, int) GetExchangeData() => ();

    [Token(Token = "0x6017963")]
    [Address(RVA = "0x237D734", Offset = "0x237D734", VA = "0x237D734")]
    private MedalItem PlayerMedal() => (MedalItem) null;
  }
}
