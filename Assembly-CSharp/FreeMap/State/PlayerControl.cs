// Decompiled with JetBrains decompiler
// Type: FreeMap.State.PlayerControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x2001799")]
  public abstract class PlayerControl : FreeMapPlayerProcess
  {
    [Token(Token = "0x17001547")]
    public bool IsAllow
    {
      [Token(Token = "0x6008603"), Address(RVA = "0x406E84C", Offset = "0x406E84C", VA = "0x406E84C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008604")]
    [Address(RVA = "0x406E8C4", Offset = "0x406E8C4", VA = "0x406E8C4")]
    public PlayerControl(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x200179A")]
    public class Init : PlayerControl
    {
      [Token(Token = "0x6008605")]
      [Address(RVA = "0x406E8CC", Offset = "0x406E8CC", VA = "0x406E8CC")]
      public Init()
      {
      }

      [Token(Token = "0x6008606")]
      [Address(RVA = "0x406E8D8", Offset = "0x406E8D8", VA = "0x406E8D8", Slot = "4")]
      public override void Begin()
      {
      }
    }

    [Token(Token = "0x200179B")]
    public class Allow : PlayerControl
    {
      [Token(Token = "0x17001548")]
      public List<PlayerControl.Allow.IDriven> Drivens
      {
        [Token(Token = "0x6008607"), Address(RVA = "0x406E928", Offset = "0x406E928", VA = "0x406E928")] get
        {
          return (List<PlayerControl.Allow.IDriven>) null;
        }
      }

      [Token(Token = "0x6008608")]
      [Address(RVA = "0x406E930", Offset = "0x406E930", VA = "0x406E930")]
      public Allow(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008609")]
      [Address(RVA = "0x406E9BC", Offset = "0x406E9BC", VA = "0x406E9BC", Slot = "4")]
      public override void Begin()
      {
      }

      [Token(Token = "0x600860A")]
      [Address(RVA = "0x406EA1C", Offset = "0x406EA1C", VA = "0x406EA1C", Slot = "5")]
      protected override void OnUpdate()
      {
      }

      [Token(Token = "0x200179C")]
      public interface IDriven
      {
        [Token(Token = "0x600860B")]
        void Update();
      }
    }

    [Token(Token = "0x200179D")]
    public class Disallow : PlayerControl
    {
      [Token(Token = "0x600860C")]
      [Address(RVA = "0x406EBCC", Offset = "0x406EBCC", VA = "0x406EBCC")]
      public Disallow(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x600860D")]
      [Address(RVA = "0x406EBD4", Offset = "0x406EBD4", VA = "0x406EBD4", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
