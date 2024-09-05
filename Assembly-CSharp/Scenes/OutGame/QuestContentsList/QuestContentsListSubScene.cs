// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestContentsList.QuestContentsListSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestContentsList
{
  [Token(Token = "0x200340C")]
  public class QuestContentsListSubScene : SubScene
  {
    [Token(Token = "0x400E26A")]
    [FieldOffset(Offset = "0x58")]
    private QuestContentsListSubSceneUILogic questContentsListSubSceneUILogic;
    [Token(Token = "0x400E26B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6014756")]
    [Address(RVA = "0x188D3D8", Offset = "0x188D3D8", VA = "0x188D3D8")]
    public static void TryBackQuestContentsListSubScene(bool isScenarioSelectScreen = false)
    {
    }

    [Token(Token = "0x6014757")]
    [Address(RVA = "0x1894FEC", Offset = "0x1894FEC", VA = "0x1894FEC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014758")]
    [Address(RVA = "0x1894FF4", Offset = "0x1894FF4", VA = "0x1894FF4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014759")]
    [Address(RVA = "0x1895084", Offset = "0x1895084", VA = "0x1895084", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x601475A")]
    [Address(RVA = "0x1895114", Offset = "0x1895114", VA = "0x1895114")]
    private IEnumerator PlayStartSequnceAsync() => (IEnumerator) null;

    [Token(Token = "0x601475B")]
    [Address(RVA = "0x18951A4", Offset = "0x18951A4", VA = "0x18951A4", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x601475C")]
    [Address(RVA = "0x1895234", Offset = "0x1895234", VA = "0x1895234", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x601475D")]
    [Address(RVA = "0x18952C4", Offset = "0x18952C4", VA = "0x18952C4", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x601475E")]
    [Address(RVA = "0x18953C8", Offset = "0x18953C8", VA = "0x18953C8")]
    private IEnumerator PlayTutorial() => (IEnumerator) null;

    [Token(Token = "0x601475F")]
    [Address(RVA = "0x1895458", Offset = "0x1895458", VA = "0x1895458")]
    private void Update()
    {
    }

    [Token(Token = "0x6014760")]
    [Address(RVA = "0x189545C", Offset = "0x189545C", VA = "0x189545C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014761")]
    [Address(RVA = "0x1895460", Offset = "0x1895460", VA = "0x1895460")]
    private void PlayInAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x6014762")]
    [Address(RVA = "0x18955C0", Offset = "0x18955C0", VA = "0x18955C0")]
    private void PlayOutAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x6014763")]
    [Address(RVA = "0x18955FC", Offset = "0x18955FC", VA = "0x18955FC")]
    public QuestContentsListSubScene()
    {
    }

    [Token(Token = "0x200340D")]
    public sealed class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x6014764")]
      [Address(RVA = "0x1895604", Offset = "0x1895604", VA = "0x1895604")]
      public Parameter()
      {
      }
    }
  }
}
