// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.CurrentFreeActionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.Scriptable;
using FreeMap.State;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x2001934")]
  public class CurrentFreeActionParam
  {
    [Token(Token = "0x4006C94")]
    [FieldOffset(Offset = "0x14")]
    private int freeactionSettingID;
    [Token(Token = "0x4006C97")]
    [FieldOffset(Offset = "0x20")]
    private Func<int, FreeMapPlacementObject> placementAccessor;

    [Token(Token = "0x6008F52")]
    [Address(RVA = "0x4B07C2C", Offset = "0x4B07C2C", VA = "0x4B07C2C")]
    public static CurrentFreeActionParam GetParam(FreeMapStateManager entity)
    {
      return (CurrentFreeActionParam) null;
    }

    [Token(Token = "0x6008F53")]
    [Address(RVA = "0x4B07F1C", Offset = "0x4B07F1C", VA = "0x4B07F1C")]
    public static CurrentFreeActionParam GetOtherSequenceParam(int sequenceID)
    {
      return (CurrentFreeActionParam) null;
    }

    [Token(Token = "0x6008F54")]
    [Address(RVA = "0x4B08090", Offset = "0x4B08090", VA = "0x4B08090")]
    private CurrentFreeActionParam()
    {
    }

    [Token(Token = "0x6008F55")]
    [Address(RVA = "0x4B07C8C", Offset = "0x4B07C8C", VA = "0x4B07C8C")]
    public CurrentFreeActionParam(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008F56")]
    [Address(RVA = "0x4B082E4", Offset = "0x4B082E4", VA = "0x4B082E4")]
    public bool CanCreate(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x17001702")]
    public int SequenceID
    {
      [Token(Token = "0x6008F57"), Address(RVA = "0x4B08308", Offset = "0x4B08308", VA = "0x4B08308")] get
      {
        return new int();
      }
      [Token(Token = "0x6008F58"), Address(RVA = "0x4B08310", Offset = "0x4B08310", VA = "0x4B08310")] private set
      {
      }
    }

    [Token(Token = "0x17001703")]
    public int AreaID
    {
      [Token(Token = "0x6008F59"), Address(RVA = "0x4B08318", Offset = "0x4B08318", VA = "0x4B08318")] get
      {
        return new int();
      }
      [Token(Token = "0x6008F5A"), Address(RVA = "0x4B08320", Offset = "0x4B08320", VA = "0x4B08320")] set
      {
      }
    }

    [Token(Token = "0x17001704")]
    public int StartAreaID
    {
      [Token(Token = "0x6008F5B"), Address(RVA = "0x4B08328", Offset = "0x4B08328", VA = "0x4B08328")] get
      {
        return new int();
      }
      [Token(Token = "0x6008F5C"), Address(RVA = "0x4B08330", Offset = "0x4B08330", VA = "0x4B08330")] private set
      {
      }
    }

    [Token(Token = "0x17001705")]
    public (Vector3 position, Quaternion way) Player
    {
      [Token(Token = "0x6008F5D"), Address(RVA = "0x4B08338", Offset = "0x4B08338", VA = "0x4B08338")] get
      {
        return ();
      }
      [Token(Token = "0x6008F5E"), Address(RVA = "0x4B0834C", Offset = "0x4B0834C", VA = "0x4B0834C")] private set
      {
      }
    }

    [Token(Token = "0x17001706")]
    public FreeMapParamList ParamList
    {
      [Token(Token = "0x6008F5F"), Address(RVA = "0x4B08368", Offset = "0x4B08368", VA = "0x4B08368")] get
      {
        return (FreeMapParamList) null;
      }
      [Token(Token = "0x6008F60"), Address(RVA = "0x4B08370", Offset = "0x4B08370", VA = "0x4B08370")] private set
      {
      }
    }

    [Token(Token = "0x6008F61")]
    [Address(RVA = "0x4B08378", Offset = "0x4B08378", VA = "0x4B08378")]
    public StoryFreeActionSettingData GetFreeActionSetting() => (StoryFreeActionSettingData) null;

    [Token(Token = "0x6008F62")]
    [Address(RVA = "0x4B08414", Offset = "0x4B08414", VA = "0x4B08414")]
    public IEnumerable<StoryFreeActionAreaSettingData> GetAreaSettings()
    {
      return (IEnumerable<StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x6008F63")]
    [Address(RVA = "0x4B08C74", Offset = "0x4B08C74", VA = "0x4B08C74")]
    public StoryFreeActionAreaSettingData GetAreaSettingData(int areaID)
    {
      return (StoryFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x6008F64")]
    [Address(RVA = "0x4B08D1C", Offset = "0x4B08D1C", VA = "0x4B08D1C")]
    public FreeMapPlacementObject GetPlacement(int areaID) => (FreeMapPlacementObject) null;

    [Token(Token = "0x6008F65")]
    [Address(RVA = "0x4B08D3C", Offset = "0x4B08D3C", VA = "0x4B08D3C")]
    public StoryMainQuestSequenceData GetSequence() => (StoryMainQuestSequenceData) null;

    [Token(Token = "0x6008F66")]
    [Address(RVA = "0x4B08DD8", Offset = "0x4B08DD8", VA = "0x4B08DD8")]
    public bool IsFreeAction() => new bool();
  }
}
