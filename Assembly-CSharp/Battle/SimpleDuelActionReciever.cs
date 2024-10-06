// Decompiled with JetBrains decompiler
// Type: Battle.SimpleDuelActionReciever
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Staging;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002283")]
  public class SimpleDuelActionReciever : ISubDirector<IDirector>
  {
    [Token(Token = "0x4009188")]
    [FieldOffset(Offset = "0x18")]
    protected IDirector mainDirector;

    [Token(Token = "0x17002DAC")]
    public bool Initialized
    {
      [Token(Token = "0x600D261"), Address(RVA = "0x1960FF0", Offset = "0x1960FF0", VA = "0x1960FF0", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D262"), Address(RVA = "0x1960FF8", Offset = "0x1960FF8", VA = "0x1960FF8")] private set
      {
      }
    }

    [Token(Token = "0x17002DAD")]
    public bool NoDyingAction
    {
      [Token(Token = "0x600D263"), Address(RVA = "0x1961004", Offset = "0x1961004", VA = "0x1961004")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D264"), Address(RVA = "0x196100C", Offset = "0x196100C", VA = "0x196100C")] protected set
      {
      }
    }

    [Token(Token = "0x600D265")]
    [Address(RVA = "0x1961018", Offset = "0x1961018", VA = "0x1961018", Slot = "5")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D266")]
    [Address(RVA = "0x1961034", Offset = "0x1961034", VA = "0x1961034", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D267")]
    [Address(RVA = "0x1961038", Offset = "0x1961038", VA = "0x1961038", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600D268")]
    [Address(RVA = "0x196103C", Offset = "0x196103C", VA = "0x196103C", Slot = "8")]
    public virtual StagingDirector.ISequence OnDamage(
      DuelData duelData,
      ActionTargetResultData result,
      UnitParameterData actionOwner)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600D269")]
    [Address(RVA = "0x1961044", Offset = "0x1961044", VA = "0x1961044")]
    public SimpleDuelActionReciever()
    {
    }
  }
}
