// Decompiled with JetBrains decompiler
// Type: GachaPlayback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001F9")]
public class GachaPlayback
{
  [Token(Token = "0x4000BAE")]
  public const string ASSETBUNDLE_NAME_GACHA = "content_gacha_scene";
  [Token(Token = "0x4000BAF")]
  public const string ASSET_NAME_GACHA = "gacha";
  [Token(Token = "0x4000BB0")]
  public const string HOME_SCENE_NAME = "Home3D";
  [Token(Token = "0x4000BB1")]
  public const string GACHA_START_BGM = "BGM_OutGame_GachaStart";
  [Token(Token = "0x4000BB2")]
  [FieldOffset(Offset = "0x10")]
  private GachaManager gachaManager;
  [Token(Token = "0x4000BB3")]
  [FieldOffset(Offset = "0x18")]
  private Action onGachaFinish;
  [Token(Token = "0x4000BB4")]
  [FieldOffset(Offset = "0x20")]
  private AppQualitySettings qualitySettings;
  [Token(Token = "0x4000BB5")]
  [FieldOffset(Offset = "0x28")]
  private bool isSkipGachaPlayback;

  [Token(Token = "0x6000CA1")]
  [Address(RVA = "0x4C7B9D8", Offset = "0x4C7B9D8", VA = "0x4C7B9D8")]
  public IEnumerator InitializeGacha(
    GachaSettingsAsset gachaSettings,
    bool isSkipGachaPlayback,
    Action onGachaFinish)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000CA2")]
  [Address(RVA = "0x4C7BA90", Offset = "0x4C7BA90", VA = "0x4C7BA90")]
  private void OnSceneLoadCompleted(AsyncOperation obj)
  {
  }

  [Token(Token = "0x6000CA3")]
  [Address(RVA = "0x4C7BC38", Offset = "0x4C7BC38", VA = "0x4C7BC38")]
  public void UnloadScene()
  {
  }

  [Token(Token = "0x6000CA4")]
  [Address(RVA = "0x4C7BCA0", Offset = "0x4C7BCA0", VA = "0x4C7BCA0")]
  public IEnumerator PlayGachaCoroutine() => (IEnumerator) null;

  [Token(Token = "0x6000CA5")]
  [Address(RVA = "0x4C7BD30", Offset = "0x4C7BD30", VA = "0x4C7BD30")]
  public void RegisterResultOverlayCamera(Camera mainCamera, string forwardInsertCameraName)
  {
  }

  [Token(Token = "0x6000CA6")]
  [Address(RVA = "0x4C7BD48", Offset = "0x4C7BD48", VA = "0x4C7BD48")]
  public void RegisterOverlayCameraToAllGachaCameras(Camera camera)
  {
  }

  [Token(Token = "0x6000CA7")]
  [Address(RVA = "0x4C7BD60", Offset = "0x4C7BD60", VA = "0x4C7BD60")]
  public GachaPlayback()
  {
  }
}
