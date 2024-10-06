// Decompiled with JetBrains decompiler
// Type: ChatListItemParent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.Chat.Top;

#nullable disable
[Token(Token = "0x2000258")]
public class ChatListItemParent : InfiniteCellBase
{
  [Token(Token = "0x4000DEE")]
  [FieldOffset(Offset = "0x28")]
  public ChatListItem LeftItem;
  [Token(Token = "0x4000DEF")]
  [FieldOffset(Offset = "0x30")]
  public ChatListItem RightItem;
  [Token(Token = "0x4000DF0")]
  [FieldOffset(Offset = "0x38")]
  private ChatMessageType messageData;

  [Token(Token = "0x6000EBD")]
  [Address(RVA = "0x1C91760", Offset = "0x1C91760", VA = "0x1C91760")]
  public void SetData(ChatMessageType messageType)
  {
  }

  [Token(Token = "0x6000EBE")]
  [Address(RVA = "0x1C918A0", Offset = "0x1C918A0", VA = "0x1C918A0", Slot = "4")]
  public override void OnUpdate()
  {
  }

  [Token(Token = "0x6000EBF")]
  [Address(RVA = "0x1C91964", Offset = "0x1C91964", VA = "0x1C91964")]
  public ChatListItemParent()
  {
  }
}
