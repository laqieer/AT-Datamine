// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Category.ChatCategoryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.Category
{
  [Token(Token = "0x20030EF")]
  public class ChatCategoryPopup : SubScene
  {
    [Token(Token = "0x400D049")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400D04A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D04B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x400D04C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400D04D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text currentModeTitle;
    [Token(Token = "0x400D04E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text currentModeText;
    [Token(Token = "0x400D04F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button cancelBtn;
    [Token(Token = "0x400D050")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Button decideBtn;
    [Token(Token = "0x400D051")]
    private const int defaultChannelRoomID = 1;
    [Token(Token = "0x400D052")]
    [FieldOffset(Offset = "0x98")]
    private ChatCategoryPopup.SELECTMODE currentMode;
    [Token(Token = "0x400D053")]
    [FieldOffset(Offset = "0xA0")]
    private Action onRefeshChatLog;
    [Token(Token = "0x400D054")]
    [FieldOffset(Offset = "0xA8")]
    private int currCategoryID;
    [Token(Token = "0x400D055")]
    [FieldOffset(Offset = "0xAC")]
    private int currChannelID;
    [Token(Token = "0x400D056")]
    [FieldOffset(Offset = "0xB0")]
    private int currRoomID;
    [Token(Token = "0x400D057")]
    [FieldOffset(Offset = "0xB4")]
    private int lastChannelID;
    [Token(Token = "0x400D058")]
    [FieldOffset(Offset = "0xB8")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400D059")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject chatSelectItem;
    [Token(Token = "0x400D05A")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400D05B")]
    public const string SubScenePrefabName = "ChatCategoryPopup";
    [Token(Token = "0x400D05C")]
    public const string LOAD_PREFAB_CHAT_SELECT_ITEM = "ChatSelectItem";
    [Token(Token = "0x400D05D")]
    public const string AnimationKeyIn = "Open";
    [Token(Token = "0x400D05E")]
    public const string AnimationKeyOut = "Close";

    [Token(Token = "0x60131EE")]
    [Address(RVA = "0x45DBEF8", Offset = "0x45DBEF8", VA = "0x45DBEF8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x60131EF")]
    [Address(RVA = "0x45DC0E8", Offset = "0x45DC0E8", VA = "0x45DC0E8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60131F0")]
    [Address(RVA = "0x45DC178", Offset = "0x45DC178", VA = "0x45DC178")]
    private void SetItemData(Dictionary<int, ChatRoomData> categoryDic)
    {
    }

    [Token(Token = "0x60131F1")]
    [Address(RVA = "0x45DC5F8", Offset = "0x45DC5F8", VA = "0x45DC5F8")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60131F2")]
    [Address(RVA = "0x45DC69C", Offset = "0x45DC69C", VA = "0x45DC69C")]
    private void ChangeMode()
    {
    }

    [Token(Token = "0x60131F3")]
    [Address(RVA = "0x45DCBDC", Offset = "0x45DCBDC", VA = "0x45DCBDC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60131F4")]
    [Address(RVA = "0x45DCBE4", Offset = "0x45DCBE4", VA = "0x45DCBE4", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60131F5")]
    [Address(RVA = "0x45DCC74", Offset = "0x45DCC74", VA = "0x45DCC74", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60131F6")]
    [Address(RVA = "0x45DCD04", Offset = "0x45DCD04", VA = "0x45DCD04", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60131F7")]
    [Address(RVA = "0x45DCD94", Offset = "0x45DCD94", VA = "0x45DCD94")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x60131F8")]
    [Address(RVA = "0x45DCE30", Offset = "0x45DCE30", VA = "0x45DCE30", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60131F9")]
    [Address(RVA = "0x45DCEDC", Offset = "0x45DCEDC", VA = "0x45DCEDC")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x60131FA")]
    [Address(RVA = "0x45DCF68", Offset = "0x45DCF68", VA = "0x45DCF68")]
    public void OnClickDecideButton()
    {
    }

    [Token(Token = "0x60131FB")]
    [Address(RVA = "0x45DCE4C", Offset = "0x45DCE4C", VA = "0x45DCE4C")]
    private void BackToPrevScene()
    {
    }

    [Token(Token = "0x60131FC")]
    [Address(RVA = "0x45DD2F4", Offset = "0x45DD2F4", VA = "0x45DD2F4")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x60131FD")]
    [Address(RVA = "0x45DD2EC", Offset = "0x45DD2EC", VA = "0x45DD2EC")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x60131FE")]
    [Address(RVA = "0x45DD38C", Offset = "0x45DD38C", VA = "0x45DD38C")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x60131FF")]
    [Address(RVA = "0x45DD394", Offset = "0x45DD394", VA = "0x45DD394")]
    public ChatCategoryPopup()
    {
    }

    [Token(Token = "0x20030F0")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x1700401C")]
      public ChatCategoryPopup.SELECTMODE seleteMode
      {
        [Token(Token = "0x6013207"), Address(RVA = "0x45DD4A4", Offset = "0x45DD4A4", VA = "0x45DD4A4")] get
        {
          return new ChatCategoryPopup.SELECTMODE();
        }
        [Token(Token = "0x6013208"), Address(RVA = "0x45DD4AC", Offset = "0x45DD4AC", VA = "0x45DD4AC")] protected set
        {
        }
      }

      [Token(Token = "0x1700401D")]
      public Action OnRefeshChatLog
      {
        [Token(Token = "0x6013209"), Address(RVA = "0x45DD4B4", Offset = "0x45DD4B4", VA = "0x45DD4B4")] get
        {
          return (Action) null;
        }
        [Token(Token = "0x601320A"), Address(RVA = "0x45DD4BC", Offset = "0x45DD4BC", VA = "0x45DD4BC")] protected set
        {
        }
      }

      [Token(Token = "0x601320B")]
      [Address(RVA = "0x45D83A4", Offset = "0x45D83A4", VA = "0x45D83A4")]
      public Param(ChatCategoryPopup.SELECTMODE modeType, Action refeshLog)
      {
      }
    }

    [Token(Token = "0x20030F1")]
    public enum SELECTMODE
    {
      [Token(Token = "0x400D062")] Category,
      [Token(Token = "0x400D063")] Channel,
      [Token(Token = "0x400D064")] Room,
    }
  }
}
