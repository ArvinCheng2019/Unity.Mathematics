//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.PerformanceTesting;
using Unity.Mathematics.Geometry;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    partial class TestConversions
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class quaternion_to_float3x3
        {
            public struct Arguments : IDisposable
            {
                public quaternion* q;
                public float3x3* f3x3;

                public void Init()
                {
                    q = (quaternion*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<quaternion>() * 10000, UnsafeUtility.AlignOf<quaternion>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        q[i] = quaternion.identity;
                    }

                    f3x3 = (float3x3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3x3>() * 10000, UnsafeUtility.AlignOf<float3x3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f3x3[i] = float3x3.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(q, Allocator.Persistent);
                    UnsafeUtility.Free(f3x3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.f3x3[i] = new float3x3(args.q[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void quaternion_to_float3x3_mono()
        {
            quaternion_to_float3x3.TestFunction testFunction = quaternion_to_float3x3.MonoTestFunction;
            var args = new quaternion_to_float3x3.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void quaternion_to_float3x3_burst()
        {
            FunctionPointer<quaternion_to_float3x3.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<quaternion_to_float3x3.TestFunction>(quaternion_to_float3x3.BurstTestFunction);
            var args = new quaternion_to_float3x3.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float3x3_to_quaternion
        {
            public struct Arguments : IDisposable
            {
                public quaternion* q;
                public float3x3* f3x3;

                public void Init()
                {
                    q = (quaternion*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<quaternion>() * 10000, UnsafeUtility.AlignOf<quaternion>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        q[i] = quaternion.identity;
                    }

                    f3x3 = (float3x3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3x3>() * 10000, UnsafeUtility.AlignOf<float3x3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f3x3[i] = float3x3.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(q, Allocator.Persistent);
                    UnsafeUtility.Free(f3x3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.q[i] = new quaternion(args.f3x3[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float3x3_to_quaternion_mono()
        {
            float3x3_to_quaternion.TestFunction testFunction = float3x3_to_quaternion.MonoTestFunction;
            var args = new float3x3_to_quaternion.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float3x3_to_quaternion_burst()
        {
            FunctionPointer<float3x3_to_quaternion.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float3x3_to_quaternion.TestFunction>(float3x3_to_quaternion.BurstTestFunction);
            var args = new float3x3_to_quaternion.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float4_to_half4
        {
            public struct Arguments : IDisposable
            {
                public float4* f4;
                public half4* h4;

                public void Init()
                {
                    f4 = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * 10000, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4[i] = new float4(1.0f, 2.0f, 3.0f, 4.0f);
                    }

                    h4 = (half4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<half4>() * 10000, UnsafeUtility.AlignOf<half4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        h4[i] = new half4(new float4(-1.0f, -2.0f, -3.0f, -4.0f));
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(f4, Allocator.Persistent);
                    UnsafeUtility.Free(h4, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.h4[i] = new half4(args.f4[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4_to_half4_mono()
        {
            float4_to_half4.TestFunction testFunction = float4_to_half4.MonoTestFunction;
            var args = new float4_to_half4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float4_to_half4_burst()
        {
            FunctionPointer<float4_to_half4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4_to_half4.TestFunction>(float4_to_half4.BurstTestFunction);
            var args = new float4_to_half4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class half4_to_float4
        {
            public struct Arguments : IDisposable
            {
                public float4* f4;
                public half4* h4;

                public void Init()
                {
                    f4 = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * 10000, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4[i] = new float4(1.0f, 2.0f, 3.0f, 4.0f);
                    }

                    h4 = (half4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<half4>() * 10000, UnsafeUtility.AlignOf<half4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        h4[i] = new half4(new float4(-1.0f, -2.0f, -3.0f, -4.0f));
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(f4, Allocator.Persistent);
                    UnsafeUtility.Free(h4, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.f4[i] = new float4(args.h4[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void half4_to_float4_mono()
        {
            half4_to_float4.TestFunction testFunction = half4_to_float4.MonoTestFunction;
            var args = new half4_to_float4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void half4_to_float4_burst()
        {
            FunctionPointer<half4_to_float4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<half4_to_float4.TestFunction>(half4_to_float4.BurstTestFunction);
            var args = new half4_to_float4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class quaternion_to_RigidTransform
        {
            public struct Arguments : IDisposable
            {
                public quaternion* q;
                public RigidTransform* rt;
                public float3* pos;

                public void Init()
                {
                    q = (quaternion*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<quaternion>() * 10000, UnsafeUtility.AlignOf<quaternion>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        q[i] = quaternion.identity;
                    }

                    rt = (RigidTransform*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<RigidTransform>() * 10000, UnsafeUtility.AlignOf<RigidTransform>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        rt[i] = RigidTransform.identity;
                    }

                    pos = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        pos[i] = new float3();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(q, Allocator.Persistent);
                    UnsafeUtility.Free(rt, Allocator.Persistent);
                    UnsafeUtility.Free(pos, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.rt[i] = new RigidTransform(args.q[i], args.pos[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void quaternion_to_RigidTransform_mono()
        {
            quaternion_to_RigidTransform.TestFunction testFunction = quaternion_to_RigidTransform.MonoTestFunction;
            var args = new quaternion_to_RigidTransform.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void quaternion_to_RigidTransform_burst()
        {
            FunctionPointer<quaternion_to_RigidTransform.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<quaternion_to_RigidTransform.TestFunction>(quaternion_to_RigidTransform.BurstTestFunction);
            var args = new quaternion_to_RigidTransform.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class quaternion_to_float4x4
        {
            public struct Arguments : IDisposable
            {
                public quaternion* q;
                public float4x4* f4x4;

                public void Init()
                {
                    q = (quaternion*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<quaternion>() * 10000, UnsafeUtility.AlignOf<quaternion>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        q[i] = quaternion.identity;
                    }

                    f4x4 = (float4x4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4x4>() * 10000, UnsafeUtility.AlignOf<float4x4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4x4[i] = float4x4.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(q, Allocator.Persistent);
                    UnsafeUtility.Free(f4x4, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.q[i] = new quaternion(args.f4x4[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void quaternion_to_float4x4_mono()
        {
            quaternion_to_float4x4.TestFunction testFunction = quaternion_to_float4x4.MonoTestFunction;
            var args = new quaternion_to_float4x4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void quaternion_to_float4x4_burst()
        {
            FunctionPointer<quaternion_to_float4x4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<quaternion_to_float4x4.TestFunction>(quaternion_to_float4x4.BurstTestFunction);
            var args = new quaternion_to_float4x4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float4x4_to_quaternion
        {
            public struct Arguments : IDisposable
            {
                public quaternion* q;
                public float4x4* f4x4;
                public float3* f3;

                public void Init()
                {
                    q = (quaternion*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<quaternion>() * 10000, UnsafeUtility.AlignOf<quaternion>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        q[i] = quaternion.identity;
                    }

                    f4x4 = (float4x4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4x4>() * 10000, UnsafeUtility.AlignOf<float4x4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4x4[i] = float4x4.identity;
                    }

                    f3 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f3[i] = new float3();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(q, Allocator.Persistent);
                    UnsafeUtility.Free(f4x4, Allocator.Persistent);
                    UnsafeUtility.Free(f3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.f4x4[i] = new float4x4(args.q[i], args.f3[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4x4_to_quaternion_mono()
        {
            float4x4_to_quaternion.TestFunction testFunction = float4x4_to_quaternion.MonoTestFunction;
            var args = new float4x4_to_quaternion.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float4x4_to_quaternion_burst()
        {
            FunctionPointer<float4x4_to_quaternion.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4x4_to_quaternion.TestFunction>(float4x4_to_quaternion.BurstTestFunction);
            var args = new float4x4_to_quaternion.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float4_to_uint4
        {
            public struct Arguments : IDisposable
            {
                public float4* f4;
                public uint4* u4;

                public void Init()
                {
                    f4 = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * 10000, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4[i] = new float4(1.0f, 2.0f, 3.0f, 4.0f);
                    }

                    u4 = (uint4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<uint4>() * 10000, UnsafeUtility.AlignOf<uint4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        u4[i] = new uint4(100, 101, 102, 103);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(f4, Allocator.Persistent);
                    UnsafeUtility.Free(u4, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.u4[i] = new uint4(args.f4[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4_to_uint4_mono()
        {
            float4_to_uint4.TestFunction testFunction = float4_to_uint4.MonoTestFunction;
            var args = new float4_to_uint4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float4_to_uint4_burst()
        {
            FunctionPointer<float4_to_uint4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4_to_uint4.TestFunction>(float4_to_uint4.BurstTestFunction);
            var args = new float4_to_uint4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class uint4_to_float4
        {
            public struct Arguments : IDisposable
            {
                public float4* f4;
                public uint4* u4;

                public void Init()
                {
                    f4 = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * 10000, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4[i] = new float4(1.0f, 2.0f, 3.0f, 4.0f);
                    }

                    u4 = (uint4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<uint4>() * 10000, UnsafeUtility.AlignOf<uint4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        u4[i] = new uint4(100, 101, 102, 103);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(f4, Allocator.Persistent);
                    UnsafeUtility.Free(u4, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.f4[i] = new float4(args.u4[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void uint4_to_float4_mono()
        {
            uint4_to_float4.TestFunction testFunction = uint4_to_float4.MonoTestFunction;
            var args = new uint4_to_float4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void uint4_to_float4_burst()
        {
            FunctionPointer<uint4_to_float4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<uint4_to_float4.TestFunction>(uint4_to_float4.BurstTestFunction);
            var args = new uint4_to_float4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
    }
}
