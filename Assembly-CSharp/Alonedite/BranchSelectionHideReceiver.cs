// Decompiled with JetBrains decompiler
// Type: Alonedite.BranchSelectionHideReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Alonedite
{
  [Token(Token = "0x200286D")]
  public class BranchSelectionHideReceiver : MonoBehaviour, INotificationReceiver
  {
    [Token(Token = "0x400AC4B")]
    [FieldOffset(Offset = "0x18")]
    public BranchSelectionManager manager;

    [Token(Token = "0x600FEA6")]
    [Address(RVA = "0x40F0330", Offset = "0x40F0330", VA = "0x40F0330", Slot = "4")]
    public void OnNotify(Playable origin, INotification notification, object context)
    {
    }

    [Token(Token = "0x600FEA7")]
    [Address(RVA = "0x40F06D0", Offset = "0x40F06D0", VA = "0x40F06D0")]
    public BranchSelectionHideReceiver()
    {
    }
  }
}
