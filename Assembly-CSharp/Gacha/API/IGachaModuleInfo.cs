// Decompiled with JetBrains decompiler
// Type: Gacha.API.IGachaModuleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015AC")]
  public interface IGachaModuleInfo
  {
    [Token(Token = "0x170012D5")]
    string GachaName { [Token(Token = "0x6007AB8")] get; }

    [Token(Token = "0x170012D6")]
    string ApiSchemaVersion { [Token(Token = "0x6007AB9")] get; }

    [Token(Token = "0x170012D7")]
    GachaTypeEnum GachaType { [Token(Token = "0x6007ABA")] get; }
  }
}
