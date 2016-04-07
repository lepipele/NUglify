// AtRules.cs
//
// Copyright 2010 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using NUnit.Framework;

namespace CssUnitTest
{
    /// <summary>
    /// Summary description for AtRules
    /// </summary>
    [TestFixture]
    public class EmbeddedAspNetBlock
    {
        [Test]
        public void TopLevel()
        {
            TestHelper.Instance.RunTest("-aspnet:true");
        }

        [Test]
        public void StringWithBlock()
        {
            TestHelper.Instance.RunTest("-aspnet:Y");
        }
    }
}
