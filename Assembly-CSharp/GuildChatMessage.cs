// Decompiled with JetBrains decompiler
// Type: GuildChatMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000289")]
public class GuildChatMessage : MonoBehaviour
{
  [Token(Token = "0x4000F01")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject StripedBG;
  [Token(Token = "0x4000F02")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private GameObject loadingIcon;
  [Token(Token = "0x4000F03")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject activateChat;
  [Token(Token = "0x4000F04")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private TextMeshProUGUI postText;
  [Token(Token = "0x4000F05")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private TextMeshProUGUI postChatTimeText;
  [Token(Token = "0x4000F06")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private GameObject activateStamp;
  [Token(Token = "0x4000F07")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private StampIcon stampIcon;
  [Token(Token = "0x4000F08")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private TextMeshProUGUI postStampTimeText;
  [Token(Token = "0x4000F09")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private TextMeshProUGUI userNameText;
  [Token(Token = "0x4000F0A")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private StyleThumb styleThumb;
  [Token(Token = "0x4000F0B")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private GameObject directorGuildMaster;
  [Token(Token = "0x4000F0C")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private GameObject directorSubMaster;
  [Token(Token = "0x4000F0D")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private GameObject activateReSend;
  [Token(Token = "0x4000F0E")]
  [FieldOffset(Offset = "0x80")]
  private GuildMemberType member;
  [Token(Token = "0x4000F10")]
  [FieldOffset(Offset = "0x90")]
  private AssetCachedSpawner assetCachedSpawner;

  [Token(Token = "0x1700016A")]
  public string PlayerID
  {
    [Token(Token = "0x6000FD2"), Address(RVA = "0x1BE19C4", Offset = "0x1BE19C4", VA = "0x1BE19C4")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700016B")]
  private GuildChatMessageType Message
  {
    [Token(Token = "0x6000FD3"), Address(RVA = "0x1BE2BD8", Offset = "0x1BE2BD8", VA = "0x1BE2BD8")] get
    {
      return (GuildChatMessageType) null;
    }
    [Token(Token = "0x6000FD4"), Address(RVA = "0x1BE2BE0", Offset = "0x1BE2BE0", VA = "0x1BE2BE0")] set
    {
    }
  }

  [Token(Token = "0x6000FD5")]
  [Address(RVA = "0x1BE2BE8", Offset = "0x1BE2BE8", VA = "0x1BE2BE8")]
  public static DateTime GetPostTime(int postTime) => new DateTime();

  [Token(Token = "0x6000FD6")]
  [Address(RVA = "0x1BE2CC8", Offset = "0x1BE2CC8", VA = "0x1BE2CC8")]
  private void SetLogeBase(GuildChatMessageType message, GuildMemberType member, bool isStripedBG = false)
  {
  }

  [Token(Token = "0x6000FD7")]
  [Address(RVA = "0x1BE0D2C", Offset = "0x1BE0D2C", VA = "0x1BE0D2C")]
  public void SetLog(
    GuildChatMessageType message,
    GuildMemberType member,
    bool isStripedBG = false,
    Action<GuildMemberType> OnMemberDitail = null,
    AssetCachedSpawner assetLoader = null)
  {
  }

  [Token(Token = "0x6000FD8")]
  [Address(RVA = "0x1BE2DBC", Offset = "0x1BE2DBC", VA = "0x1BE2DBC")]
  public IEnumerator SetLogAsync(
    GuildChatMessageType message,
    GuildMemberType member,
    bool isStripedBG = false,
    Action<GuildMemberType> OnMemberDitail = null,
    AssetCachedSpawner assetLoader = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000FD9")]
  [Address(RVA = "0x1BE292C", Offset = "0x1BE292C", VA = "0x1BE292C")]
  public IEnumerator SetSendSync(
    MessageTypeEnum type,
    string message,
    GuildMemberType member,
    bool isStripedBG = false,
    Action<GuildMemberType> OnMemberDitail = null,
    AssetCachedSpawner assetLoader = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000FDA")]
  [Address(RVA = "0x1BE13E8", Offset = "0x1BE13E8", VA = "0x1BE13E8")]
  public void ActivateReSend(Action<MessageTypeEnum, string> clickAction)
  {
  }

  [Token(Token = "0x6000FDB")]
  [Address(RVA = "0x1BE1524", Offset = "0x1BE1524", VA = "0x1BE1524")]
  public void InteractableReSend(bool sw)
  {
  }

  [Token(Token = "0x6000FDC")]
  [Address(RVA = "0x1BE1A18", Offset = "0x1BE1A18", VA = "0x1BE1A18")]
  public void UpdateLog(GuildMemberType updateMember)
  {
  }

  [Token(Token = "0x6000FDD")]
  [Address(RVA = "0x1BE2EB8", Offset = "0x1BE2EB8", VA = "0x1BE2EB8")]
  public GuildChatMessage()
  {
  }
}
