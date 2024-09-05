// Decompiled with JetBrains decompiler
// Type: Scenes.Boot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.DLC;
using Il2CppDummyDll;
using staq;
using staq.Task;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x200287B")]
  public class Boot : SingletonMonoBehaviour<Boot>
  {
    [Token(Token = "0x400AC9F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonTouchEffect commonTouchEffect;
    [Token(Token = "0x400ACA0")]
    [FieldOffset(Offset = "0x28")]
    private Settings settings;
    [Token(Token = "0x400ACA1")]
    [FieldOffset(Offset = "0x30")]
    private TaskBase task;

    [Token(Token = "0x600FF11")]
    [Address(RVA = "0x40F4DB0", Offset = "0x40F4DB0", VA = "0x40F4DB0")]
    public static void AutoResize(int screenWidth, int screenHeight)
    {
    }

    [Token(Token = "0x600FF12")]
    [Address(RVA = "0x40F4F30", Offset = "0x40F4F30", VA = "0x40F4F30")]
    public static void AllClear()
    {
    }

    [Token(Token = "0x600FF13")]
    [Address(RVA = "0x40F4F88", Offset = "0x40F4F88", VA = "0x40F4F88", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600FF14")]
    [Address(RVA = "0x40F5150", Offset = "0x40F5150", VA = "0x40F5150")]
    private void GameStart()
    {
    }

    [Token(Token = "0x600FF15")]
    [Address(RVA = "0x40F51D0", Offset = "0x40F51D0", VA = "0x40F51D0")]
    private void BootProcDownloadTitleSuccess(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x600FF16")]
    [Address(RVA = "0x40F51D4", Offset = "0x40F51D4", VA = "0x40F51D4")]
    private IEnumerator BootProcInternal() => (IEnumerator) null;

    [Token(Token = "0x600FF17")]
    [Address(RVA = "0x40F5264", Offset = "0x40F5264", VA = "0x40F5264")]
    public void StartBoot()
    {
    }

    [Token(Token = "0x600FF18")]
    [Address(RVA = "0x40F5284", Offset = "0x40F5284", VA = "0x40F5284")]
    private void Start()
    {
    }

    [Token(Token = "0x600FF19")]
    [Address(RVA = "0x40F5418", Offset = "0x40F5418", VA = "0x40F5418")]
    public Boot()
    {
    }

    [Token(Token = "0x200287C")]
    private class Task : BootTask
    {
      [Token(Token = "0x400ACA2")]
      [FieldOffset(Offset = "0x18")]
      private Boot scene;

      [Token(Token = "0x600FF1A")]
      [Address(RVA = "0x40F5128", Offset = "0x40F5128", VA = "0x40F5128")]
      public Task(Boot bootScene)
      {
      }

      [Token(Token = "0x600FF1B")]
      [Address(RVA = "0x40F5460", Offset = "0x40F5460", VA = "0x40F5460", Slot = "7")]
      protected override void finish()
      {
      }
    }
  }
}
