// Decompiled with JetBrains decompiler
// Type: DuelDebugToolEnvironmentSettingsPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000122")]
public class DuelDebugToolEnvironmentSettingsPanelController : 
  MonoBehaviour,
  IDuelDebugToolEnvironmentSettings
{
  [Token(Token = "0x4000622")]
  [FieldOffset(Offset = "0x18")]
  private DuelDebugToolController duelDebugToolController;
  [Token(Token = "0x4000623")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Dropdown sceneNameDropDown;
  [Token(Token = "0x4000624")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private InputField sceneNameInputField;
  [Token(Token = "0x4000625")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Dropdown mementosFloorDropDown;
  [Token(Token = "0x4000626")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private InputField mementosFloorInputField;

  [Token(Token = "0x6000805")]
  [Address(RVA = "0x485B994", Offset = "0x485B994", VA = "0x485B994")]
  public void Initialize(DuelDebugToolController duelDebugToolController)
  {
  }

  [Token(Token = "0x6000806")]
  [Address(RVA = "0x485D5B0", Offset = "0x485D5B0", VA = "0x485D5B0")]
  public void OnSceneNameDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x6000807")]
  [Address(RVA = "0x485D630", Offset = "0x485D630", VA = "0x485D630")]
  public void OnMementosFloorDropDownValueChanged(int value)
  {
  }

  [Token(Token = "0x6000808")]
  [Address(RVA = "0x485D6B0", Offset = "0x485D6B0", VA = "0x485D6B0", Slot = "4")]
  public string GetSceneName() => (string) null;

  [Token(Token = "0x6000809")]
  [Address(RVA = "0x485D6CC", Offset = "0x485D6CC", VA = "0x485D6CC")]
  public int GetMementosFloor() => new int();

  [Token(Token = "0x600080A")]
  [Address(RVA = "0x485D6EC", Offset = "0x485D6EC", VA = "0x485D6EC")]
  public DuelDebugToolEnvironmentSettingsPanelController()
  {
  }
}
