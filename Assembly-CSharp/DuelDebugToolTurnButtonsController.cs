// Decompiled with JetBrains decompiler
// Type: DuelDebugToolTurnButtonsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000124")]
public class DuelDebugToolTurnButtonsController : MonoBehaviour
{
  [Token(Token = "0x4000628")]
  [FieldOffset(Offset = "0x18")]
  private DuelDebugToolController duelDebugToolController;
  [Token(Token = "0x4000629")]
  [FieldOffset(Offset = "0x20")]
  public int turnIndex;
  [Token(Token = "0x400062A")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Text buttonText;

  [Token(Token = "0x600080C")]
  [Address(RVA = "0x485AC20", Offset = "0x485AC20", VA = "0x485AC20")]
  public void Initialize(DuelDebugToolController duelDebugToolController, int turnIndex)
  {
  }

  [Token(Token = "0x600080D")]
  [Address(RVA = "0x485B6F4", Offset = "0x485B6F4", VA = "0x485B6F4")]
  public void UpdateTurnIndex(int turnIndex)
  {
  }

  [Token(Token = "0x600080E")]
  [Address(RVA = "0x485D6FC", Offset = "0x485D6FC", VA = "0x485D6FC")]
  public void OnClickSelectTurnButton()
  {
  }

  [Token(Token = "0x600080F")]
  [Address(RVA = "0x485D720", Offset = "0x485D720", VA = "0x485D720")]
  public void OnClickRemoveTurnButton()
  {
  }

  [Token(Token = "0x6000810")]
  [Address(RVA = "0x485D740", Offset = "0x485D740", VA = "0x485D740")]
  public DuelDebugToolTurnButtonsController()
  {
  }
}
