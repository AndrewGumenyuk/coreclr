// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.IO
{
    /*
     * Thrown when trying to access a directory that doesn't exist on disk.
     * From COM Interop, this exception is thrown for 2 HRESULTS: 
     * the Win32 errorcode-as-HRESULT ERROR_PATH_NOT_FOUND (0x80070003) 
     * and STG_E_PATHNOTFOUND (0x80030003).
     */
    public class DirectoryNotFoundException : IOException
    {
        public DirectoryNotFoundException()
            : base(SR.Arg_DirectoryNotFoundException)
        {
            HResult = __HResults.COR_E_DIRECTORYNOTFOUND;
        }

        public DirectoryNotFoundException(string message)
            : base(message)
        {
            HResult = __HResults.COR_E_DIRECTORYNOTFOUND;
        }

        public DirectoryNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
            HResult = __HResults.COR_E_DIRECTORYNOTFOUND;
        }

        protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            throw new PlatformNotSupportedException();
        }
    }
}
