// Decompiled with JetBrains decompiler
// Type: Scenes.Title.ChangeLogoSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028CC")]
  public class ChangeLogoSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x17003852")]
    public bool IsReturnTitleAfter
    {
      [Token(Token = "0x60100C9"), Address(RVA = "0x4169330", Offset = "0x4169330", VA = "0x4169330")] get
      {
        return new bool();
      }
      [Token(Token = "0x60100CA"), Address(RVA = "0x4169338", Offset = "0x4169338", VA = "0x4169338")] private set
      {
      }
    }

    [Token(Token = "0x17003853")]
    public bool IsShowLogStage
    {
      [Token(Token = "0x60100CB"), Address(RVA = "0x4169344", Offset = "0x4169344", VA = "0x4169344")] get
      {
        return new bool();
      }
      [Token(Token = "0x60100CC"), Address(RVA = "0x416934C", Offset = "0x416934C", VA = "0x416934C")] private set
      {
      }
    }

    [Token(Token = "0x60100CD")]
    [Address(RVA = "0x4169358", Offset = "0x4169358", VA = "0x4169358")]
    public static ChangeLogoSceneParameter CreateEndigParam() => (ChangeLogoSceneParameter) null;

    [Token(Token = "0x60100CE")]
    [Address(RVA = "0x41693CC", Offset = "0x41693CC", VA = "0x41693CC")]
    public static ChangeLogoSceneParameter CreateNoneParam() => (ChangeLogoSceneParameter) null;

    [Token(Token = "0x60100CF")]
    [Address(RVA = "0x41693C0", Offset = "0x41693C0", VA = "0x41693C0")]
    public ChangeLogoSceneParameter()
    {
    }
  }
}
