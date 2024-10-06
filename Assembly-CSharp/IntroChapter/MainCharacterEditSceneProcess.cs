// Decompiled with JetBrains decompiler
// Type: IntroChapter.MainCharacterEditSceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using PlayerMake;
using System.Collections;
using UnityEngine.SceneManagement;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A92")]
  public class MainCharacterEditSceneProcess : SceneProcess
  {
    [Token(Token = "0x40030BD")]
    [FieldOffset(Offset = "0x20")]
    private MainCharacterEditSceneProcess.Flow flow;

    [Token(Token = "0x6003C25")]
    [Address(RVA = "0x331D598", Offset = "0x331D598", VA = "0x331D598")]
    public MainCharacterEditSceneProcess(
      ISceneProcessCoroutineMethod coMethod,
      IntroChapterMain main)
    {
    }

    [Token(Token = "0x6003C26")]
    [Address(RVA = "0x3320E08", Offset = "0x3320E08", VA = "0x3320E08", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6003C27")]
    [Address(RVA = "0x3320E0C", Offset = "0x3320E0C", VA = "0x3320E0C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003C28")]
    [Address(RVA = "0x3320E9C", Offset = "0x3320E9C", VA = "0x3320E9C", Slot = "8")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003C29")]
    [Address(RVA = "0x3320EA0", Offset = "0x3320EA0", VA = "0x3320EA0", Slot = "9")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003C2A")]
    [Address(RVA = "0x3320EA4", Offset = "0x3320EA4", VA = "0x3320EA4", Slot = "10")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003C2B")]
    [Address(RVA = "0x3320EA8", Offset = "0x3320EA8", VA = "0x3320EA8", Slot = "11")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003C2C")]
    [Address(RVA = "0x3320EAC", Offset = "0x3320EAC", VA = "0x3320EAC", Slot = "7")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003C2D")]
    [Address(RVA = "0x3320EB0", Offset = "0x3320EB0", VA = "0x3320EB0", Slot = "6")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6003C2E")]
    [Address(RVA = "0x3320EB4", Offset = "0x3320EB4", VA = "0x3320EB4")]
    public IEnumerator MainProcess() => (IEnumerator) null;

    [Token(Token = "0x6003C2F")]
    [Address(RVA = "0x3320F44", Offset = "0x3320F44", VA = "0x3320F44")]
    private void TrySignUp(MakingData making, PlayerMakeValidation.ResultReceptor receptor)
    {
    }

    [Token(Token = "0x6003C30")]
    [Address(RVA = "0x3320F60", Offset = "0x3320F60", VA = "0x3320F60")]
    private IEnumerator TrySignUpInternal(
      MakingData making,
      PlayerMakeValidation.ResultReceptor receptor)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003C31")]
    [Address(RVA = "0x3321010", Offset = "0x3321010", VA = "0x3321010")]
    private void Confirmed()
    {
    }

    [Token(Token = "0x6003C32")]
    [Address(RVA = "0x3321178", Offset = "0x3321178", VA = "0x3321178")]
    private void SignIn()
    {
    }

    [Token(Token = "0x6003C33")]
    [Address(RVA = "0x3321194", Offset = "0x3321194", VA = "0x3321194")]
    private IEnumerator SignInInternal() => (IEnumerator) null;

    [Token(Token = "0x6003C34")]
    [Address(RVA = "0x3321224", Offset = "0x3321224", VA = "0x3321224")]
    private void PlayerMakeEnd()
    {
    }

    [Token(Token = "0x2000A93")]
    public class Flow
    {
      [Token(Token = "0x17000895")]
      public bool SignupEnd
      {
        [Token(Token = "0x6003C37"), Address(RVA = "0x3321378", Offset = "0x3321378", VA = "0x3321378")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003C38"), Address(RVA = "0x3321380", Offset = "0x3321380", VA = "0x3321380")] set
        {
        }
      }

      [Token(Token = "0x17000896")]
      public bool SignInEnd
      {
        [Token(Token = "0x6003C39"), Address(RVA = "0x332138C", Offset = "0x332138C", VA = "0x332138C")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003C3A"), Address(RVA = "0x3321394", Offset = "0x3321394", VA = "0x3321394")] set
        {
        }
      }

      [Token(Token = "0x6003C3B")]
      [Address(RVA = "0x3320E00", Offset = "0x3320E00", VA = "0x3320E00")]
      public Flow()
      {
      }
    }

    [Token(Token = "0x2000A94")]
    public interface IProcess
    {
      [Token(Token = "0x6003C3C")]
      IEnumerator Processing();
    }

    [Token(Token = "0x2000A95")]
    private class SceneLoader : MainCharacterEditSceneProcess.IProcess
    {
      [Token(Token = "0x17000897")]
      public Scene LoadedScene
      {
        [Token(Token = "0x6003C3D"), Address(RVA = "0x33213A0", Offset = "0x33213A0", VA = "0x33213A0")] get
        {
          return new Scene();
        }
        [Token(Token = "0x6003C3E"), Address(RVA = "0x33213A8", Offset = "0x33213A8", VA = "0x33213A8")] set
        {
        }
      }

      [Token(Token = "0x17000898")]
      public PlayerMakeManager Manager
      {
        [Token(Token = "0x6003C3F"), Address(RVA = "0x33213B0", Offset = "0x33213B0", VA = "0x33213B0")] get
        {
          return (PlayerMakeManager) null;
        }
        [Token(Token = "0x6003C40"), Address(RVA = "0x33213B8", Offset = "0x33213B8", VA = "0x33213B8")] set
        {
        }
      }

      [Token(Token = "0x6003C41")]
      [Address(RVA = "0x33213C0", Offset = "0x33213C0", VA = "0x33213C0", Slot = "4")]
      public IEnumerator Processing() => (IEnumerator) null;

      [Token(Token = "0x6003C42")]
      [Address(RVA = "0x3321450", Offset = "0x3321450", VA = "0x3321450")]
      private IEnumerator AdditiveSceneLoad(string ablabel, string scene) => (IEnumerator) null;

      [Token(Token = "0x6003C43")]
      [Address(RVA = "0x33214EC", Offset = "0x33214EC", VA = "0x33214EC")]
      public void UnloadScene()
      {
      }

      [Token(Token = "0x6003C44")]
      [Address(RVA = "0x3321548", Offset = "0x3321548", VA = "0x3321548")]
      public PlayerMakeManager SearchPlayerMakeManager() => (PlayerMakeManager) null;

      [Token(Token = "0x6003C45")]
      [Address(RVA = "0x3321648", Offset = "0x3321648", VA = "0x3321648")]
      public SceneLoader()
      {
      }
    }
  }
}
