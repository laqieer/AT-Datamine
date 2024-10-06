// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GetSetAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F45")]
  public sealed class GetSetAttribute : PropertyAttribute
  {
    [Token(Token = "0x4011510")]
    [FieldOffset(Offset = "0x18")]
    public readonly string name;
    [Token(Token = "0x4011511")]
    [FieldOffset(Offset = "0x20")]
    public bool dirty;

    [Token(Token = "0x60198B7")]
    [Address(RVA = "0x3748EE0", Offset = "0x3748EE0", VA = "0x3748EE0")]
    public GetSetAttribute(string name)
    {
    }
  }
}
