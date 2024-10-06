// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApHeader.ApHeaderView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.APRecovery.RecoveryTime;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery.ApHeader
{
  [Token(Token = "0x200397C")]
  public class ApHeaderView : MonoBehaviour
  {
    [Token(Token = "0x400FB2A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private APIconView _apIcon;
    [Token(Token = "0x400FB2B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RecoveryTimeViewBase _apRecoveryTimeText;

    [Token(Token = "0x6016992")]
    [Address(RVA = "0x42F2D0C", Offset = "0x42F2D0C", VA = "0x42F2D0C")]
    public void SetAp(int ap)
    {
    }

    [Token(Token = "0x6016993")]
    [Address(RVA = "0x42F2D28", Offset = "0x42F2D28", VA = "0x42F2D28")]
    public void SetRecoveryTimeSec(float timeSec)
    {
    }

    [Token(Token = "0x6016994")]
    [Address(RVA = "0x42F2DC0", Offset = "0x42F2DC0", VA = "0x42F2DC0")]
    public void SetVisibleRecoveryTime(bool isVisible)
    {
    }

    [Token(Token = "0x6016995")]
    [Address(RVA = "0x42F2F0C", Offset = "0x42F2F0C", VA = "0x42F2F0C")]
    public ApHeaderView()
    {
    }
  }
}
