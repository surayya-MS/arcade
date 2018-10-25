// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.DotNet.DarcLib
{
    public class DependencyDetail
    {
        public string Branch { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string RepoUri { get; set; }

        public string Commit { get; set; }

        public override int GetHashCode()
        {
            return (RepoUri + Name + Commit).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var item = obj as DependencyDetail;

            if (item == null)
            {
                return false;
            }

            return RepoUri == item.RepoUri &&
                Name == item.Name;
        }
    }
}
