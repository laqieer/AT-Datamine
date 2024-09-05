// Decompiled with JetBrains decompiler
// Type: Scenes.Title.NetworkErrorHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using System.Collections;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028DF")]
  internal class NetworkErrorHandler
  {
    [Token(Token = "0x400AE56")]
    [FieldOffset(Offset = "0x10")]
    private string errorText;

    [Token(Token = "0x601014A")]
    [Address(RVA = "0x416E924", Offset = "0x416E924", VA = "0x416E924")]
    public NetworkErrorHandler()
    {
    }

    [Token(Token = "0x601014B")]
    [Address(RVA = "0x416E92C", Offset = "0x416E92C", VA = "0x416E92C")]
    public bool HasError(out ErrorMessageJson errorMessageJson) => new bool();

    [Token(Token = "0x601014C")]
    [Address(RVA = "0x416EA14", Offset = "0x416EA14", VA = "0x416EA14")]
    public IEnumerator HandleError(string error) => (IEnumerator) null;
  }
}
