// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Top.ChatNoticeSettingPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Chat.Category;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.Top
{
  [Token(Token = "0x20030E6")]
  public class ChatNoticeSettingPopup : SubScene
  {
    [Token(Token = "0x400D016")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400D017")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D018")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x400D019")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Toggle homeChatSwitch;
    [Token(Token = "0x400D01A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Toggle guildChatSwitch;
    [Token(Token = "0x400D01B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button cancelBtn;
    [Token(Token = "0x400D01C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button decideBtn;
    [Token(Token = "0x400D01D")]
    [FieldOffset(Offset = "0x90")]
    private GameObject chatSelectItem;
    [Token(Token = "0x400D01E")]
    [FieldOffset(Offset = "0x98")]
    private ChatCategoryPopup.SELECTMODE currentMode;
    [Token(Token = "0x400D01F")]
    [FieldOffset(Offset = "0x9C")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400D020")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400D021")]
    public const string SubScenePrefabName = "ChatNoticeSettingPopup";
    [Token(Token = "0x400D022")]
    public const string LOAD_PREFAB_CHAT_SELECT_ITEM = "ChatSelectItem";
    [Token(Token = "0x400D023")]
    public const string AnimationKeyIn = "Open";
    [Token(Token = "0x400D024")]
    public const string AnimationKeyOut = "Close";

    [Token(Token = "0x601318C")]
    [Address(RVA = "0x45DA208", Offset = "0x45DA208", VA = "0x45DA208", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x601318D")]
    [Address(RVA = "0x45DA3A8", Offset = "0x45DA3A8", VA = "0x45DA3A8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601318E")]
    [Address(RVA = "0x45DA438", Offset = "0x45DA438", VA = "0x45DA438")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601318F")]
    [Address(RVA = "0x45DA4DC", Offset = "0x45DA4DC", VA = "0x45DA4DC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6013190")]
    [Address(RVA = "0x45DA4E4", Offset = "0x45DA4E4", VA = "0x45DA4E4", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013191")]
    [Address(RVA = "0x45DA574", Offset = "0x45DA574", VA = "0x45DA574", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013192")]
    [Address(RVA = "0x45DA604", Offset = "0x45DA604", VA = "0x45DA604", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6013193")]
    [Address(RVA = "0x45DA694", Offset = "0x45DA694", VA = "0x45DA694")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x6013194")]
    [Address(RVA = "0x45DA730", Offset = "0x45DA730", VA = "0x45DA730", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6013195")]
    [Address(RVA = "0x45DA7DC", Offset = "0x45DA7DC", VA = "0x45DA7DC")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6013196")]
    [Address(RVA = "0x45DA7E0", Offset = "0x45DA7E0", VA = "0x45DA7E0")]
    public void OnClickDecideButton()
    {
    }

    [Token(Token = "0x6013197")]
    [Address(RVA = "0x45DA74C", Offset = "0x45DA74C", VA = "0x45DA74C")]
    private void BackToPrevScene()
    {
    }

    [Token(Token = "0x6013198")]
    [Address(RVA = "0x45DAB28", Offset = "0x45DAB28", VA = "0x45DAB28")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x6013199")]
    [Address(RVA = "0x45DAB20", Offset = "0x45DAB20", VA = "0x45DAB20")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x601319A")]
    [Address(RVA = "0x45DABC0", Offset = "0x45DABC0", VA = "0x45DABC0")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x601319B")]
    [Address(RVA = "0x45DABC8", Offset = "0x45DABC8", VA = "0x45DABC8")]
    private void SetItemData(Dictionary<int, ChatRoomData> categoryDic)
    {
    }

    [Token(Token = "0x601319C")]
    [Address(RVA = "0x45DB00C", Offset = "0x45DB00C", VA = "0x45DB00C")]
    public ChatNoticeSettingPopup()
    {
    }
  }
}
