// Decompiled with JetBrains decompiler
// Type: ChatLogItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.ChatInfo;
using staq.SaveData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000259")]
public class ChatLogItem : MonoBehaviour
{
  [Token(Token = "0x4000DF1")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Image stampIcon;
  [Token(Token = "0x4000DF2")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Text stampText;
  [Token(Token = "0x4000DF3")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private LayoutElement layout;
  [Token(Token = "0x4000DF4")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private GameObject lockIcon;
  [Token(Token = "0x4000DF5")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private GameObject sePlayMark;
  [Token(Token = "0x4000DF6")]
  [FieldOffset(Offset = "0x40")]
  private ChatSaveData.ChatSaveLog saveLogData;
  [Token(Token = "0x4000DF7")]
  [FieldOffset(Offset = "0x48")]
  private ChatInfoLoader loader;
  [Token(Token = "0x4000DF8")]
  [FieldOffset(Offset = "0x50")]
  private Action<string, int> onClick;
  [Token(Token = "0x4000DF9")]
  [FieldOffset(Offset = "0x58")]
  private bool locking;
  [Token(Token = "0x4000DFA")]
  [FieldOffset(Offset = "0x60")]
  private string lockID;

  [Token(Token = "0x6000EC0")]
  [Address(RVA = "0x1C9196C", Offset = "0x1C9196C", VA = "0x1C9196C")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000EC1")]
  [Address(RVA = "0x1C91AF0", Offset = "0x1C91AF0", VA = "0x1C91AF0")]
  public void SetData(ChatSaveData.ChatSaveLog saveLog, Action<string, int> click)
  {
  }

  [Token(Token = "0x6000EC2")]
  [Address(RVA = "0x1C91F30", Offset = "0x1C91F30", VA = "0x1C91F30")]
  public void ChangeState(bool state)
  {
  }

  [Token(Token = "0x6000EC3")]
  [Address(RVA = "0x1C91FB8", Offset = "0x1C91FB8", VA = "0x1C91FB8")]
  public void PlaySE()
  {
  }

  [Token(Token = "0x6000EC4")]
  [Address(RVA = "0x1C91E1C", Offset = "0x1C91E1C", VA = "0x1C91E1C")]
  private void SetSEMark()
  {
  }

  [Token(Token = "0x6000EC5")]
  [Address(RVA = "0x1C91D4C", Offset = "0x1C91D4C", VA = "0x1C91D4C")]
  private void LoadSprites(string stampID)
  {
  }

  [Token(Token = "0x6000EC6")]
  [Address(RVA = "0x1C920FC", Offset = "0x1C920FC", VA = "0x1C920FC")]
  private IEnumerator SetLogLock() => (IEnumerator) null;

  [Token(Token = "0x6000EC7")]
  [Address(RVA = "0x1C91DFC", Offset = "0x1C91DFC", VA = "0x1C91DFC")]
  private void SetLockState(bool isLock)
  {
  }

  [Token(Token = "0x6000EC8")]
  [Address(RVA = "0x1C9218C", Offset = "0x1C9218C", VA = "0x1C9218C")]
  public ChatLogItem()
  {
  }
}
