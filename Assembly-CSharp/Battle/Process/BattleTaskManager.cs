// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleTaskManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026AE")]
  public class BattleTaskManager : IStepUpdate
  {
    [Token(Token = "0x400A5E0")]
    [FieldOffset(Offset = "0x10")]
    private Queue<BattleTaskManager.BattleTask> taskQueue;
    [Token(Token = "0x400A5E1")]
    [FieldOffset(Offset = "0x18")]
    private Stack<BattleTaskManager.BattleTask> taskStack;
    [Token(Token = "0x400A5E3")]
    [FieldOffset(Offset = "0x21")]
    public bool ForceBreakDirty;

    [Token(Token = "0x170032A7")]
    public bool TaskStart
    {
      [Token(Token = "0x600EF86"), Address(RVA = "0x40DA2E8", Offset = "0x40DA2E8", VA = "0x40DA2E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EF87"), Address(RVA = "0x40DA2F0", Offset = "0x40DA2F0", VA = "0x40DA2F0")] private set
      {
      }
    }

    [Token(Token = "0x600EF88")]
    [Address(RVA = "0x40DA2FC", Offset = "0x40DA2FC", VA = "0x40DA2FC", Slot = "4")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600EF89")]
    [Address(RVA = "0x40DA464", Offset = "0x40DA464", VA = "0x40DA464")]
    public void SolveAll()
    {
    }

    [Token(Token = "0x600EF8A")]
    [Address(RVA = "0x40DA5A8", Offset = "0x40DA5A8", VA = "0x40DA5A8")]
    public void Enqueue(Action task)
    {
    }

    [Token(Token = "0x600EF8B")]
    [Address(RVA = "0x40DA664", Offset = "0x40DA664", VA = "0x40DA664")]
    public void Enqueue(Func<bool> validate, Action task)
    {
    }

    [Token(Token = "0x600EF8C")]
    [Address(RVA = "0x40DA728", Offset = "0x40DA728", VA = "0x40DA728")]
    public void Push(Action task)
    {
    }

    [Token(Token = "0x600EF8D")]
    [Address(RVA = "0x40DA7BC", Offset = "0x40DA7BC", VA = "0x40DA7BC")]
    public bool IsTask() => new bool();

    [Token(Token = "0x600EF8E")]
    [Address(RVA = "0x40DA804", Offset = "0x40DA804", VA = "0x40DA804")]
    public BattleTaskManager()
    {
    }

    [Token(Token = "0x20026AF")]
    private class BattleTask
    {
      [Token(Token = "0x400A5E4")]
      [FieldOffset(Offset = "0x10")]
      private Func<bool> validate;
      [Token(Token = "0x400A5E5")]
      [FieldOffset(Offset = "0x18")]
      private Action task;

      [Token(Token = "0x600EF8F")]
      [Address(RVA = "0x40DA63C", Offset = "0x40DA63C", VA = "0x40DA63C")]
      public BattleTask(Action task)
      {
      }

      [Token(Token = "0x600EF90")]
      [Address(RVA = "0x40DA6FC", Offset = "0x40DA6FC", VA = "0x40DA6FC")]
      public BattleTask(Func<bool> validate, Action task)
      {
      }

      [Token(Token = "0x600EF91")]
      [Address(RVA = "0x40DA428", Offset = "0x40DA428", VA = "0x40DA428")]
      public bool Validate() => new bool();

      [Token(Token = "0x600EF92")]
      [Address(RVA = "0x40DA448", Offset = "0x40DA448", VA = "0x40DA448")]
      public void Invoke()
      {
      }
    }
  }
}
