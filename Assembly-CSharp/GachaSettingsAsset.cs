// Decompiled with JetBrains decompiler
// Type: GachaSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000201")]
[CreateAssetMenu(menuName = "Gacha/Gacha Settings Asset")]
public class GachaSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000BC9")]
  [FieldOffset(Offset = "0x18")]
  [Header("演出内容(3D)")]
  public DuelCharacterModelSettingsAsset mainCharacterModel;
  [Token(Token = "0x4000BCA")]
  [FieldOffset(Offset = "0x20")]
  public SexTypeEnum mainCharacterGender;
  [Token(Token = "0x4000BCB")]
  [FieldOffset(Offset = "0x24")]
  public bool showCatInCut01;
  [Token(Token = "0x4000BCC")]
  [FieldOffset(Offset = "0x28")]
  public GachaSettingsAsset.ColorPattern lineColor;
  [Token(Token = "0x4000BCD")]
  [FieldOffset(Offset = "0x2C")]
  public GachaSettingsAsset.ColorPattern monorisColor;
  [Token(Token = "0x4000BCE")]
  [FieldOffset(Offset = "0x30")]
  public GachaSettingsAsset.ColorPattern weaponColor;
  [Token(Token = "0x4000BCF")]
  [FieldOffset(Offset = "0x34")]
  public GachaSettingsAsset.ColorPattern rawImageColor;
  [Token(Token = "0x4000BD0")]
  [FieldOffset(Offset = "0x38")]
  public GachaSettingsAsset.ColorPattern stageEffectColor;
  [Token(Token = "0x4000BD1")]
  [FieldOffset(Offset = "0x3C")]
  public GachaSettingsAsset.ColorPattern weaponEffectColor;
  [Token(Token = "0x4000BD2")]
  [FieldOffset(Offset = "0x40")]
  public GachaSettingsAsset.ColorPattern bgEffectColor;
  [Token(Token = "0x4000BD3")]
  [FieldOffset(Offset = "0x44")]
  public GachaSettingsAsset.ColorPattern effBGColor;
  [Token(Token = "0x4000BD4")]
  [FieldOffset(Offset = "0x48")]
  [Header("演出内容(UI)")]
  public List<GachaAwardData> awardDataList;

  [Token(Token = "0x6000CC0")]
  [Address(RVA = "0x4C7C768", Offset = "0x4C7C768", VA = "0x4C7C768")]
  public void SetColorPattern(GachaSettingsAsset.ColorPattern colorPattern)
  {
  }

  [Token(Token = "0x6000CC1")]
  [Address(RVA = "0x4C7C77C", Offset = "0x4C7C77C", VA = "0x4C7C77C")]
  public GachaSettingsAsset()
  {
  }

  [Token(Token = "0x2000202")]
  public enum ColorPattern
  {
    [Token(Token = "0x4000BD6")] Blue,
    [Token(Token = "0x4000BD7")] Yellow,
  }
}
