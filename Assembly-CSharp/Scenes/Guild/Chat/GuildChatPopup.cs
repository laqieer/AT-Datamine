// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Chat.GuildChatPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Chat
{
  [Token(Token = "0x2002C36")]
  public class GuildChatPopup : MonoBehaviour
  {
    [Token(Token = "0x400BC56")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400BC57")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400BC58")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject buttonObj;
    [Token(Token = "0x400BC59")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject backGround;
    [Token(Token = "0x400BC5A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400BC5B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildChatLog guildChatLog;
    [Token(Token = "0x400BC5C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TMP_InputField inputText;
    [Token(Token = "0x400BC5D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton sendButton;
    [Token(Token = "0x400BC5E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton voiceButton;
    [Token(Token = "0x400BC5F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton stampButton;
    [Token(Token = "0x400BC60")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton stampCancelButton;
    [Token(Token = "0x400BC61")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UITimelineController stampTimelineController;
    [Token(Token = "0x400BC62")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject stampRoot;
    [Token(Token = "0x400BC63")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Scrollbar stampScrollBar;
    [Token(Token = "0x400BC64")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject stampPagePrev;
    [Token(Token = "0x400BC65")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject stampPageNext;
    [Token(Token = "0x400BC66")]
    [FieldOffset(Offset = "0x98")]
    private bool isOpenPopupStamp;
    [Token(Token = "0x400BC67")]
    [FieldOffset(Offset = "0x99")]
    private bool isPlayPopupStampAnimation;
    [Token(Token = "0x400BC68")]
    [FieldOffset(Offset = "0x9C")]
    private int selectStampID;
    [Token(Token = "0x400BC69")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int MAX_STAMP_DISP;
    [Token(Token = "0x400BC6A")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GuldChatButton[] buttons;
    [Token(Token = "0x400BC6B")]
    [FieldOffset(Offset = "0xA8")]
    private GuildLoader guildLoader;
    [Token(Token = "0x400BC6C")]
    [FieldOffset(Offset = "0xB0")]
    private Action closeAction;

    [Token(Token = "0x6011535")]
    [Address(RVA = "0x4E13F90", Offset = "0x4E13F90", VA = "0x4E13F90")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner, Action closeAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011536")]
    [Address(RVA = "0x4E14034", Offset = "0x4E14034", VA = "0x4E14034")]
    public void Open(Action finishAction = null)
    {
    }

    [Token(Token = "0x6011537")]
    [Address(RVA = "0x4E14140", Offset = "0x4E14140", VA = "0x4E14140")]
    public void Close()
    {
    }

    [Token(Token = "0x6011538")]
    [Address(RVA = "0x4E140C0", Offset = "0x4E140C0", VA = "0x4E140C0")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011539")]
    [Address(RVA = "0x4E14238", Offset = "0x4E14238", VA = "0x4E14238")]
    private IEnumerator InitializeStamp() => (IEnumerator) null;

    [Token(Token = "0x601153A")]
    [Address(RVA = "0x4E142C8", Offset = "0x4E142C8", VA = "0x4E142C8")]
    public void OnClickChatSend()
    {
    }

    [Token(Token = "0x601153B")]
    [Address(RVA = "0x4E144F4", Offset = "0x4E144F4", VA = "0x4E144F4")]
    public void OnClickVoice()
    {
    }

    [Token(Token = "0x601153C")]
    [Address(RVA = "0x4E144F8", Offset = "0x4E144F8", VA = "0x4E144F8")]
    public void OnClickStamp(int stampId)
    {
    }

    [Token(Token = "0x601153D")]
    [Address(RVA = "0x4E1460C", Offset = "0x4E1460C", VA = "0x4E1460C")]
    public void OnClickPopupStamp()
    {
    }

    [Token(Token = "0x601153E")]
    [Address(RVA = "0x4E14AA8", Offset = "0x4E14AA8", VA = "0x4E14AA8")]
    public void OnUpdateStampScroll()
    {
    }

    [Token(Token = "0x601153F")]
    [Address(RVA = "0x4E1448C", Offset = "0x4E1448C", VA = "0x4E1448C")]
    private IEnumerator RestrictionSend() => (IEnumerator) null;

    [Token(Token = "0x6011540")]
    [Address(RVA = "0x4E14888", Offset = "0x4E14888", VA = "0x4E14888")]
    private void SuppressionButton(bool sw, GuildChatButtonType type)
    {
    }

    [Token(Token = "0x6011541")]
    [Address(RVA = "0x4E14B4C", Offset = "0x4E14B4C", VA = "0x4E14B4C")]
    private void OnMemberDetailClicked(GuildMemberType memberType)
    {
    }

    [Token(Token = "0x6011542")]
    [Address(RVA = "0x4E14B50", Offset = "0x4E14B50", VA = "0x4E14B50")]
    public GuildChatPopup()
    {
    }

    [Token(Token = "0x6011543")]
    [Address(RVA = "0x4E14B58", Offset = "0x4E14B58", VA = "0x4E14B58")]
    static GuildChatPopup()
    {
    }
  }
}
