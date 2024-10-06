// Decompiled with JetBrains decompiler
// Type: Battle.UI.PoolableRewardItemPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Utility;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002337")]
  public sealed class PoolableRewardItemPanel : 
    IPoolable<RewardItemPanel, PoolableRewardItemPanel>,
    IDisposable
  {
    [Token(Token = "0x400956C")]
    [FieldOffset(Offset = "0x10")]
    private RewardItemPanel entity;
    [Token(Token = "0x400956D")]
    [FieldOffset(Offset = "0x18")]
    private Transform defaultParent;

    [Token(Token = "0x17002E62")]
    public RewardItemPanel Entity
    {
      [Token(Token = "0x600D751"), Address(RVA = "0x1D27144", Offset = "0x1D27144", VA = "0x1D27144")] get
      {
        return (RewardItemPanel) null;
      }
    }

    [Token(Token = "0x600D752")]
    [Address(RVA = "0x1D1B8A4", Offset = "0x1D1B8A4", VA = "0x1D1B8A4")]
    public PoolableRewardItemPanel(RewardItemPanel entity, Transform root, bool isTemplate)
    {
    }

    [Token(Token = "0x600D753")]
    [Address(RVA = "0x1D2714C", Offset = "0x1D2714C", VA = "0x1D2714C", Slot = "6")]
    public void BringBack()
    {
    }

    [Token(Token = "0x600D754")]
    [Address(RVA = "0x1D27204", Offset = "0x1D27204", VA = "0x1D27204", Slot = "4")]
    public PoolableRewardItemPanel Clone() => (PoolableRewardItemPanel) null;

    [Token(Token = "0x600D755")]
    [Address(RVA = "0x1D27334", Offset = "0x1D27334", VA = "0x1D27334", Slot = "7")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D756")]
    [Address(RVA = "0x1D27414", Offset = "0x1D27414", VA = "0x1D27414", Slot = "5")]
    public void Reset()
    {
    }
  }
}
