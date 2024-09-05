// Decompiled with JetBrains decompiler
// Type: staq.CommonButtonManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C36")]
  public class CommonButtonManager : SingletonMonoBehaviour<CommonButtonManager>
  {
    [Token(Token = "0x4010B1C")]
    [FieldOffset(Offset = "0x20")]
    private List<WeakReference<ProcessingFlag>> disabledButtons;
    [Token(Token = "0x4010B1D")]
    [FieldOffset(Offset = "0x28")]
    private bool isFirstClick;

    [Token(Token = "0x17004CE5")]
    public bool IsDisabledButton
    {
      [Token(Token = "0x6017AA3"), Address(RVA = "0x238901C", Offset = "0x238901C", VA = "0x238901C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017AA4")]
    [Address(RVA = "0x2389064", Offset = "0x2389064", VA = "0x2389064")]
    private void ForceEnableButton()
    {
    }

    [Token(Token = "0x6017AA5")]
    [Address(RVA = "0x23892B8", Offset = "0x23892B8", VA = "0x23892B8")]
    public bool FirstClick() => new bool();

    [Token(Token = "0x6017AA6")]
    [Address(RVA = "0x23892D8", Offset = "0x23892D8", VA = "0x23892D8")]
    private void Update()
    {
    }

    [Token(Token = "0x6017AA7")]
    [Address(RVA = "0x23892E0", Offset = "0x23892E0", VA = "0x23892E0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017AA8")]
    [Address(RVA = "0x23892E4", Offset = "0x23892E4", VA = "0x23892E4")]
    public CommonButtonManager()
    {
    }

    [Token(Token = "0x2003C37")]
    public class DisableFlag : ProcessingFlag
    {
      [Token(Token = "0x6017AA9")]
      [Address(RVA = "0x2389378", Offset = "0x2389378", VA = "0x2389378")]
      public DisableFlag(bool cntlEventSystem = false)
      {
      }

      [Token(Token = "0x6017AAA")]
      [Address(RVA = "0x2389384", Offset = "0x2389384", VA = "0x2389384", Slot = "5")]
      protected override List<WeakReference<ProcessingFlag>> GetInspectors()
      {
        return (List<WeakReference<ProcessingFlag>>) null;
      }

      [Token(Token = "0x6017AAB")]
      [Address(RVA = "0x23893FC", Offset = "0x23893FC", VA = "0x23893FC", Slot = "6")]
      protected override IReadOnlyList<WeakReference<ProcessingFlag>>[] GetAllInspectors()
      {
        return (IReadOnlyList<WeakReference<ProcessingFlag>>[]) null;
      }
    }
  }
}
