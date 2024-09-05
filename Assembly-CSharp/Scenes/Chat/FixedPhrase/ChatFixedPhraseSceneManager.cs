// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.FixedPhrase.ChatFixedPhraseSceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Chat.Log;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.FixedPhrase
{
  [Token(Token = "0x20030C9")]
  public class ChatFixedPhraseSceneManager : SubScene
  {
    [Token(Token = "0x400CF83")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400CF84")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400CF85")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ChatStampScene chatStampScene;
    [Token(Token = "0x400CF86")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ChatLogScene chatLogScene;
    [Token(Token = "0x400CF87")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ChatFixedPhraseScene chatFixedPhraseScene;
    [Token(Token = "0x400CF88")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Toggle[] modeButton;
    [Token(Token = "0x400CF89")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject[] sceneList;
    [Token(Token = "0x400CF8A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Button editButton;
    [Token(Token = "0x400CF8B")]
    [FieldOffset(Offset = "0x98")]
    private ChatFixedPhraseSceneManager.TYPEMODE currentTypeMode;
    [Token(Token = "0x400CF8C")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400CF8D")]
    public const string SubScenePrefabName = "ChatFixedPhrase";
    [Token(Token = "0x400CF8E")]
    public const string AnimationKeyIn = "Open";
    [Token(Token = "0x400CF8F")]
    public const string AnimationKeyOut = "Close";

    [Token(Token = "0x60130DD")]
    [Address(RVA = "0x432ECBC", Offset = "0x432ECBC", VA = "0x432ECBC")]
    public IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60130DE")]
    [Address(RVA = "0x432FC84", Offset = "0x432FC84", VA = "0x432FC84", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60130DF")]
    [Address(RVA = "0x432FF28", Offset = "0x432FF28", VA = "0x432FF28", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60130E0")]
    [Address(RVA = "0x432FF88", Offset = "0x432FF88", VA = "0x432FF88", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60130E1")]
    [Address(RVA = "0x432FFF0", Offset = "0x432FFF0", VA = "0x432FFF0", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60130E2")]
    [Address(RVA = "0x4330058", Offset = "0x4330058", VA = "0x4330058", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60130E3")]
    [Address(RVA = "0x43300C0", Offset = "0x43300C0", VA = "0x43300C0")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x60130E4")]
    [Address(RVA = "0x4330134", Offset = "0x4330134", VA = "0x4330134")]
    private void BackToPrevScene()
    {
    }

    [Token(Token = "0x60130E5")]
    [Address(RVA = "0x43301CC", Offset = "0x43301CC", VA = "0x43301CC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60130E6")]
    [Address(RVA = "0x43301E8", Offset = "0x43301E8", VA = "0x43301E8")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x60130E7")]
    [Address(RVA = "0x43301EC", Offset = "0x43301EC", VA = "0x43301EC")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x60130E8")]
    [Address(RVA = "0x43301C4", Offset = "0x43301C4", VA = "0x43301C4")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x60130E9")]
    [Address(RVA = "0x4330284", Offset = "0x4330284", VA = "0x4330284")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x60130EA")]
    [Address(RVA = "0x432FEC8", Offset = "0x432FEC8", VA = "0x432FEC8")]
    private void ChangeMode()
    {
    }

    [Token(Token = "0x60130EB")]
    [Address(RVA = "0x433028C", Offset = "0x433028C", VA = "0x433028C")]
    public ChatFixedPhraseSceneManager()
    {
    }

    [Token(Token = "0x20030CA")]
    private enum TYPEMODE
    {
      [Token(Token = "0x400CF91")] STAMP,
      [Token(Token = "0x400CF92")] LOG,
      [Token(Token = "0x400CF93")] FIXEDPHRASE,
    }
  }
}
