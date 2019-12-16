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
using Unity.PerformanceTesting;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    public partial class TestInverse
    {
        [BurstCompile]
        public class float4x4_inverse
        {
            public struct Arguments
            {
                public float4x4 m1;
                public float4x4 m2;

                public void Init()
                {
                    m1 = float4x4.identity;
                    m2 = float4x4.identity;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1 = math.inverse(args.m2);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4x4_inverse_mono()
        {
            float4x4_inverse.TestFunction testFunction = float4x4_inverse.MonoTestFunction;
            var args = new float4x4_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float4x4_inverse_burst()
        {
            FunctionPointer<float4x4_inverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4x4_inverse.TestFunction>(float4x4_inverse.BurstTestFunction);
            var args = new float4x4_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class float3x3_inverse
        {
            public struct Arguments
            {
                public float3x3 m1;
                public float3x3 m2;

                public void Init()
                {
                    m1 = float3x3.identity;
                    m2 = float3x3.identity;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1 = math.inverse(args.m2);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float3x3_inverse_mono()
        {
            float3x3_inverse.TestFunction testFunction = float3x3_inverse.MonoTestFunction;
            var args = new float3x3_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float3x3_inverse_burst()
        {
            FunctionPointer<float3x3_inverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float3x3_inverse.TestFunction>(float3x3_inverse.BurstTestFunction);
            var args = new float3x3_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class float2x2_inverse
        {
            public struct Arguments
            {
                public float2x2 m1;
                public float2x2 m2;

                public void Init()
                {
                    m1 = float2x2.identity;
                    m2 = float2x2.identity;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1 = math.inverse(args.m2);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float2x2_inverse_mono()
        {
            float2x2_inverse.TestFunction testFunction = float2x2_inverse.MonoTestFunction;
            var args = new float2x2_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float2x2_inverse_burst()
        {
            FunctionPointer<float2x2_inverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float2x2_inverse.TestFunction>(float2x2_inverse.BurstTestFunction);
            var args = new float2x2_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class double4x4_inverse
        {
            public struct Arguments
            {
                public double4x4 m1;
                public double4x4 m2;

                public void Init()
                {
                    m1 = double4x4.identity;
                    m2 = double4x4.identity;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1 = math.inverse(args.m2);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void double4x4_inverse_mono()
        {
            double4x4_inverse.TestFunction testFunction = double4x4_inverse.MonoTestFunction;
            var args = new double4x4_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void double4x4_inverse_burst()
        {
            FunctionPointer<double4x4_inverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<double4x4_inverse.TestFunction>(double4x4_inverse.BurstTestFunction);
            var args = new double4x4_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class double3x3_inverse
        {
            public struct Arguments
            {
                public double3x3 m1;
                public double3x3 m2;

                public void Init()
                {
                    m1 = double3x3.identity;
                    m2 = double3x3.identity;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1 = math.inverse(args.m2);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void double3x3_inverse_mono()
        {
            double3x3_inverse.TestFunction testFunction = double3x3_inverse.MonoTestFunction;
            var args = new double3x3_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void double3x3_inverse_burst()
        {
            FunctionPointer<double3x3_inverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<double3x3_inverse.TestFunction>(double3x3_inverse.BurstTestFunction);
            var args = new double3x3_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class double2x2_inverse
        {
            public struct Arguments
            {
                public double2x2 m1;
                public double2x2 m2;

                public void Init()
                {
                    m1 = double2x2.identity;
                    m2 = double2x2.identity;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1 = math.inverse(args.m2);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void double2x2_inverse_mono()
        {
            double2x2_inverse.TestFunction testFunction = double2x2_inverse.MonoTestFunction;
            var args = new double2x2_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void double2x2_inverse_burst()
        {
            FunctionPointer<double2x2_inverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<double2x2_inverse.TestFunction>(double2x2_inverse.BurstTestFunction);
            var args = new double2x2_inverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
    }
}
