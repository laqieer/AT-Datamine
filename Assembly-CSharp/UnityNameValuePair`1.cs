// Decompiled with JetBrains decompiler
// Type: UnityNameValuePair`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000099")]
public class UnityNameValuePair<V> : UnityKeyValuePair<string, V>
{
  [Token(Token = "0x4000286")]
  [FieldOffset(Offset = "0x0")]
  public string name;

  [Token(Token = "0x17000033")]
  public override string Key
  {
    [Token(Token = "0x6000516")] get => (string) null;
    [Token(Token = "0x6000517")] set
    {
    }
  }

  [Token(Token = "0x6000518")]
  public UnityNameValuePair()
  {
  }

  [Token(Token = "0x6000519")]
  public UnityNameValuePair(string key, V value)
  {
  }
}
