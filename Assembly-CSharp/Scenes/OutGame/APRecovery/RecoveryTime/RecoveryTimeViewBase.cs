// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.RecoveryTime.RecoveryTimeViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery.RecoveryTime
{
  [Token(Token = "0x200396F")]
  public abstract class RecoveryTimeViewBase : MonoBehaviour, IRecoveryTimeView
  {
    [Token(Token = "0x6016938")]
    public abstract void SetRecoveryTimeSec(float timeSec);

    [Token(Token = "0x6016939")]
    public abstract void SetVisibleRecoveryTime(bool isVisible);

    [Token(Token = "0x601693A")]
    [Address(RVA = "0x42F1764", Offset = "0x42F1764", VA = "0x42F1764")]
    protected RecoveryTimeViewBase()
    {
    }
  }
}
