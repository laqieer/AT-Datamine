// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ProcessHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017E2")]
  public class ProcessHandler
  {
    [Token(Token = "0x40068DD")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapProcess processing;
    [Token(Token = "0x40068DE")]
    [FieldOffset(Offset = "0x18")]
    private Queue<FreeMapProcess> processQueue;
    [Token(Token = "0x40068DF")]
    [FieldOffset(Offset = "0x20")]
    private FreeMapStateManager entity;

    [Token(Token = "0x17001567")]
    public bool IsProcessing
    {
      [Token(Token = "0x600871A"), Address(RVA = "0x43D466C", Offset = "0x43D466C", VA = "0x43D466C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600871B")]
    [Address(RVA = "0x43D467C", Offset = "0x43D467C", VA = "0x43D467C")]
    public ProcessHandler(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600871C")]
    [Address(RVA = "0x43D470C", Offset = "0x43D470C", VA = "0x43D470C")]
    public void Update()
    {
    }

    [Token(Token = "0x600871D")]
    [Address(RVA = "0x43D4764", Offset = "0x43D4764", VA = "0x43D4764")]
    public void AddProcess(FreeMapProcess process)
    {
    }

    [Token(Token = "0x600871E")]
    [Address(RVA = "0x43D483C", Offset = "0x43D483C", VA = "0x43D483C")]
    public void OnBackKeyDownAction()
    {
    }

    [Token(Token = "0x600871F")]
    [Address(RVA = "0x43D48E8", Offset = "0x43D48E8", VA = "0x43D48E8")]
    public void AllCancel()
    {
    }

    [Token(Token = "0x6008720")]
    [Address(RVA = "0x43D485C", Offset = "0x43D485C", VA = "0x43D485C")]
    private void OnProcessEnd()
    {
    }
  }
}
