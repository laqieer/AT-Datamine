// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F59")]
  public class DebugManager : SingletonMonoBehaviour<DebugManager>
  {
    [Token(Token = "0x170026A7")]
    protected override bool IsDontDestroy
    {
      [Token(Token = "0x600BA26"), Address(RVA = "0x2142E60", Offset = "0x2142E60", VA = "0x2142E60", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BA27")]
    [Address(RVA = "0x2142E68", Offset = "0x2142E68", VA = "0x2142E68", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600BA28")]
    [Address(RVA = "0x2142EB0", Offset = "0x2142EB0", VA = "0x2142EB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BA29")]
    [Address(RVA = "0x2142F30", Offset = "0x2142F30", VA = "0x2142F30")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BA2A")]
    [Address(RVA = "0x2142FB0", Offset = "0x2142FB0", VA = "0x2142FB0")]
    public void Update()
    {
    }

    [Token(Token = "0x600BA2B")]
    [Address(RVA = "0x2142FB4", Offset = "0x2142FB4", VA = "0x2142FB4")]
    private void LogMessageReceived(string condition, string stackTrace, LogType type)
    {
    }

    [Token(Token = "0x600BA2C")]
    [Address(RVA = "0x2142FB8", Offset = "0x2142FB8", VA = "0x2142FB8")]
    public void StartCoroutine(Func<IEnumerator> func)
    {
    }

    [Token(Token = "0x600BA2D")]
    [Address(RVA = "0x2142FEC", Offset = "0x2142FEC", VA = "0x2142FEC")]
    public DebugManager()
    {
    }
  }
}
