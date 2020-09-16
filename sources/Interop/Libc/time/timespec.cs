// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop
{
    public partial struct timespec
    {
        [NativeTypeName("__time_t")]
        public nint tv_sec;

        [NativeTypeName("__syscall_slong_t")]
        public nint tv_nsec;
    }
}
