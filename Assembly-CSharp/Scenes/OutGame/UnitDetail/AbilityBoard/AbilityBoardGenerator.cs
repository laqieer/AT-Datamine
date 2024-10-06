// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003325")]
  public class AbilityBoardGenerator : IDisposable
  {
    [Token(Token = "0x400DD3B")]
    [FieldOffset(Offset = "0x18")]
    private List<string> loadedAssetBundleNames;

    [Token(Token = "0x1700435A")]
    public AbilityBoardResource Resource
    {
      [Token(Token = "0x60141A3"), Address(RVA = "0x20C72DC", Offset = "0x20C72DC", VA = "0x20C72DC")] get
      {
        return (AbilityBoardResource) null;
      }
      [Token(Token = "0x60141A4"), Address(RVA = "0x20C72E4", Offset = "0x20C72E4", VA = "0x20C72E4")] private set
      {
      }
    }

    [Token(Token = "0x60141A5")]
    [Address(RVA = "0x20C72EC", Offset = "0x20C72EC", VA = "0x20C72EC")]
    public AbilityBoardGenerator()
    {
    }

    [Token(Token = "0x60141A6")]
    [Address(RVA = "0x20C736C", Offset = "0x20C736C", VA = "0x20C736C")]
    public IEnumerator LoadAssetAsync(Action onFinish = null) => (IEnumerator) null;

    [Token(Token = "0x60141A7")]
    [Address(RVA = "0x20C7408", Offset = "0x20C7408", VA = "0x20C7408")]
    public void AddNeedAssetBundle()
    {
    }

    [Token(Token = "0x60141A8")]
    [Address(RVA = "0x20C758C", Offset = "0x20C758C", VA = "0x20C758C")]
    public void LoadPrefab()
    {
    }

    [Token(Token = "0x60141A9")]
    [Address(RVA = "0x20C7478", Offset = "0x20C7478", VA = "0x20C7478")]
    private void AddLoadAssetBundle(string assetBundleLabelName)
    {
    }

    [Token(Token = "0x60141AA")]
    [Address(RVA = "0x20C78A8", Offset = "0x20C78A8", VA = "0x20C78A8")]
    public AbilityBoardBehaviour Generate(Transform parent) => (AbilityBoardBehaviour) null;

    [Token(Token = "0x60141AB")]
    [Address(RVA = "0x20C7B2C", Offset = "0x20C7B2C", VA = "0x20C7B2C", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
