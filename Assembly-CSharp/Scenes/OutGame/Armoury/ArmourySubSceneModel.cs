// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmourySubSceneModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x20037FD")]
  public class ArmourySubSceneModel
  {
    [Token(Token = "0x400F49C")]
    [FieldOffset(Offset = "0x10")]
    private ArmouryScreenType _screenType;
    [Token(Token = "0x400F49D")]
    [FieldOffset(Offset = "0x18")]
    private ArmouryScreenBase _screen;
    [Token(Token = "0x400F49E")]
    [FieldOffset(Offset = "0x20")]
    private ArmouryChangeScreenParam _param;

    [Token(Token = "0x170048D5")]
    public ArmouryScreenType ScreenType
    {
      [Token(Token = "0x601607A"), Address(RVA = "0x20ECFC8", Offset = "0x20ECFC8", VA = "0x20ECFC8")] get
      {
        return new ArmouryScreenType();
      }
      [Token(Token = "0x601607B"), Address(RVA = "0x20ECFD0", Offset = "0x20ECFD0", VA = "0x20ECFD0")] private set
      {
      }
    }

    [Token(Token = "0x170048D6")]
    public ArmouryScreenBase Screen
    {
      [Token(Token = "0x601607C"), Address(RVA = "0x20ECFD8", Offset = "0x20ECFD8", VA = "0x20ECFD8")] get
      {
        return (ArmouryScreenBase) null;
      }
      [Token(Token = "0x601607D"), Address(RVA = "0x20ECFE0", Offset = "0x20ECFE0", VA = "0x20ECFE0")] private set
      {
      }
    }

    [Token(Token = "0x170048D7")]
    public ArmouryChangeScreenParam Param
    {
      [Token(Token = "0x601607E"), Address(RVA = "0x20ECFE8", Offset = "0x20ECFE8", VA = "0x20ECFE8")] get
      {
        return (ArmouryChangeScreenParam) null;
      }
      [Token(Token = "0x601607F"), Address(RVA = "0x20ECFF0", Offset = "0x20ECFF0", VA = "0x20ECFF0")] set
      {
      }
    }

    [Token(Token = "0x6016080")]
    [Address(RVA = "0x20EC8B0", Offset = "0x20EC8B0", VA = "0x20EC8B0")]
    public void SetScreen(ArmouryScreenBase screen)
    {
    }

    [Token(Token = "0x6016081")]
    [Address(RVA = "0x20EBFF4", Offset = "0x20EBFF4", VA = "0x20EBFF4")]
    public ArmourySubSceneModel()
    {
    }
  }
}
