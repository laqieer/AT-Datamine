// Decompiled with JetBrains decompiler
// Type: Routine.MoveArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002245")]
  public class MoveArg : ActionArg, IMovePositionArg
  {
    [Token(Token = "0x17002D58")]
    public ActionArg.ActionSettingType ActionSetting
    {
      [Token(Token = "0x600D06C"), Address(RVA = "0x4CD822C", Offset = "0x4CD822C", VA = "0x4CD822C", Slot = "5")] get
      {
        return new ActionArg.ActionSettingType();
      }
      [Token(Token = "0x600D06D"), Address(RVA = "0x4CD8234", Offset = "0x4CD8234", VA = "0x4CD8234")] protected set
      {
      }
    }

    [Token(Token = "0x17002D59")]
    public List<(int x, int y)> DestList
    {
      [Token(Token = "0x600D06E"), Address(RVA = "0x4CD823C", Offset = "0x4CD823C", VA = "0x4CD823C", Slot = "6")] get
      {
        return (List<(int, int)>) null;
      }
      [Token(Token = "0x600D06F"), Address(RVA = "0x4CD8244", Offset = "0x4CD8244", VA = "0x4CD8244")] protected set
      {
      }
    }

    [Token(Token = "0x600D070")]
    [Address(RVA = "0x4CD824C", Offset = "0x4CD824C", VA = "0x4CD824C")]
    public MoveArg(int[] arg)
    {
    }

    [Token(Token = "0x600D071")]
    [Address(RVA = "0x4CD82D8", Offset = "0x4CD82D8", VA = "0x4CD82D8", Slot = "4")]
    protected override void SetArg(int[] arg)
    {
    }

    [Token(Token = "0x2002246")]
    private enum ContextIndex
    {
      [Token(Token = "0x4009084")] Action,
      [Token(Token = "0x4009085")] Move,
    }
  }
}
