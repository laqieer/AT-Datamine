// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Top.ChatDialogSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.Top
{
  [Token(Token = "0x20030D8")]
  public class ChatDialogSubScene : SubScene
  {
    [Token(Token = "0x400CFBE")]
    [FieldOffset(Offset = "0x58")]
    private string LastplayedStampSEMSGID;
    [Token(Token = "0x400CFBF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400CFC0")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400CFC1")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button categorySelectButton;
    [Token(Token = "0x400CFC2")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Button channelSelectButton;
    [Token(Token = "0x400CFC3")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button noticeSettingButton;
    [Token(Token = "0x400CFC4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400CFC5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private InputField chatInput;
    [Token(Token = "0x400CFC6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button chatSendButton;
    [Token(Token = "0x400CFC7")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button fixedPhraseButton;
    [Token(Token = "0x400CFC8")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button cancleButton;
    [Token(Token = "0x400CFC9")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject chatDialogPanel;
    [Token(Token = "0x400CFCA")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject guidelinePanel;
    [Token(Token = "0x400CFCB")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button guidelineButton;
    [Token(Token = "0x400CFCC")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text guidelineText;
    [Token(Token = "0x400CFCD")]
    [FieldOffset(Offset = "0xD0")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400CFCE")]
    [FieldOffset(Offset = "0xD8")]
    private InfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400CFCF")]
    [FieldOffset(Offset = "0xE0")]
    private GameObject chatListItem;
    [Token(Token = "0x400CFD0")]
    [FieldOffset(Offset = "0xE8")]
    private List<ChatListItemParent> chatList;
    [Token(Token = "0x400CFD1")]
    [FieldOffset(Offset = "0xF0")]
    private IEnumerator chatLogCoroutine;
    [Token(Token = "0x400CFD2")]
    [FieldOffset(Offset = "0xF8")]
    private string lastMessageID;
    [Token(Token = "0x400CFD3")]
    [FieldOffset(Offset = "0x100")]
    private bool isRefresh;
    [Token(Token = "0x400CFD4")]
    [FieldOffset(Offset = "0x104")]
    private int chatLogPollingInterval;
    [Token(Token = "0x400CFD5")]
    [FieldOffset(Offset = "0x108")]
    private bool canSendChat;
    [Token(Token = "0x400CFD6")]
    [FieldOffset(Offset = "0x110")]
    private string readyPlaySE;
    [Token(Token = "0x400CFD7")]
    [FieldOffset(Offset = "0x118")]
    private int pollingIndex;
    [Token(Token = "0x400CFD8")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400CFD9")]
    public const string SubScenePrefabName = "ChatDialogSubScene";
    [Token(Token = "0x400CFDA")]
    public const string LOAD_PREFAB_CHAT_LIST_ITEM = "ChatListItemNew";
    [Token(Token = "0x400CFDB")]
    public const string AnimationKeyIn = "Open";
    [Token(Token = "0x400CFDC")]
    public const string AnimationKeyOut = "Close";

    [Token(Token = "0x601312C")]
    [Address(RVA = "0x45D6668", Offset = "0x45D6668", VA = "0x45D6668")]
    private void Awake()
    {
    }

    [Token(Token = "0x601312D")]
    [Address(RVA = "0x45D66E0", Offset = "0x45D66E0", VA = "0x45D66E0")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601312E")]
    [Address(RVA = "0x45D6784", Offset = "0x45D6784", VA = "0x45D6784", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601312F")]
    [Address(RVA = "0x45D7100", Offset = "0x45D7100", VA = "0x45D7100", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013130")]
    [Address(RVA = "0x45D7190", Offset = "0x45D7190", VA = "0x45D7190", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013131")]
    [Address(RVA = "0x45D7220", Offset = "0x45D7220", VA = "0x45D7220", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013132")]
    [Address(RVA = "0x45D72B0", Offset = "0x45D72B0", VA = "0x45D72B0", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6013133")]
    [Address(RVA = "0x45D7340", Offset = "0x45D7340", VA = "0x45D7340")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x6013134")]
    [Address(RVA = "0x45D73DC", Offset = "0x45D73DC", VA = "0x45D73DC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6013135")]
    [Address(RVA = "0x45D7488", Offset = "0x45D7488", VA = "0x45D7488")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6013136")]
    [Address(RVA = "0x45D73F8", Offset = "0x45D73F8", VA = "0x45D73F8")]
    private void BackToPrevScene()
    {
    }

    [Token(Token = "0x6013137")]
    [Address(RVA = "0x45D7494", Offset = "0x45D7494", VA = "0x45D7494")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x6013138")]
    [Address(RVA = "0x45D748C", Offset = "0x45D748C", VA = "0x45D748C")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x6013139")]
    [Address(RVA = "0x45D752C", Offset = "0x45D752C", VA = "0x45D752C")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x601313A")]
    [Address(RVA = "0x45D6E64", Offset = "0x45D6E64", VA = "0x45D6E64")]
    private IEnumerator RequestChatLogList() => (IEnumerator) null;

    [Token(Token = "0x601313B")]
    [Address(RVA = "0x45D755C", Offset = "0x45D755C", VA = "0x45D755C")]
    private IEnumerator SendChatMessage(string content, int msgType) => (IEnumerator) null;

    [Token(Token = "0x601313C")]
    [Address(RVA = "0x45D7600", Offset = "0x45D7600", VA = "0x45D7600")]
    private bool CheckSameContentInSavaData(string content, int type) => new bool();

    [Token(Token = "0x601313D")]
    [Address(RVA = "0x45D772C", Offset = "0x45D772C", VA = "0x45D772C")]
    private void ClearChatLog()
    {
    }

    [Token(Token = "0x601313E")]
    [Address(RVA = "0x45D77D0", Offset = "0x45D77D0", VA = "0x45D77D0")]
    private void UpdateAllMessageList(List<ChatMessageType> messageList)
    {
    }

    [Token(Token = "0x601313F")]
    [Address(RVA = "0x45D6ECC", Offset = "0x45D6ECC", VA = "0x45D6ECC")]
    private void SetButtonLabel()
    {
    }

    [Token(Token = "0x6013140")]
    [Address(RVA = "0x45D7CB0", Offset = "0x45D7CB0", VA = "0x45D7CB0")]
    public ChatDialogSubScene()
    {
    }
  }
}
