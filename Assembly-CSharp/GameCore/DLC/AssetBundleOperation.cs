// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A0")]
  public abstract class AssetBundleOperation : IEnumerator
  {
    [Token(Token = "0x170011CC")]
    public object Current
    {
      [Token(Token = "0x6007434"), Address(RVA = "0x43EC568", Offset = "0x43EC568", VA = "0x43EC568", Slot = "5")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x6007435")]
    [Address(RVA = "0x43EC570", Offset = "0x43EC570", VA = "0x43EC570", Slot = "4")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x6007436")]
    [Address(RVA = "0x43EC590", Offset = "0x43EC590", VA = "0x43EC590", Slot = "6")]
    public void Reset()
    {
    }

    [Token(Token = "0x6007437")]
    public abstract bool Execute();

    [Token(Token = "0x6007438")]
    public abstract bool IsDone();

    [Token(Token = "0x6007439")]
    [Address(RVA = "0x43EC594", Offset = "0x43EC594", VA = "0x43EC594")]
    protected AssetBundleOperation()
    {
    }
  }
}
