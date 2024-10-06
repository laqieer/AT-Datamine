// Decompiled with JetBrains decompiler
// Type: GuildChatLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using Scenes.Guild;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200027E")]
public class GuildChatLog : MonoBehaviour
{
  [Token(Token = "0x4000ECB")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private TextMeshProUGUI singedMemberText;
  [Token(Token = "0x4000ECC")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private GameObject rootChatLog;
  [Token(Token = "0x4000ECD")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private ScrollRect logScrollRect;
  [Token(Token = "0x4000ECE")]
  [FieldOffset(Offset = "0x30")]
  private Coroutine coroutineLog;
  [Token(Token = "0x4000ECF")]
  [FieldOffset(Offset = "0x38")]
  private Coroutine coroutineSend;
  [Token(Token = "0x4000ED0")]
  [FieldOffset(Offset = "0x40")]
  private Coroutine coroutineUpdate;
  [Token(Token = "0x4000ED1")]
  [FieldOffset(Offset = "0x48")]
  private Action<APIGuildChatLogResponse> actionUpdateLog;
  [Token(Token = "0x4000ED2")]
  [FieldOffset(Offset = "0x50")]
  private Action<GuildMemberType> actionMemberDital;
  [Token(Token = "0x4000ED3")]
  [FieldOffset(Offset = "0x58")]
  private Action<MessageTypeEnum, string> actionReSend;
  [Token(Token = "0x4000ED4")]
  [FieldOffset(Offset = "0x60")]
  private GameObject sendMessage;
  [Token(Token = "0x4000ED5")]
  [FieldOffset(Offset = "0x68")]
  private GuildLoader guildLoader;
  [Token(Token = "0x4000ED6")]
  [FieldOffset(Offset = "0x70")]
  private bool isStripedBG;
  [Token(Token = "0x4000ED7")]
  [FieldOffset(Offset = "0x71")]
  private bool isInteractableReSend;
  [Token(Token = "0x4000ED8")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string[] GuildChatAssetName;
  [Token(Token = "0x4000ED9")]
  [FieldOffset(Offset = "0x78")]
  private GameObject[] orgInstanceChats;

  [Token(Token = "0x17000159")]
  public bool IsSending
  {
    [Token(Token = "0x6000F87"), Address(RVA = "0x1BDFE54", Offset = "0x1BDFE54", VA = "0x1BDFE54")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000F88")]
  [Address(RVA = "0x1BDFE64", Offset = "0x1BDFE64", VA = "0x1BDFE64")]
  public IEnumerator InitializeAsync(
    GuildLoader guildLoader,
    Action<GuildMemberType> OnMemberDetail,
    Action<MessageTypeEnum, string> OnClickReSend,
    Action<APIGuildChatLogResponse> OnUpdateLog = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000F89")]
  [Address(RVA = "0x1BDFF1C", Offset = "0x1BDFF1C", VA = "0x1BDFF1C")]
  public void Open()
  {
  }

  [Token(Token = "0x6000F8A")]
  [Address(RVA = "0x1BE0778", Offset = "0x1BE0778", VA = "0x1BE0778")]
  public void Close()
  {
  }

  [Token(Token = "0x6000F8B")]
  [Address(RVA = "0x1BE0838", Offset = "0x1BE0838", VA = "0x1BE0838")]
  public IEnumerator CloseSync() => (IEnumerator) null;

  [Token(Token = "0x6000F8C")]
  [Address(RVA = "0x1BE08C8", Offset = "0x1BE08C8", VA = "0x1BE08C8")]
  public void OnDestroy()
  {
  }

  [Token(Token = "0x6000F8D")]
  [Address(RVA = "0x1BE08CC", Offset = "0x1BE08CC", VA = "0x1BE08CC")]
  private GuildChatLog.ChatType GetLogChatType(GuildChatMessageType log)
  {
    return new GuildChatLog.ChatType();
  }

  [Token(Token = "0x6000F8E")]
  [Address(RVA = "0x1BE0B48", Offset = "0x1BE0B48", VA = "0x1BE0B48")]
  private GuildMemberType GetMember(string playerId) => (GuildMemberType) null;

  [Token(Token = "0x6000F8F")]
  [Address(RVA = "0x1BE00FC", Offset = "0x1BE00FC", VA = "0x1BE00FC")]
  public void SetChatLog(List<GuildChatMessageType> logs, string postMessageId = "")
  {
  }

  [Token(Token = "0x6000F90")]
  [Address(RVA = "0x1BE06A8", Offset = "0x1BE06A8", VA = "0x1BE06A8")]
  private IEnumerator AutoScroll() => (IEnumerator) null;

  [Token(Token = "0x6000F91")]
  [Address(RVA = "0x1BE1080", Offset = "0x1BE1080", VA = "0x1BE1080")]
  private IEnumerator RequestChatLog(string lastMessageID = "") => (IEnumerator) null;

  [Token(Token = "0x6000F92")]
  [Address(RVA = "0x1BE111C", Offset = "0x1BE111C", VA = "0x1BE111C")]
  private IEnumerator OnErrorLog(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

  [Token(Token = "0x6000F93")]
  [Address(RVA = "0x1BE11A4", Offset = "0x1BE11A4", VA = "0x1BE11A4")]
  private void OnNetworkErrorSendCancel(NetworkErrorResult networkErrorResult)
  {
  }

  [Token(Token = "0x6000F94")]
  [Address(RVA = "0x1BE0710", Offset = "0x1BE0710", VA = "0x1BE0710")]
  private IEnumerator UpdateLog() => (IEnumerator) null;

  [Token(Token = "0x6000F95")]
  [Address(RVA = "0x1BE1278", Offset = "0x1BE1278", VA = "0x1BE1278")]
  public void SendChat(MessageTypeEnum type, string message)
  {
  }

  [Token(Token = "0x6000F96")]
  [Address(RVA = "0x1BE12B0", Offset = "0x1BE12B0", VA = "0x1BE12B0")]
  private IEnumerator RequestSend(MessageTypeEnum type, string message) => (IEnumerator) null;

  [Token(Token = "0x6000F97")]
  [Address(RVA = "0x1BE1358", Offset = "0x1BE1358", VA = "0x1BE1358")]
  private IEnumerator OnErrorSend(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

  [Token(Token = "0x6000F98")]
  [Address(RVA = "0x1BE11D0", Offset = "0x1BE11D0", VA = "0x1BE11D0")]
  private void SetupReSend()
  {
  }

  [Token(Token = "0x6000F99")]
  [Address(RVA = "0x1BE1588", Offset = "0x1BE1588", VA = "0x1BE1588")]
  public void RestrictionReSend(bool sw)
  {
  }

  [Token(Token = "0x6000F9A")]
  [Address(RVA = "0x1BE1644", Offset = "0x1BE1644", VA = "0x1BE1644")]
  public GuildChatLog()
  {
  }

  [Token(Token = "0x6000F9B")]
  [Address(RVA = "0x1BE169C", Offset = "0x1BE169C", VA = "0x1BE169C")]
  static GuildChatLog()
  {
  }

  [Token(Token = "0x200027F")]
  public enum ChatType
  {
    [Token(Token = "0x4000EDB")] MySelf,
    [Token(Token = "0x4000EDC")] Other,
    [Token(Token = "0x4000EDD")] System,
    [Token(Token = "0x4000EDE")] Term,
  }
}
