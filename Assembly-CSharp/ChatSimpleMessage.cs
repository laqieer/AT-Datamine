// Decompiled with JetBrains decompiler
// Type: ChatSimpleMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.ChatInfo;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200025E")]
public class ChatSimpleMessage : MonoBehaviour
{
  [Token(Token = "0x4000E0B")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Image stampIcon;
  [Token(Token = "0x4000E0C")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Text msgText;
  [Token(Token = "0x4000E0D")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Text msgPlayerName;
  [Token(Token = "0x4000E0E")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private UITweenGroup tweenGroup;
  [Token(Token = "0x4000E0F")]
  [FieldOffset(Offset = "0x38")]
  private ChatMessageType messageData;
  [Token(Token = "0x4000E10")]
  [FieldOffset(Offset = "0x40")]
  private ChatInfoLoader loader;
  [Token(Token = "0x4000E11")]
  [FieldOffset(Offset = "0x48")]
  private int currentCategoryID;
  [Token(Token = "0x4000E12")]
  [FieldOffset(Offset = "0x50")]
  private UnityAction callBack;

  [Token(Token = "0x6000EE2")]
  [Address(RVA = "0x1C932A0", Offset = "0x1C932A0", VA = "0x1C932A0")]
  public void SetData(ChatMessageType data)
  {
  }

  [Token(Token = "0x6000EE3")]
  [Address(RVA = "0x1C93378", Offset = "0x1C93378", VA = "0x1C93378")]
  private void ShowMessage()
  {
  }

  [Token(Token = "0x6000EE4")]
  [Address(RVA = "0x1C93530", Offset = "0x1C93530", VA = "0x1C93530")]
  private void LoadSprites(string stampID)
  {
  }

  [Token(Token = "0x6000EE5")]
  [Address(RVA = "0x1C935E0", Offset = "0x1C935E0", VA = "0x1C935E0")]
  private IEnumerator SetClose() => (IEnumerator) null;

  [Token(Token = "0x6000EE6")]
  [Address(RVA = "0x1C93670", Offset = "0x1C93670", VA = "0x1C93670")]
  public ChatSimpleMessage()
  {
  }
}
