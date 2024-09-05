// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Top.ChatListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.ChatInfo;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.Top
{
  [Token(Token = "0x20030E4")]
  public class ChatListItem : MonoBehaviour
  {
    [Token(Token = "0x400D007")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textPlayerName;
    [Token(Token = "0x400D008")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textMessageInAt;
    [Token(Token = "0x400D009")]
    [FieldOffset(Offset = "0x28")]
    public Text textContent;
    [Token(Token = "0x400D00A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image chatStamp;
    [Token(Token = "0x400D00B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image chatIcon;
    [Token(Token = "0x400D00C")]
    [FieldOffset(Offset = "0x40")]
    private CHATMSGTYPE chatMsgType;
    [Token(Token = "0x400D00D")]
    [FieldOffset(Offset = "0x48")]
    private ChatMessageType chatMessage;
    [Token(Token = "0x400D00E")]
    [FieldOffset(Offset = "0x50")]
    private string playerID;
    [Token(Token = "0x400D00F")]
    [FieldOffset(Offset = "0x58")]
    private ChatInfoLoader loader;

    [Token(Token = "0x6013184")]
    [Address(RVA = "0x45D9BA8", Offset = "0x45D9BA8", VA = "0x45D9BA8")]
    public void SetData(ChatMessageType messageType)
    {
    }

    [Token(Token = "0x6013185")]
    [Address(RVA = "0x45D9BB0", Offset = "0x45D9BB0", VA = "0x45D9BB0")]
    public void ShowInfo()
    {
    }

    [Token(Token = "0x6013186")]
    [Address(RVA = "0x45D9E4C", Offset = "0x45D9E4C", VA = "0x45D9E4C")]
    public void PlayStamp()
    {
    }

    [Token(Token = "0x6013187")]
    [Address(RVA = "0x45D9BD8", Offset = "0x45D9BD8", VA = "0x45D9BD8")]
    private void ChangeMessageType()
    {
    }

    [Token(Token = "0x6013188")]
    [Address(RVA = "0x45D9F88", Offset = "0x45D9F88", VA = "0x45D9F88")]
    private string GetMessageTime(int postTime) => (string) null;

    [Token(Token = "0x6013189")]
    [Address(RVA = "0x45DA0CC", Offset = "0x45DA0CC", VA = "0x45DA0CC")]
    private void LoadStampSprites(string stampID)
    {
    }

    [Token(Token = "0x601318A")]
    [Address(RVA = "0x45DA01C", Offset = "0x45DA01C", VA = "0x45DA01C")]
    private void LoadPlayerIcon(string iconID)
    {
    }

    [Token(Token = "0x601318B")]
    [Address(RVA = "0x45DA17C", Offset = "0x45DA17C", VA = "0x45DA17C")]
    public ChatListItem()
    {
    }
  }
}
