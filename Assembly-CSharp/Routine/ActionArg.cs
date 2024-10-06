// Decompiled with JetBrains decompiler
// Type: Routine.ActionArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002209")]
  public abstract class ActionArg
  {
    [Token(Token = "0x600CF5D")]
    [Address(RVA = "0x4B6D88C", Offset = "0x4B6D88C", VA = "0x4B6D88C")]
    public ActionArg(int[] arg)
    {
    }

    [Token(Token = "0x17002D29")]
    public ActionArg.MoveSettingType MoveSetting
    {
      [Token(Token = "0x600CF5E"), Address(RVA = "0x4B6D8C0", Offset = "0x4B6D8C0", VA = "0x4B6D8C0")] get
      {
        return new ActionArg.MoveSettingType();
      }
      [Token(Token = "0x600CF5F"), Address(RVA = "0x4B6D8C8", Offset = "0x4B6D8C8", VA = "0x4B6D8C8")] protected set
      {
      }
    }

    [Token(Token = "0x600CF60")]
    protected abstract void SetArg(int[] arg);

    [Token(Token = "0x600CF61")]
    [Address(RVA = "0x4B6D8D0", Offset = "0x4B6D8D0", VA = "0x4B6D8D0")]
    protected bool IsValidArg(int[] arg, int index) => new bool();

    [Token(Token = "0x600CF62")]
    protected bool IsValidArg<TEnum>(int[] arg, int index) where TEnum : struct, Enum => new bool();

    [Token(Token = "0x200220A")]
    public enum MoveSettingType
    {
      [Token(Token = "0x4008FBA")] Move,
      [Token(Token = "0x4008FBB")] Stay,
      [Token(Token = "0x4008FBC")] MoveWithoutWarpOut,
    }

    [Token(Token = "0x200220B")]
    public enum TargetSettingType
    {
      [Token(Token = "0x4008FBE")] None,
      [Token(Token = "0x4008FBF")] Hostile,
      [Token(Token = "0x4008FC0")] Ally,
      [Token(Token = "0x4008FC1")] UserOwned,
      [Token(Token = "0x4008FC2")] GuestOwned,
      [Token(Token = "0x4008FC3")] EnemyOwned,
      [Token(Token = "0x4008FC4")] ThirdOwned,
      [Token(Token = "0x4008FC5")] Self,
      [Token(Token = "0x4008FC6")] GoalTarget,
    }

    [Token(Token = "0x200220C")]
    public enum ActionSettingType
    {
      [Token(Token = "0x4008FC8")] Action,
      [Token(Token = "0x4008FC9")] Stay,
    }

    [Token(Token = "0x200220D")]
    public enum DuplicateSettingType
    {
      [Token(Token = "0x4008FCB")] None,
      [Token(Token = "0x4008FCC")] Duplicated,
      [Token(Token = "0x4008FCD")] NonDuplicated,
    }
  }
}
