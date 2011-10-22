﻿/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalMpq;

namespace Mooege.Common.Extensions
{
    public static class MpqFileStreamExtensions
    {
        public static int ReadInt32(this MpqFileStream stream)
        {
            var buffer = new byte[4];
            int result = stream.Read(buffer, 0, 4);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static float ReadFloat(this MpqFileStream stream)
        {
            var buffer = new byte[4];
            int result = stream.Read(buffer, 0, 4);
            return BitConverter.ToSingle(buffer, 0);
        }

        public static Int16 ReadInt16(this MpqFileStream stream)
        {
            var buffer = new byte[2];
            int result = stream.Read(buffer, 0, 2);
            return BitConverter.ToInt16(buffer, 0);
        }
        public static byte Read8bits(this MpqFileStream stream)
        {
            var buffer = new byte[1];
            int result = stream.Read(buffer, 0, 1);
            return buffer[0];
        }
    }
}
