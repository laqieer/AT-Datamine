// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.G_Singleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy.Utils
{
  [Token(Token = "0x2000391")]
  public class G_Singleton<T> : MonoBehaviour where T : MonoBehaviour
  {
    [Token(Token = "0x4001508")]
    [FieldOffset(Offset = "0x0")]
    private static T _instance;
    [Token(Token = "0x4001509")]
    [FieldOffset(Offset = "0x0")]
    private static object _lock;
    [Token(Token = "0x400150A")]
    [FieldOffset(Offset = "0x0")]
    private static bool _applicationIsQuitting;

    [Token(Token = "0x1700021A")]
    public static T Instance
    {
      [Token(Token = "0x6001478")] get => (T) null;
    }

    [Token(Token = "0x6001479")]
    private void Awake()
    {
    }

    [Token(Token = "0x600147A")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600147B")]
    public G_Singleton()
    {
    }

    [Token(Token = "0x600147C")]
    static G_Singleton()
    {
    }
  }
}
