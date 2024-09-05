// Decompiled with JetBrains decompiler
// Type: DuelCharacterAgentSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000F8")]
[CreateAssetMenu(menuName = "Duel/Duel Character Agent Settings Asset")]
public class DuelCharacterAgentSettingsAsset : ScriptableObject
{
  [Token(Token = "0x400049F")]
  [FieldOffset(Offset = "0x18")]
  public float minRunSpeed;
  [Token(Token = "0x40004A0")]
  [FieldOffset(Offset = "0x1C")]
  public float minWalkSpeed;
  [Token(Token = "0x40004A1")]
  [FieldOffset(Offset = "0x20")]
  public float moveForwardThreshold;
  [Token(Token = "0x40004A2")]
  [FieldOffset(Offset = "0x24")]
  public float moveBackwardThreshold;
  [Token(Token = "0x40004A3")]
  [FieldOffset(Offset = "0x28")]
  public float agentRadius;
  [Token(Token = "0x40004A4")]
  [FieldOffset(Offset = "0x2C")]
  public float agentHeight;
  [Token(Token = "0x40004A5")]
  [FieldOffset(Offset = "0x30")]
  public float relativeDistanceFromPartner;

  [Token(Token = "0x60006DE")]
  [Address(RVA = "0x4188644", Offset = "0x4188644", VA = "0x4188644")]
  public DuelCharacterAgentSettingsAsset()
  {
  }
}
