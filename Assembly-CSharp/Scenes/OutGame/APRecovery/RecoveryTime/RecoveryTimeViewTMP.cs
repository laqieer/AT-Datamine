// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.RecoveryTime.RecoveryTimeViewTMP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery.RecoveryTime
{
  [Token(Token = "0x2003970")]
  public class RecoveryTimeViewTMP : RecoveryTimeViewBase
  {
    [Token(Token = "0x400FAFF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _apRecoveryTimeText;

    [Token(Token = "0x601693B")]
    [Address(RVA = "0x42F176C", Offset = "0x42F176C", VA = "0x42F176C", Slot = "6")]
    public override void SetRecoveryTimeSec(float timeSec)
    {
    }

    [Token(Token = "0x601693C")]
    [Address(RVA = "0x42F1894", Offset = "0x42F1894", VA = "0x42F1894", Slot = "7")]
    public override void SetVisibleRecoveryTime(bool isVisible)
    {
    }

    [Token(Token = "0x601693D")]
    [Address(RVA = "0x42F1934", Offset = "0x42F1934", VA = "0x42F1934")]
    public RecoveryTimeViewTMP()
    {
    }
  }
}
