// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.InstanceID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018E9")]
  public struct InstanceID
  {
    [Token(Token = "0x4006BE6")]
    [FieldOffset(Offset = "0x0")]
    public static readonly InstanceID Invalid;
    [Token(Token = "0x4006BE7")]
    [FieldOffset(Offset = "0x0")]
    public InstanceType type;
    [Token(Token = "0x4006BE8")]
    [FieldOffset(Offset = "0x4")]
    public int key;

    [Token(Token = "0x6008D8A")]
    [Address(RVA = "0x4AFA314", Offset = "0x4AFA314", VA = "0x4AFA314")]
    public InstanceID(InstanceType type, int key = 0)
    {
    }

    [Token(Token = "0x6008D8B")]
    [Address(RVA = "0x4AFA31C", Offset = "0x4AFA31C", VA = "0x4AFA31C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008D8C")]
    [Address(RVA = "0x4AFA3E4", Offset = "0x4AFA3E4", VA = "0x4AFA3E4")]
    public bool Equals(InstanceID? other) => new bool();

    [Token(Token = "0x6008D8D")]
    [Address(RVA = "0x4AFA588", Offset = "0x4AFA588", VA = "0x4AFA588", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008D8E")]
    [Address(RVA = "0x4AFA614", Offset = "0x4AFA614", VA = "0x4AFA614")]
    public static bool operator ==(InstanceID left, InstanceID right) => new bool();

    [Token(Token = "0x6008D8F")]
    [Address(RVA = "0x4AFA634", Offset = "0x4AFA634", VA = "0x4AFA634")]
    public static bool operator !=(InstanceID left, InstanceID right) => new bool();

    [Token(Token = "0x6008D90")]
    [Address(RVA = "0x4AFA6AC", Offset = "0x4AFA6AC", VA = "0x4AFA6AC")]
    static InstanceID()
    {
    }
  }
}
