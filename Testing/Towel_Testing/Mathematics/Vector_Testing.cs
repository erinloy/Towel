﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Towel.Mathematics;

namespace Towel_Testing.Mathematics
{
    [TestClass]
    public class Vector_Testing
    {
        [TestMethod]
        public void Negate()
        {
            {
                Vector<int> a = new Vector<int>(1, 2, 3);
                Assert.IsTrue(-a == new Vector<int>(-1, -2, -3));
            }
            {
                Vector<float> a = new Vector<float>(1f, 2f, 3f);
                Assert.IsTrue(-a == new Vector<float>(-1f, -2f, -3f));
            }
            {
                Vector<double> a = new Vector<double>(1d, 2d, 3d);
                Assert.IsTrue(-a == new Vector<double>(-1d, -2d, -3d));
            }
            {
                Vector<decimal> a = new Vector<decimal>(1m, 2m, 3m);
                Assert.IsTrue(-a == new Vector<decimal>(-1m, -2m, -3m));
            }
        }

        [TestMethod]
        public void Add()
        {
            {
                Vector<int> a = new Vector<int>(1, 2, 3);
                Vector<int> b = new Vector<int>(1, 2, 3);
                Assert.IsTrue(a + b == new Vector<int>(2, 4, 6));
            }
            {
                Vector<int> a = new Vector<int>(-1, -2, -3);
                Vector<int> b = new Vector<int>(-1, -2, -3);
                Assert.IsTrue(a + b == new Vector<int>(-2, -4, -6));
            }
            {
                Vector<float> a = new Vector<float>(1f, 2f, 3f);
                Vector<float> b = new Vector<float>(1f, 2f, 3f);
                Assert.IsTrue(a + b == new Vector<float>(2f, 4f, 6f));
            }
            {
                Vector<float> a = new Vector<float>(-1f, -2f, -3f);
                Vector<float> b = new Vector<float>(-1f, -2f, -3f);
                Assert.IsTrue(a + b == new Vector<float>(-2f, -4f, -6f));
            }
            {
                Vector<double> a = new Vector<double>(1d, 2d, 3d);
                Vector<double> b = new Vector<double>(1d, 2d, 3d);
                Assert.IsTrue(a + b == new Vector<double>(2d, 4d, 6d));
            }
            {
                Vector<double> a = new Vector<double>(-1d, -2d, -3d);
                Vector<double> b = new Vector<double>(-1d, -2d, -3d);
                Assert.IsTrue(a + b == new Vector<double>(-2d, -4d, -6d));
            }
            {
                Vector<decimal> a = new Vector<decimal>(1m, 2m, 3m);
                Vector<decimal> b = new Vector<decimal>(1m, 2m, 3m);
                Assert.IsTrue(a + b == new Vector<decimal>(2m, 4m, 6m));
            }
            {
                Vector<decimal> a = new Vector<decimal>(-1m, -2m, -3m);
                Vector<decimal> b = new Vector<decimal>(-1m, -2m, -3m);
                Assert.IsTrue(a + b == new Vector<decimal>(-2m, -4m, -6m));
            }
        }

        [TestMethod]
        public void Subtract()
        {
            {
                Vector<int> a = new Vector<int>(1, 2, 3);
                Vector<int> b = new Vector<int>(-1, -2, -3);
                Assert.IsTrue(a - b == new Vector<int>(2, 4, 6));
            }
            {
                Vector<int> a = new Vector<int>(-1, -2, -3);
                Vector<int> b = new Vector<int>(1, 2, 3);
                Assert.IsTrue(a - b == new Vector<int>(-2, -4, -6));
            }
            {
                Vector<float> a = new Vector<float>(1f, 2f, 3f);
                Vector<float> b = new Vector<float>(-1f, -2f, -3f);
                Assert.IsTrue(a - b == new Vector<float>(2f, 4f, 6f));
            }
            {
                Vector<float> a = new Vector<float>(-1f, -2f, -3f);
                Vector<float> b = new Vector<float>(1f, 2f, 3f);
                Assert.IsTrue(a - b == new Vector<float>(-2f, -4f, -6f));
            }
            {
                Vector<double> a = new Vector<double>(1d, 2d, 3d);
                Vector<double> b = new Vector<double>(-1d, -2d, -3d);
                Assert.IsTrue(a - b == new Vector<double>(2d, 4d, 6d));
            }
            {
                Vector<double> a = new Vector<double>(-1d, -2d, -3d);
                Vector<double> b = new Vector<double>(1d, 2d, 3d);
                Assert.IsTrue(a - b == new Vector<double>(-2d, -4d, -6d));
            }
            {
                Vector<decimal> a = new Vector<decimal>(1m, 2m, 3m);
                Vector<decimal> b = new Vector<decimal>(-1m, -2m, -3m);
                Assert.IsTrue(a - b == new Vector<decimal>(2m, 4m, 6m));
            }
            {
                Vector<decimal> a = new Vector<decimal>(-1m, -2m, -3m);
                Vector<decimal> b = new Vector<decimal>(1m, 2m, 3m);
                Assert.IsTrue(a - b == new Vector<decimal>(-2m, -4m, -6m));
            }
        }

        [TestMethod]
        public void Multiply()
        {
            {
                Vector<int> a = new Vector<int>(1, 2, 3);
                Assert.IsTrue(a * 2 == new Vector<int>(2, 4, 6));
            }
            {
                Vector<int> a = new Vector<int>(1, 2, 3);
                Assert.IsTrue(a * -2 == new Vector<int>(-2, -4, -6));
            }
            {
                Vector<float> a = new Vector<float>(1f, 2f, 3f);
                Assert.IsTrue(a * 2f == new Vector<float>(2f, 4f, 6f));
            }
            {
                Vector<float> a = new Vector<float>(1f, 2f, 3f);
                Assert.IsTrue(a * -2f == new Vector<float>(-2f, -4f, -6f));
            }
            {
                Vector<double> a = new Vector<double>(1d, 2d, 3d);
                Assert.IsTrue(a * 2d == new Vector<double>(2d, 4d, 6d));
            }
            {
                Vector<double> a = new Vector<double>(1d, 2d, 3d);
                Assert.IsTrue(a * -2d == new Vector<double>(-2d, -4d, -6d));
            }
            {
                Vector<decimal> a = new Vector<decimal>(1m, 2m, 3m);
                Assert.IsTrue(a * 2m == new Vector<decimal>(2m, 4m, 6m));
            }
            {
                Vector<decimal> a = new Vector<decimal>(1m, 2m, 3m);
                Assert.IsTrue(a * -2m == new Vector<decimal>(-2m, -4m, -6m));
            }
        }
        
        [TestMethod]
        public void Divide()
        {
            {
                Vector<int> a = new Vector<int>(2, 4, 6);
                Assert.IsTrue(a / 2 == new Vector<int>(1, 2, 3));
            }
            {
                Vector<int> a = new Vector<int>(2, 4, 6);
                Assert.IsTrue(a / -2 == new Vector<int>(-1, -2, -3));
            }
            {
                Vector<float> a = new Vector<float>(2f, 4f, 6f);
                Assert.IsTrue(a / 2f == new Vector<float>(1f, 2f, 3f));
            }
            {
                Vector<float> a = new Vector<float>(2f, 4f, 6f);
                Assert.IsTrue(a / -2f == new Vector<float>(-1f, -2f, -3f));
            }
            {
                Vector<double> a = new Vector<double>(2d, 4d, 6d);
                Assert.IsTrue(a / 2d == new Vector<double>(1d, 2d, 3d));
            }
            {
                Vector<double> a = new Vector<double>(2d, 4d, 6d);
                Assert.IsTrue(a / -2d == new Vector<double>(-1d, -2d, -3d));
            }
            {
                Vector<decimal> a = new Vector<decimal>(2m, 4m, 6m);
                Assert.IsTrue(a / 2m == new Vector<decimal>(1m, 2m, 3m));
            }
            {
                Vector<decimal> a = new Vector<decimal>(2m, 4m, 6m);
                Assert.IsTrue(a / -2m == new Vector<decimal>(-1m, -2m, -3m));
            }
        }

        [TestMethod]
        public void Magnitude()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void MagnitudeSquared()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void CrossProduct()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void DotProduct()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void Normalize()
        {
            {
                Vector<float> a = new Vector<float>(2f, 2f, 2f, 2f);
                Assert.IsTrue(a.Normalize() == new Vector<float>(2f / 4f, 2f / 4f, 2f / 4f, 2f / 4f));
            }
            {
                Vector<double> a = new Vector<double>(2d, 2d, 2d, 2d);
                Assert.IsTrue(a.Normalize() == new Vector<double>(2d / 4d, 2d / 4d, 2d / 4d, 2d / 4d));
            }
            {
                Vector<decimal> a = new Vector<decimal>(2m, 2m, 2m, 2m);
                Assert.IsTrue(a.Normalize() == new Vector<decimal>(2m / 4m, 2m / 4m, 2m / 4m, 2m / 4m));
            }
        }

        [TestMethod]
        public void Angle()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void RotateBy()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void LinearInterpolation()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void SphereicalInterpolation()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void BarycentricInterpolation()
        {
            Assert.Inconclusive("Test Not Implemented");
        }

        [TestMethod]
        public void Equal()
        {
            {
                Vector<int> a = new Vector<int>(1, 2, 3);
                Vector<int> b = new Vector<int>(1, 2, 3);
                Assert.IsTrue(a == b);
            }
            {
                Vector<float> a = new Vector<float>(1f, 2f, 3f);
                Vector<float> b = new Vector<float>(1f, 2f, 3f);
                Assert.IsTrue(a == b);
            }
            {
                Vector<double> a = new Vector<double>(1d, 2d, 3d);
                Vector<double> b = new Vector<double>(1d, 2d, 3d);
                Assert.IsTrue(a == b);
            }
            {
                Vector<decimal> a = new Vector<decimal>(1m, 2m, 3m);
                Vector<decimal> b = new Vector<decimal>(1m, 2m, 3m);
                Assert.IsTrue(a == b);
            }
        }

        [TestMethod]
        public void Equal_leniency()
        {
            Assert.Inconclusive("Test Not Implemented");
        }
    }
}
