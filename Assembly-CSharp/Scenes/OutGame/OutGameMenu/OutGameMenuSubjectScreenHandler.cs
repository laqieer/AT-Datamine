// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuSubjectScreenHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A2E")]
  public class OutGameMenuSubjectScreenHandler : MonoBehaviour
  {
    [Token(Token = "0x400FEC1")]
    [FieldOffset(Offset = "0x18")]
    private OutGameMenuSubjectScreenBase currentSubjectScreen;
    [Token(Token = "0x400FEC2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform parentTransform;
    [Token(Token = "0x400FEC3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform childParentTransform;
    [Token(Token = "0x400FEC4")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<OutGameMenuSubScene.OutGameMenuID, ChangeSubjectScreenParameter> retentionParamDic;
    [Token(Token = "0x400FEC5")]
    [FieldOffset(Offset = "0x38")]
    public bool isDirection;
    [Token(Token = "0x400FEC6")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner cachedSpawner;

    [Token(Token = "0x6016DD6")]
    [Address(RVA = "0x2C5B744", Offset = "0x2C5B744", VA = "0x2C5B744")]
    public void Awake()
    {
    }

    [Token(Token = "0x6016DD7")]
    [Address(RVA = "0x2C5B750", Offset = "0x2C5B750", VA = "0x2C5B750")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x6016DD8")]
    [Address(RVA = "0x2C5B7D8", Offset = "0x2C5B7D8", VA = "0x2C5B7D8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6016DD9")]
    [Address(RVA = "0x2C5B7DC", Offset = "0x2C5B7DC", VA = "0x2C5B7DC")]
    public void SetCachedSpawner(AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6016DDA")]
    [Address(RVA = "0x2C5B7E4", Offset = "0x2C5B7E4", VA = "0x2C5B7E4")]
    public OutGameMenuSubjectScreenBase GetCurrentSubjectScreen()
    {
      return (OutGameMenuSubjectScreenBase) null;
    }

    [Token(Token = "0x6016DDB")]
    [Address(RVA = "0x2C5B7EC", Offset = "0x2C5B7EC", VA = "0x2C5B7EC")]
    public void ChangeSubjectScreen(
      string assetBundleName,
      string name,
      OutGameMenuSubScene.OutGameMenuID currentId,
      OutGameMenuSubScene.OutGameMenuID nextId,
      Func<bool> finishOutAction,
      Action openAction,
      Action finishAction,
      int value = 0)
    {
    }

    [Token(Token = "0x6016DDC")]
    [Address(RVA = "0x2C5B81C", Offset = "0x2C5B81C", VA = "0x2C5B81C")]
    public IEnumerator _ChangeSubjectScreen(
      string assetBundleName,
      string name,
      OutGameMenuSubScene.OutGameMenuID currentId,
      OutGameMenuSubScene.OutGameMenuID nextId,
      Func<bool> finishOutAction,
      Action openAction,
      Action finishAction,
      int value)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016DDD")]
    [Address(RVA = "0x2C5B904", Offset = "0x2C5B904", VA = "0x2C5B904")]
    private IEnumerator LoadSubjectScene(
      string assetBundleName,
      string name,
      OutGameMenuSubScene.OutGameMenuID nextId,
      int value,
      Action endLoad)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016DDE")]
    [Address(RVA = "0x2C5B9C0", Offset = "0x2C5B9C0", VA = "0x2C5B9C0")]
    public void SetRetentionParam(
      OutGameMenuSubScene.OutGameMenuID id,
      ChangeSubjectScreenParameter param)
    {
    }

    [Token(Token = "0x6016DDF")]
    [Address(RVA = "0x2C5BABC", Offset = "0x2C5BABC", VA = "0x2C5BABC")]
    public OutGameMenuSubjectScreenHandler()
    {
    }
  }
}
