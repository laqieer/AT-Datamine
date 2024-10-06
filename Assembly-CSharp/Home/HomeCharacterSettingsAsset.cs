// Decompiled with JetBrains decompiler
// Type: Home.HomeCharacterSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B28")]
  [CreateAssetMenu(menuName = "Home/Home Character Settings Asset")]
  public class HomeCharacterSettingsAsset : ScriptableObject
  {
    [Token(Token = "0x40032E6")]
    [FieldOffset(Offset = "0x18")]
    public DuelCharacterModelSettingsAsset characterModelSettingsAsset;
    [Token(Token = "0x40032E7")]
    [FieldOffset(Offset = "0x20")]
    public HomeCharacterBodyType bodyType;
    [Token(Token = "0x40032E8")]
    [FieldOffset(Offset = "0x24")]
    public HomeCharacterPersonalityType personalityType;
    [Token(Token = "0x40032E9")]
    [FieldOffset(Offset = "0x28")]
    public RuntimeAnimatorController overrideController;
    [Token(Token = "0x40032EA")]
    [FieldOffset(Offset = "0x30")]
    public List<TimelineAsset> overrideTimelineAssets;
    [Token(Token = "0x40032EB")]
    [FieldOffset(Offset = "0x38")]
    public TimelineAsset overrideLoginBonusTimelineAsset;
    [Token(Token = "0x40032EC")]
    [FieldOffset(Offset = "0x40")]
    public FacialAnimationSet facialAnimationSet;

    [Token(Token = "0x6003F66")]
    [Address(RVA = "0x2C1C69C", Offset = "0x2C1C69C", VA = "0x2C1C69C")]
    public HomeCharacterSettingsAsset()
    {
    }
  }
}
