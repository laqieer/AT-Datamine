// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuBelowScreenHandler
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
  [Token(Token = "0x2003A23")]
  public class OutGameMenuBelowScreenHandler : MonoBehaviour
  {
    [Token(Token = "0x400FE87")]
    [FieldOffset(Offset = "0x18")]
    private OutGameMenuBelowScreenBase currentBelowScreen;
    [Token(Token = "0x400FE88")]
    [FieldOffset(Offset = "0x20")]
    public Transform parentTransform;
    [Token(Token = "0x400FE89")]
    [FieldOffset(Offset = "0x28")]
    public OutGameMenuOperationPossible operationPossibleEvent;
    [Token(Token = "0x400FE8A")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, ChangeBelowScreenParameter> retentionParamDic;
    [Token(Token = "0x400FE8B")]
    [FieldOffset(Offset = "0x38")]
    public bool isDirection;
    [Token(Token = "0x400FE8C")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner cachedSpawner;

    [Token(Token = "0x6016D93")]
    [Address(RVA = "0x2C5A06C", Offset = "0x2C5A06C", VA = "0x2C5A06C")]
    public void Awake()
    {
    }

    [Token(Token = "0x6016D94")]
    [Address(RVA = "0x2C5A0E8", Offset = "0x2C5A0E8", VA = "0x2C5A0E8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6016D95")]
    [Address(RVA = "0x2C5A0EC", Offset = "0x2C5A0EC", VA = "0x2C5A0EC")]
    public void SetCachedSpawner(AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6016D96")]
    [Address(RVA = "0x2C5A0F4", Offset = "0x2C5A0F4", VA = "0x2C5A0F4")]
    public OutGameMenuBelowScreenBase GetCurrentBelowScreen() => (OutGameMenuBelowScreenBase) null;

    [Token(Token = "0x6016D97")]
    [Address(RVA = "0x2C554E4", Offset = "0x2C554E4", VA = "0x2C554E4")]
    public IEnumerator ChangeBelowScreen(
      string assetBundleName,
      string name,
      string currentName,
      Func<bool> finishOutAction,
      Action openAction,
      Action finishAction,
      int value)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D98")]
    [Address(RVA = "0x2C5A124", Offset = "0x2C5A124", VA = "0x2C5A124")]
    public IEnumerator _ChangeBelowScreen(
      string assetBundleName,
      string name,
      string currentName,
      Func<bool> finishOutAction,
      Action openAction,
      Action finishAction,
      int value)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D99")]
    [Address(RVA = "0x2C5A200", Offset = "0x2C5A200", VA = "0x2C5A200")]
    private IEnumerator DestroyAsync(OutGameMenuBelowScreenBase belowScreen) => (IEnumerator) null;

    [Token(Token = "0x6016D9A")]
    [Address(RVA = "0x2C5A29C", Offset = "0x2C5A29C", VA = "0x2C5A29C")]
    private void GetObjectsList(GameObject obj, ref List<GameObject> list, int deepMax = 2147483647, int deep = 0)
    {
    }

    [Token(Token = "0x6016D9B")]
    [Address(RVA = "0x2C5A484", Offset = "0x2C5A484", VA = "0x2C5A484")]
    private IEnumerator LoadBelowScreen(
      string assetBundleName,
      string name,
      int value,
      Action loadEnd)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016D9C")]
    [Address(RVA = "0x2C5453C", Offset = "0x2C5453C", VA = "0x2C5453C")]
    public void ChangeBelowScreenFromBelowScreen(
      string assetBundleName,
      string name,
      string currentName)
    {
    }

    [Token(Token = "0x6016D9D")]
    [Address(RVA = "0x2C57744", Offset = "0x2C57744", VA = "0x2C57744")]
    public void SetRetentionParam(string name, ChangeBelowScreenParameter param)
    {
    }

    [Token(Token = "0x6016D9E")]
    [Address(RVA = "0x2C5A540", Offset = "0x2C5A540", VA = "0x2C5A540")]
    public ChangeBelowScreenParameter GetRetentionParam(string name)
    {
      return (ChangeBelowScreenParameter) null;
    }

    [Token(Token = "0x6016D9F")]
    [Address(RVA = "0x2C5A5D0", Offset = "0x2C5A5D0", VA = "0x2C5A5D0")]
    public void EraseRetentionParam(string name)
    {
    }

    [Token(Token = "0x6016DA0")]
    [Address(RVA = "0x2C5A628", Offset = "0x2C5A628", VA = "0x2C5A628")]
    public void DeleteAllRetentionParam()
    {
    }

    [Token(Token = "0x6016DA1")]
    [Address(RVA = "0x2C5A678", Offset = "0x2C5A678", VA = "0x2C5A678")]
    public OutGameMenuBelowScreenHandler()
    {
    }
  }
}
