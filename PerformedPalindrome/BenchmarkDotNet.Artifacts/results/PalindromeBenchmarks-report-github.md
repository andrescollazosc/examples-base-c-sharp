```

BenchmarkDotNet v0.15.8, Linux Ubuntu 26.04 LTS (Resolute Raccoon)
12th Gen Intel Core i7-12700H 0.40GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.301
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3


```
| Method             | Mean      | Error     | StdDev    |
|------------------- |----------:|----------:|----------:|
| IsPalindrome       |  2.159 ns | 0.0421 ns | 0.0394 ns |
| IsPalindromeCommon | 85.822 ns | 0.8411 ns | 0.7867 ns |
