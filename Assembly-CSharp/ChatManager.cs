// Decompiled with JetBrains decompiler
// Type: ChatManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200025B")]
public class ChatManager : SingletonMonoBehaviour<ChatManager>, IAvoidRectTransfromAccessor
{
  [Token(Token = "0x4000DFF")]
  private const string PREFAB_ASSET_BUNDLE_LABEL = "2dassets_ui_common";
  [Token(Token = "0x4000E00")]
  [FieldOffset(Offset = "0x20")]
  private GlobalChatButton chatButton;
  [Token(Token = "0x4000E01")]
  [FieldOffset(Offset = "0x28")]
  private bool canAddCallback;
  [Token(Token = "0x4000E02")]
  [FieldOffset(Offset = "0x30")]
  private IEnumerator chatLogCoroutine;
  [Token(Token = "0x4000E03")]
  [FieldOffset(Offset = "0x38")]
  private int chatSimpleLogPollingInterval;
  [Token(Token = "0x4000E04")]
  [FieldOffset(Offset = "0x3C")]
  public int pollingIndex;

  [Token(Token = "0x6000ED1")]
  [Address(RVA = "0x1C92820", Offset = "0x1C92820", VA = "0x1C92820")]
  public bool IsAvailable() => new bool();

  [Token(Token = "0x17000140")]
  public List<UITransfromAvoidElementBase> AvoidIconRectTransformList
  {
    [Token(Token = "0x6000ED2"), Address(RVA = "0x1C92880", Offset = "0x1C92880", VA = "0x1C92880", Slot = "8")] get
    {
      return (List<UITransfromAvoidElementBase>) null;
    }
  }

  [Token(Token = "0x6000ED3")]
  [Address(RVA = "0x1C92910", Offset = "0x1C92910", VA = "0x1C92910")]
  public void CreateMenu()
  {
  }

  [Token(Token = "0x6000ED4")]
  [Address(RVA = "0x1C92CB8", Offset = "0x1C92CB8", VA = "0x1C92CB8")]
  public void SetChatButtonState(bool state)
  {
  }

  [Token(Token = "0x6000ED5")]
  [Address(RVA = "0x1C92D5C", Offset = "0x1C92D5C", VA = "0x1C92D5C")]
  private void DefaultSetting()
  {
  }

  [Token(Token = "0x6000ED6")]
  [Address(RVA = "0x1C92C50", Offset = "0x1C92C50", VA = "0x1C92C50")]
  private IEnumerator RequestSimpleChatLogList() => (IEnumerator) null;

  [Token(Token = "0x6000ED7")]
  [Address(RVA = "0x1C92D8C", Offset = "0x1C92D8C", VA = "0x1C92D8C")]
  public ChatManager()
  {
  }
}
