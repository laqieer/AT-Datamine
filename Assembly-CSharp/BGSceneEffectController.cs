// Decompiled with JetBrains decompiler
// Type: BGSceneEffectController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x20000E8")]
[ExecuteInEditMode]
public class BGSceneEffectController : MonoBehaviour
{
  [Token(Token = "0x400041E")]
  [FieldOffset(Offset = "0x18")]
  public BGSceneEffectSettingsAsset bgSceneEffectSettings;
  [Token(Token = "0x400041F")]
  [FieldOffset(Offset = "0x20")]
  public BattleBgColorIdEnum bgColorIdEnum;
  [Token(Token = "0x4000420")]
  [FieldOffset(Offset = "0x24")]
  public BattleTimeTypeEnum currentTime;
  [Token(Token = "0x4000421")]
  [FieldOffset(Offset = "0x28")]
  public BattleWeatherTypeEnum currentWeather;
  [Token(Token = "0x4000422")]
  [FieldOffset(Offset = "0x30")]
  public LightForCharacters lightForCharacters;
  [Token(Token = "0x4000423")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private BGColorCollect bgColorCollect;
  [Token(Token = "0x4000424")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private Volume globalVolume;
  [Token(Token = "0x4000425")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private Transform effectObjectsRoot;
  [Token(Token = "0x4000426")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private MeshRenderer skyRenderer;
  [Token(Token = "0x4000427")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private Light directionalLight;
  [Token(Token = "0x4000428")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private List<GameObject> disableOnCloudy;
  [Token(Token = "0x4000429")]
  [FieldOffset(Offset = "0x68")]
  private float defaultCollectBlend;
  [Token(Token = "0x400042A")]
  [FieldOffset(Offset = "0x6C")]
  private Color defaultCollectColor;
  [Token(Token = "0x400042B")]
  [FieldOffset(Offset = "0x7C")]
  private BGColorCollect.CollectMode defaultMode;
  [Token(Token = "0x400042C")]
  [FieldOffset(Offset = "0x80")]
  private Color defaultFogColor;
  [Token(Token = "0x400042D")]
  [FieldOffset(Offset = "0x90")]
  private float defaultFogStart;
  [Token(Token = "0x400042E")]
  [FieldOffset(Offset = "0x94")]
  private float defaultFogEnd;
  [Token(Token = "0x400042F")]
  [FieldOffset(Offset = "0x98")]
  private float defaultAngle;
  [Token(Token = "0x4000430")]
  [FieldOffset(Offset = "0x9C")]
  private float defaultOffset;
  [Token(Token = "0x4000431")]
  [FieldOffset(Offset = "0xA0")]
  private float defaultThreshold;
  [Token(Token = "0x4000432")]
  [FieldOffset(Offset = "0xA4")]
  private float defaultIntensity;
  [Token(Token = "0x4000433")]
  [FieldOffset(Offset = "0xA8")]
  private Color defaultColorA;
  [Token(Token = "0x4000434")]
  [FieldOffset(Offset = "0xB8")]
  private Color defaultColorB;
  [Token(Token = "0x4000435")]
  [FieldOffset(Offset = "0xC8")]
  private Material defaultSkyRendererMaterial;

  [Token(Token = "0x60006B4")]
  [Address(RVA = "0x41866A4", Offset = "0x41866A4", VA = "0x41866A4")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006B5")]
  [Address(RVA = "0x41868F4", Offset = "0x41868F4", VA = "0x41868F4")]
  public void ApplyBGEffectSettings(Battle.Data.Board.BattleData data)
  {
  }

  [Token(Token = "0x60006B6")]
  [Address(RVA = "0x4186934", Offset = "0x4186934", VA = "0x4186934")]
  public void ApplyBGEffectSettings(BattleBgColorIdEnum bgColorId)
  {
  }

  [Token(Token = "0x60006B7")]
  [Address(RVA = "0x4186A3C", Offset = "0x4186A3C", VA = "0x4186A3C")]
  public void ApplyBGEffectSettings(BattleTimeTypeEnum time, BattleWeatherTypeEnum weather)
  {
  }

  [Token(Token = "0x60006B8")]
  [Address(RVA = "0x4186C4C", Offset = "0x4186C4C", VA = "0x4186C4C")]
  public void ApplyDisableOnCloudy(bool enable)
  {
  }

  [Token(Token = "0x60006B9")]
  [Address(RVA = "0x4186DA4", Offset = "0x4186DA4", VA = "0x4186DA4")]
  private void ApplyBGEffectSettings(BGSceneEffectData effectData)
  {
  }

  [Token(Token = "0x60006BA")]
  [Address(RVA = "0x418739C", Offset = "0x418739C", VA = "0x418739C")]
  private void ClearEffectObjects()
  {
  }

  [Token(Token = "0x60006BB")]
  [Address(RVA = "0x418744C", Offset = "0x418744C", VA = "0x418744C")]
  [ContextMenu("Apply Time And Weather Effect")]
  public void ApplyCurrentTimeAndWeatherEffect()
  {
  }

  [Token(Token = "0x60006BC")]
  [Address(RVA = "0x4187454", Offset = "0x4187454", VA = "0x4187454")]
  [ContextMenu("Apply Mementos Effect")]
  public void ApplyCurrentMementosEffect()
  {
  }

  [Token(Token = "0x60006BD")]
  [Address(RVA = "0x418745C", Offset = "0x418745C", VA = "0x418745C")]
  public void ResetEffectSettings()
  {
  }

  [Token(Token = "0x60006BE")]
  [Address(RVA = "0x4187708", Offset = "0x4187708", VA = "0x4187708")]
  public BGSceneEffectController()
  {
  }
}
