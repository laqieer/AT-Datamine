// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableSingleMobInstanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Instance;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using System;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200283C")]
  [Serializable]
  public class MovableSingleMobInstanceData : MovableMobInstanceDataBase
  {
    [Token(Token = "0x400AB8F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject modelObject;
    [Token(Token = "0x400AB90")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AnimationClip animationClip;
    [Token(Token = "0x400AB91")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject soundObject;
    [Token(Token = "0x400AB92")]
    [FieldOffset(Offset = "0x30")]
    private string[] soundEvents;
    [Token(Token = "0x400AB93")]
    [FieldOffset(Offset = "0x38")]
    private GameObject[] propObjects;
    [Token(Token = "0x400AB94")]
    [FieldOffset(Offset = "0x40")]
    private PropSettingData[] propSettings;
    [Token(Token = "0x400AB95")]
    [FieldOffset(Offset = "0x48")]
    private StoryCharacterLookWeatherTypeEnum lookWeatherType;

    [Token(Token = "0x170037AE")]
    public GameObject MobelObject
    {
      [Token(Token = "0x600FD4C"), Address(RVA = "0x442E12C", Offset = "0x442E12C", VA = "0x442E12C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170037AF")]
    public AnimationClip AnimatonClip
    {
      [Token(Token = "0x600FD4D"), Address(RVA = "0x442E134", Offset = "0x442E134", VA = "0x442E134")] get
      {
        return (AnimationClip) null;
      }
    }

    [Token(Token = "0x170037B0")]
    public string FirstAnimationName
    {
      [Token(Token = "0x600FD4E"), Address(RVA = "0x442E13C", Offset = "0x442E13C", VA = "0x442E13C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037B1")]
    public GameObject SoundObject
    {
      [Token(Token = "0x600FD4F"), Address(RVA = "0x442E1E0", Offset = "0x442E1E0", VA = "0x442E1E0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170037B2")]
    public string[] SoundEvents
    {
      [Token(Token = "0x600FD50"), Address(RVA = "0x442E1E8", Offset = "0x442E1E8", VA = "0x442E1E8")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x170037B3")]
    public GameObject[] PropObjects
    {
      [Token(Token = "0x600FD51"), Address(RVA = "0x442E1F0", Offset = "0x442E1F0", VA = "0x442E1F0")] get
      {
        return (GameObject[]) null;
      }
    }

    [Token(Token = "0x170037B4")]
    public PropSettingData[] PropSettings
    {
      [Token(Token = "0x600FD52"), Address(RVA = "0x442E1F8", Offset = "0x442E1F8", VA = "0x442E1F8")] get
      {
        return (PropSettingData[]) null;
      }
    }

    [Token(Token = "0x170037B5")]
    public StoryCharacterLookWeatherTypeEnum LookWeatherType
    {
      [Token(Token = "0x600FD53"), Address(RVA = "0x442E200", Offset = "0x442E200", VA = "0x442E200")] get
      {
        return new StoryCharacterLookWeatherTypeEnum();
      }
    }

    [Token(Token = "0x170037B6")]
    public string ModelName
    {
      [Token(Token = "0x600FD54"), Address(RVA = "0x442E208", Offset = "0x442E208", VA = "0x442E208")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600FD55")]
    [Address(RVA = "0x442E2AC", Offset = "0x442E2AC", VA = "0x442E2AC")]
    public MovableSingleMobInstanceData(
      GameObject model,
      AnimationClip clip,
      GameObject soundObject,
      string[] soundEvents,
      GameObject[] propObjects,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      PropSettingData[] propSettings)
    {
    }

    [Token(Token = "0x600FD56")]
    [Address(RVA = "0x442E310", Offset = "0x442E310", VA = "0x442E310", Slot = "4")]
    public override MovableMobType GetMobType() => new MovableMobType();

    [Token(Token = "0x600FD57")]
    [Address(RVA = "0x442E318", Offset = "0x442E318", VA = "0x442E318", Slot = "5")]
    public override MovableMobInstanceBase CreateInstance(
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player)
    {
      return (MovableMobInstanceBase) null;
    }
  }
}
