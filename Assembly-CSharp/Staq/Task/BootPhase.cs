// Decompiled with JetBrains decompiler
// Type: staq.Task.BootPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Task
{
  [Token(Token = "0x2003C5A")]
  internal enum BootPhase
  {
    [Token(Token = "0x4010BB6")] Idle,
    [Token(Token = "0x4010BB7")] LoadDebugSaveData,
    [Token(Token = "0x4010BB8")] LoadPlayerSaveData,
    [Token(Token = "0x4010BB9")] SavePlayerSecretKey,
  }
}
