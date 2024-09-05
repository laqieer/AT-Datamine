// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.RecoveryTime.RecoveryTimeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.APRecovery.RecoveryTime
{
  [Token(Token = "0x200396D")]
  public class RecoveryTimeView : RecoveryTimeViewBase
  {
    [Token(Token = "0x400FAFD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _apRecoveryTimeText;
    [Token(Token = "0x400FAFE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool _hasFull;

    [Token(Token = "0x6016933")]
    [Address(RVA = "0x42F131C", Offset = "0x42F131C", VA = "0x42F131C", Slot = "6")]
    public override void SetRecoveryTimeSec(float timeSec)
    {
    }

    [Token(Token = "0x6016934")]
    [Address(RVA = "0x42F16BC", Offset = "0x42F16BC", VA = "0x42F16BC", Slot = "7")]
    public override void SetVisibleRecoveryTime(bool isVisible)
    {
    }

    [Token(Token = "0x6016935")]
    [Address(RVA = "0x42F175C", Offset = "0x42F175C", VA = "0x42F175C")]
    public RecoveryTimeView()
    {
    }
  }
}
