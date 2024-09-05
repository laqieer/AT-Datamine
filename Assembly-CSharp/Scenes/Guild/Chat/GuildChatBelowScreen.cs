// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Chat.GuildChatBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Chat
{
  [Token(Token = "0x2002C2F")]
  public class GuildChatBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BC35")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildChatLog guildChatLog;
    [Token(Token = "0x400BC36")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TMP_InputField inputText;
    [Token(Token = "0x400BC37")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton sendButton;
    [Token(Token = "0x400BC38")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton voiceButton;
    [Token(Token = "0x400BC39")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton stampButton;
    [Token(Token = "0x400BC3A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton stampCancelButton;
    [Token(Token = "0x400BC3B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITimelineController stampTimelineController;
    [Token(Token = "0x400BC3C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject stampRoot;
    [Token(Token = "0x400BC3D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Scrollbar stampScrollBar;
    [Token(Token = "0x400BC3E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject stampPagePrev;
    [Token(Token = "0x400BC3F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject stampPageNext;
    [Token(Token = "0x400BC40")]
    [FieldOffset(Offset = "0x90")]
    private bool isOpenPopupStamp;
    [Token(Token = "0x400BC41")]
    [FieldOffset(Offset = "0x91")]
    private bool isPlayPopupStampAnimation;
    [Token(Token = "0x400BC42")]
    [FieldOffset(Offset = "0x94")]
    private int selectStampID;
    [Token(Token = "0x400BC43")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int MAX_STAMP_DISP;
    [Token(Token = "0x400BC44")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GuldChatButton[] buttons;

    [Token(Token = "0x6011502")]
    [Address(RVA = "0x4A1C99C", Offset = "0x4A1C99C", VA = "0x4A1C99C", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x6011503")]
    [Address(RVA = "0x4A1CBA4", Offset = "0x4A1CBA4", VA = "0x4A1CBA4", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011504")]
    [Address(RVA = "0x4A1CC34", Offset = "0x4A1CC34", VA = "0x4A1CC34")]
    private IEnumerator InitializeStamp() => (IEnumerator) null;

    [Token(Token = "0x6011505")]
    [Address(RVA = "0x4A1CC9C", Offset = "0x4A1CC9C", VA = "0x4A1CC9C", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011506")]
    [Address(RVA = "0x4A1CCD8", Offset = "0x4A1CCD8", VA = "0x4A1CCD8", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011507")]
    [Address(RVA = "0x4A1CD14", Offset = "0x4A1CD14", VA = "0x4A1CD14", Slot = "9")]
    public override IEnumerator CloseSync() => (IEnumerator) null;

    [Token(Token = "0x6011508")]
    [Address(RVA = "0x4A1CDA4", Offset = "0x4A1CDA4", VA = "0x4A1CDA4")]
    public void OnClickChatSend()
    {
    }

    [Token(Token = "0x6011509")]
    [Address(RVA = "0x4A1CFD0", Offset = "0x4A1CFD0", VA = "0x4A1CFD0")]
    public void OnClickReSend(MessageTypeEnum type, string message)
    {
    }

    [Token(Token = "0x601150A")]
    [Address(RVA = "0x4A1D008", Offset = "0x4A1D008", VA = "0x4A1D008")]
    public void OnClickVoice()
    {
    }

    [Token(Token = "0x601150B")]
    [Address(RVA = "0x4A1D00C", Offset = "0x4A1D00C", VA = "0x4A1D00C")]
    public void OnClickStamp(int stampId)
    {
    }

    [Token(Token = "0x601150C")]
    [Address(RVA = "0x4A1D120", Offset = "0x4A1D120", VA = "0x4A1D120")]
    public void OnClickPopupStamp()
    {
    }

    [Token(Token = "0x601150D")]
    [Address(RVA = "0x4A1D5BC", Offset = "0x4A1D5BC", VA = "0x4A1D5BC")]
    public void OnUpdateStampScroll()
    {
    }

    [Token(Token = "0x601150E")]
    [Address(RVA = "0x4A1CF68", Offset = "0x4A1CF68", VA = "0x4A1CF68")]
    private IEnumerator RestrictionSend() => (IEnumerator) null;

    [Token(Token = "0x601150F")]
    [Address(RVA = "0x4A1D39C", Offset = "0x4A1D39C", VA = "0x4A1D39C")]
    private void SuppressionButton(bool sw, GuildChatButtonType type)
    {
    }

    [Token(Token = "0x6011510")]
    [Address(RVA = "0x4A1D638", Offset = "0x4A1D638", VA = "0x4A1D638")]
    public void OnMemberDetailClicked(GuildMemberType memberType)
    {
    }

    [Token(Token = "0x6011511")]
    [Address(RVA = "0x4A1D714", Offset = "0x4A1D714", VA = "0x4A1D714")]
    public GuildChatBelowScreen()
    {
    }

    [Token(Token = "0x6011512")]
    [Address(RVA = "0x4A1D71C", Offset = "0x4A1D71C", VA = "0x4A1D71C")]
    static GuildChatBelowScreen()
    {
    }
  }
}
