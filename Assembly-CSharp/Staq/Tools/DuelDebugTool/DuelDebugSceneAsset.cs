// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugSceneAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000981")]
  [CreateAssetMenu(menuName = "Duel/Duel Debug Scene Asset")]
  public class DuelDebugSceneAsset : ScriptableObject
  {
    [Token(Token = "0x4002C32")]
    [FieldOffset(Offset = "0x18")]
    public int EnvironmentId;
    [Token(Token = "0x4002C33")]
    [FieldOffset(Offset = "0x1C")]
    public bool EnableObliviae;
    [Token(Token = "0x4002C34")]
    [FieldOffset(Offset = "0x20")]
    public BattleBgColorIdEnum BattleBgColorIdEnum;
    [Token(Token = "0x4002C35")]
    [FieldOffset(Offset = "0x28")]
    public DuelDebugActor AttackerSetting;
    [Token(Token = "0x4002C36")]
    [FieldOffset(Offset = "0x30")]
    public DuelDebugActor AttackerSupporterSetting;
    [Token(Token = "0x4002C37")]
    [FieldOffset(Offset = "0x38")]
    public DuelDebugActor DefenderSetting;
    [Token(Token = "0x4002C38")]
    [FieldOffset(Offset = "0x40")]
    public DuelDebugActor DefenderSupporterSetting;
    [Token(Token = "0x4002C39")]
    [FieldOffset(Offset = "0x48")]
    public List<DuelDebugTurn> TurnActions;

    [Token(Token = "0x600360D")]
    [Address(RVA = "0x3531830", Offset = "0x3531830", VA = "0x3531830")]
    public DuelDebugSceneAsset()
    {
    }
  }
}
