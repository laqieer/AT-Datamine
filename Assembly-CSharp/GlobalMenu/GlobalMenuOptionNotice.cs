// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionNotice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B9F")]
  public class GlobalMenuOptionNotice : MonoBehaviour
  {
    [Token(Token = "0x40034F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleConfigItem battleFinishVibration;
    [Token(Token = "0x40034F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleConfigItem pushNotice;
    [Token(Token = "0x40034F3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BattleConfigItem[] pushNoticeChildToggles;
    [Token(Token = "0x40034F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BattleConfigItem allApRecovery;
    [Token(Token = "0x40034F5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattleConfigItem fragmentPoolFull;
    [Token(Token = "0x40034F6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BattleConfigItem factorizeRecovery;

    [Token(Token = "0x6004254")]
    [Address(RVA = "0x2A348B0", Offset = "0x2A348B0", VA = "0x2A348B0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004255")]
    [Address(RVA = "0x2A35A58", Offset = "0x2A35A58", VA = "0x2A35A58")]
    public void OnValueChangedBattleFinishVibration(bool isOn)
    {
    }

    [Token(Token = "0x6004256")]
    [Address(RVA = "0x2A35AE8", Offset = "0x2A35AE8", VA = "0x2A35AE8")]
    public void OnValueChangedPushNotice(bool isOn)
    {
    }

    [Token(Token = "0x6004257")]
    [Address(RVA = "0x2A35C48", Offset = "0x2A35C48", VA = "0x2A35C48")]
    public void OnValueChangedAllApRecovery(bool isOn)
    {
    }

    [Token(Token = "0x6004258")]
    [Address(RVA = "0x2A35CD8", Offset = "0x2A35CD8", VA = "0x2A35CD8")]
    public void OnValueChangedFragmentPoolFull(bool isOn)
    {
    }

    [Token(Token = "0x6004259")]
    [Address(RVA = "0x2A35DD8", Offset = "0x2A35DD8", VA = "0x2A35DD8")]
    public void OnValueChangedFactorizeRecovery(bool isOn)
    {
    }

    [Token(Token = "0x600425A")]
    [Address(RVA = "0x2A35E68", Offset = "0x2A35E68", VA = "0x2A35E68")]
    public GlobalMenuOptionNotice()
    {
    }
  }
}
