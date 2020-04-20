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
    partial class TestPlane
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class Normalize_Plane
        {
            public struct Arguments : IDisposable
            {
                public Plane* p;

                public void Init()
                {
                    p = (Plane*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Plane>() * 10000, UnsafeUtility.AlignOf<Plane>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        p[i] = new Plane { NormalAndDistance = new float4(1.0f) };
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(p, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.p[i] = Plane.Normalize(args.p[i]);
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
        public void Normalize_Plane_mono()
        {
            Normalize_Plane.TestFunction testFunction = Normalize_Plane.MonoTestFunction;
            var args = new Normalize_Plane.Arguments();
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
        public void Normalize_Plane_burst()
        {
            FunctionPointer<Normalize_Plane.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<Normalize_Plane.TestFunction>(Normalize_Plane.BurstTestFunction);
            var args = new Normalize_Plane.Arguments();
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
