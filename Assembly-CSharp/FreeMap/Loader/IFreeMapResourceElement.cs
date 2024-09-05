// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.IFreeMapResourceElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018AD")]
  public interface IFreeMapResourceElement
  {
    [Token(Token = "0x17001677")]
    FreeMapBuildOrder BuildOrder { [Token(Token = "0x6008C18")] get; }

    [Token(Token = "0x6008C19")]
    void BeforeBuild(IFreeMapResourceLoader loader);

    [Token(Token = "0x6008C1A")]
    void Build();
  }
}
