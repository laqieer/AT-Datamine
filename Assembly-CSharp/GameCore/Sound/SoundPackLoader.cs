// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.SoundPackLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C56")]
  [ExecuteInEditMode]
  public class SoundPackLoader : AkTriggerHandler
  {
    [Token(Token = "0x40037BC")]
    [FieldOffset(Offset = "0x30")]
    public string Name;
    [Token(Token = "0x40037BD")]
    [FieldOffset(Offset = "0x38")]
    public List<int> unloadTriggerList;

    [Token(Token = "0x60046E4")]
    [Address(RVA = "0x351C8D4", Offset = "0x351C8D4", VA = "0x351C8D4", Slot = "5")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60046E5")]
    [Address(RVA = "0x351CA34", Offset = "0x351CA34", VA = "0x351CA34", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60046E6")]
    [Address(RVA = "0x351CAB0", Offset = "0x351CAB0", VA = "0x351CAB0", Slot = "4")]
    public override void HandleEvent(GameObject in_gameObject)
    {
    }

    [Token(Token = "0x60046E7")]
    [Address(RVA = "0x351C9B0", Offset = "0x351C9B0", VA = "0x351C9B0")]
    public void UnloadBank(GameObject in_gameObject)
    {
    }

    [Token(Token = "0x60046E8")]
    [Address(RVA = "0x351CB7C", Offset = "0x351CB7C", VA = "0x351CB7C", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60046E9")]
    [Address(RVA = "0x351CC58", Offset = "0x351CC58", VA = "0x351CC58")]
    public SoundPackLoader()
    {
    }
  }
}
