// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.PoolableMissionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Utility;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003742")]
  public sealed class PoolableMissionCell : IPoolable<MissionCell, PoolableMissionCell>, IDisposable
  {
    [Token(Token = "0x400F14A")]
    [FieldOffset(Offset = "0x18")]
    private Transform defaultParent;

    [Token(Token = "0x170047F5")]
    public MissionCell Entity
    {
      [Token(Token = "0x6015C35"), Address(RVA = "0x1B2763C", Offset = "0x1B2763C", VA = "0x1B2763C")] get
      {
        return (MissionCell) null;
      }
      [Token(Token = "0x6015C36"), Address(RVA = "0x1B27644", Offset = "0x1B27644", VA = "0x1B27644")] private set
      {
      }
    }

    [Token(Token = "0x6015C37")]
    [Address(RVA = "0x1B2764C", Offset = "0x1B2764C", VA = "0x1B2764C")]
    public PoolableMissionCell(MissionCell entity, Transform root, bool isTemplate)
    {
    }

    [Token(Token = "0x6015C38")]
    [Address(RVA = "0x1B27764", Offset = "0x1B27764", VA = "0x1B27764", Slot = "6")]
    public void BringBack()
    {
    }

    [Token(Token = "0x6015C39")]
    [Address(RVA = "0x1B2781C", Offset = "0x1B2781C", VA = "0x1B2781C", Slot = "4")]
    public PoolableMissionCell Clone() => (PoolableMissionCell) null;

    [Token(Token = "0x6015C3A")]
    [Address(RVA = "0x1B2794C", Offset = "0x1B2794C", VA = "0x1B2794C", Slot = "7")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6015C3B")]
    [Address(RVA = "0x1B27A2C", Offset = "0x1B27A2C", VA = "0x1B27A2C", Slot = "5")]
    public void Reset()
    {
    }
  }
}
