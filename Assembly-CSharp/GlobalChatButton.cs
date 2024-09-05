// Decompiled with JetBrains decompiler
// Type: GlobalChatButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000260")]
public class GlobalChatButton : MonoBehaviour, IAvoidRectTransfromAccessor
{
  [Token(Token = "0x4000E16")]
  [FieldOffset(Offset = "0x18")]
  public ChatSimpleMessage simpleMessage;
  [Token(Token = "0x4000E17")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private List<UITransfromAvoidElementBase> avoidRectTransform;
  [Token(Token = "0x4000E18")]
  [FieldOffset(Offset = "0x28")]
  private string currentSceneName;
  [Token(Token = "0x4000E19")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private RectTransform rectTransform;

  [Token(Token = "0x17000146")]
  public List<UITransfromAvoidElementBase> AvoidIconRectTransformList
  {
    [Token(Token = "0x6000EED"), Address(RVA = "0x1C9386C", Offset = "0x1C9386C", VA = "0x1C9386C", Slot = "4")] get
    {
      return (List<UITransfromAvoidElementBase>) null;
    }
  }

  [Token(Token = "0x17000147")]
  public RectTransform RectTransform
  {
    [Token(Token = "0x6000EEE"), Address(RVA = "0x1C93874", Offset = "0x1C93874", VA = "0x1C93874")] get
    {
      return (RectTransform) null;
    }
  }

  [Token(Token = "0x6000EEF")]
  [Address(RVA = "0x1C9387C", Offset = "0x1C9387C", VA = "0x1C9387C")]
  public void CloseChatDialog()
  {
  }

  [Token(Token = "0x6000EF0")]
  [Address(RVA = "0x1C93880", Offset = "0x1C93880", VA = "0x1C93880")]
  public void OnClickChatButton()
  {
  }

  [Token(Token = "0x6000EF1")]
  [Address(RVA = "0x1C9392C", Offset = "0x1C9392C", VA = "0x1C9392C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000EF2")]
  [Address(RVA = "0x1C93A5C", Offset = "0x1C93A5C", VA = "0x1C93A5C")]
  public GlobalChatButton()
  {
  }
}
