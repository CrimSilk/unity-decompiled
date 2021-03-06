﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Caching
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
  /// <summary>
  ///   <para>The Caching class lets you manage cached AssetBundles, downloaded using WWW.LoadFromCacheOrDownload.</para>
  /// </summary>
  public sealed class Caching
  {
    [Obsolete("this API is not for public use.")]
    public static extern CacheIndex[] index { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The number of currently unused bytes in the cache.</para>
    /// </summary>
    public static extern long spaceFree { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The total number of bytes that can potentially be allocated for caching.</para>
    /// </summary>
    public static extern long maximumAvailableDiskSpace { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Used disk space in bytes.</para>
    /// </summary>
    public static extern long spaceOccupied { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [Obsolete("Please use Caching.spaceFree instead")]
    public static extern int spaceAvailable { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    [Obsolete("Please use Caching.spaceOccupied instead")]
    public static extern int spaceUsed { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The number of seconds that an AssetBundle may remain unused in the cache before it is automatically deleted.</para>
    /// </summary>
    public static extern int expirationDelay { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Is Caching enabled?</para>
    /// </summary>
    public static extern bool enabled { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Controls compression of cache data. Enabled by default.</para>
    /// </summary>
    public static extern bool compressionEnabled { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Is caching ready?</para>
    /// </summary>
    public static extern bool ready { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>(This is a WebPlayer-only function).</para>
    /// </summary>
    /// <param name="string">Signature The authentification signature provided by Unity.</param>
    /// <param name="int">Size The number of bytes allocated to this cache.</param>
    /// <param name="name"></param>
    /// <param name="domain"></param>
    /// <param name="size"></param>
    /// <param name="signature"></param>
    /// <param name="expiration"></param>
    public static bool Authorize(string name, string domain, long size, string signature)
    {
      return Caching.Authorize(name, domain, size, -1, signature);
    }

    /// <summary>
    ///   <para>(This is a WebPlayer-only function).</para>
    /// </summary>
    /// <param name="string">Signature The authentification signature provided by Unity.</param>
    /// <param name="int">Size The number of bytes allocated to this cache.</param>
    /// <param name="name"></param>
    /// <param name="domain"></param>
    /// <param name="size"></param>
    /// <param name="signature"></param>
    /// <param name="expiration"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool Authorize(string name, string domain, long size, int expiration, string signature);

    /// <summary>
    ///   <para>TODO.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="domain"></param>
    /// <param name="size"></param>
    /// <param name="signature"></param>
    /// <param name="expiration"></param>
    [Obsolete("Size is now specified as a long")]
    public static bool Authorize(string name, string domain, int size, int expiration, string signature)
    {
      return Caching.Authorize(name, domain, (long) size, expiration, signature);
    }

    /// <summary>
    ///   <para>TODO.</para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="domain"></param>
    /// <param name="size"></param>
    /// <param name="signature"></param>
    /// <param name="expiration"></param>
    [Obsolete("Size is now specified as a long")]
    public static bool Authorize(string name, string domain, int size, string signature)
    {
      return Caching.Authorize(name, domain, (long) size, signature);
    }

    /// <summary>
    ///   <para>Delete all AssetBundle and Procedural Material content that has been cached by the current application.</para>
    /// </summary>
    /// <returns>
    ///   <para>True when cache cleaning succeeded, false if cache was in use.</para>
    /// </returns>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool CleanCache();

    [Obsolete("this API is not for public use.")]
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool CleanNamedCache(string name);

    [WrapperlessIcall]
    [Obsolete("This function is obsolete and has no effect.")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern bool DeleteFromCache(string url);

    [WrapperlessIcall]
    [Obsolete("This function is obsolete and will always return -1. Use IsVersionCached instead.")]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern int GetVersionFromCache(string url);

    /// <summary>
    ///   <para>Checks if an AssetBundle is cached.</para>
    /// </summary>
    /// <param name="string">Url The filename of the AssetBundle. Domain and path information are stripped from this string automatically.</param>
    /// <param name="int">Version The version number of the AssetBundle to check for. Negative values are not allowed.</param>
    /// <param name="url"></param>
    /// <param name="version"></param>
    /// <returns>
    ///   <para>True if an AssetBundle matching the url and version parameters has previously been loaded using WWW.LoadFromCacheOrDownload() and is currently stored in the cache. Returns false if the AssetBundle is not in cache, either because it has been flushed from the cache or was never loaded using the Caching API.</para>
    /// </returns>
    public static bool IsVersionCached(string url, int version)
    {
      Hash128 hash = new Hash128(0U, 0U, 0U, (uint) version);
      return Caching.IsVersionCached(url, hash);
    }

    public static bool IsVersionCached(string url, Hash128 hash)
    {
      return Caching.INTERNAL_CALL_IsVersionCached(url, ref hash);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_IsVersionCached(string url, ref Hash128 hash);

    /// <summary>
    ///   <para>Bumps the timestamp of a cached file to be the current time.</para>
    /// </summary>
    /// <param name="url"></param>
    /// <param name="version"></param>
    public static bool MarkAsUsed(string url, int version)
    {
      Hash128 hash = new Hash128(0U, 0U, 0U, (uint) version);
      return Caching.MarkAsUsed(url, hash);
    }

    public static bool MarkAsUsed(string url, Hash128 hash)
    {
      return Caching.INTERNAL_CALL_MarkAsUsed(url, ref hash);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern bool INTERNAL_CALL_MarkAsUsed(string url, ref Hash128 hash);

    public static void SetNoBackupFlag(string url, int version)
    {
    }

    public static void SetNoBackupFlag(string url, Hash128 hash)
    {
      Caching.INTERNAL_CALL_SetNoBackupFlag(url, ref hash);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetNoBackupFlag(string url, ref Hash128 hash);

    public static void ResetNoBackupFlag(string url, int version)
    {
    }

    public static void ResetNoBackupFlag(string url, Hash128 hash)
    {
      Caching.INTERNAL_CALL_ResetNoBackupFlag(url, ref hash);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_ResetNoBackupFlag(string url, ref Hash128 hash);
  }
}
