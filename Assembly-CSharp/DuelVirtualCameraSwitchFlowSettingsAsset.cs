// Decompiled with JetBrains decompiler
// Type: DuelVirtualCameraSwitchFlowSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200018D")]
[CreateAssetMenu(menuName = "Duel/Duel Camera Switch Flow Settings Asset")]
public class DuelVirtualCameraSwitchFlowSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000A2A")]
  [FieldOffset(Offset = "0x18")]
  public DuelVirtualCameraSwitchFlowAsset attackerTeamCloseRangeVCSwitchFlow;
  [Token(Token = "0x4000A2B")]
  [FieldOffset(Offset = "0x20")]
  public DuelVirtualCameraSwitchFlowAsset attackerTeamLongRangeVCSwitchFlow;
  [Token(Token = "0x4000A2C")]
  [FieldOffset(Offset = "0x28")]
  public DuelVirtualCameraSwitchFlowAsset attackerTeamSupportVCSwitchFlow;
  [Token(Token = "0x4000A2D")]
  [FieldOffset(Offset = "0x30")]
  public DuelVirtualCameraSwitchFlowAsset defenderTeamCloseRangeVCSwitchFlow;
  [Token(Token = "0x4000A2E")]
  [FieldOffset(Offset = "0x38")]
  public DuelVirtualCameraSwitchFlowAsset defenderTeamLongRangeVCSwitchFlow;
  [Token(Token = "0x4000A2F")]
  [FieldOffset(Offset = "0x40")]
  public DuelVirtualCameraSwitchFlowAsset defenderTeamSupportVCSwitchFlow;
  [Token(Token = "0x4000A30")]
  [FieldOffset(Offset = "0x48")]
  public DuelTurnActions.VirtualCameraType attackerTeamMoveVCType;
  [Token(Token = "0x4000A31")]
  [FieldOffset(Offset = "0x4C")]
  public DuelTurnActions.VirtualCameraType defenderTeamMoveVCType;

  [Token(Token = "0x6000ABA")]
  [Address(RVA = "0x4BBA70C", Offset = "0x4BBA70C", VA = "0x4BBA70C")]
  public DuelVirtualCameraSwitchFlowSettingsAsset()
  {
  }
}
