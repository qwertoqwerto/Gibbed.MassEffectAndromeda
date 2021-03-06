﻿/* Copyright (c) 2017 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

namespace Gibbed.Frostbite3.Common.DbObject
{
    public enum ValueType : byte
    {
        // ReSharper disable InconsistentNaming
        Invalid = 0,
        Array = 1,
        Object = 2,
        Bool = 6,
        String = 7,
        Int32 = 8,
        Int64 = 9,
        Float64 = 12,
        Guid = 15,
        SHA1 = 16,
        Bytes = 19,
        // ReSharper restore InconsistentNaming
    }
}
