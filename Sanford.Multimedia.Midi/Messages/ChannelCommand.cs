﻿#region License

/* Copyright (c) 2005 Leslie Sanford
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy 
 * of this software and associated documentation files (the "Software"), to 
 * deal in the Software without restriction, including without limitation the 
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
 * sell copies of the Software, and to permit persons to whom the Software is 
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software. 
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 * THE SOFTWARE.
 */

#endregion

#region Contact

/*
 * Leslie Sanford
 * Email: jabberdabber@hotmail.com
 */

#endregion

namespace Sanford.Multimedia.Midi
{
    /// <summary>
    /// Defines constants for ChannelMessage types.
    /// </summary>
    public enum ChannelCommand 
    {
        /// <summary>
        /// Represents the note-off command type.
        /// </summary>
        NoteOff = 0x80,

        /// <summary>
        /// Represents the note-on command type.
        /// </summary>
        NoteOn = 0x90,

        /// <summary>
        /// Represents the poly pressure (aftertouch) command type.
        /// </summary>
        PolyPressure = 0xA0,

        /// <summary>
        /// Represents the controller command type.
        /// </summary>
        Controller = 0xB0,  
  
        /// <summary>
        /// Represents the program change command type.
        /// </summary>
        ProgramChange = 0xC0,

        /// <summary>
        /// Represents the channel pressure (aftertouch) command 
        /// type.
        /// </summary>
        ChannelPressure = 0xD0,   
     
        /// <summary>
        /// Represents the pitch wheel command type.
        /// </summary>
        PitchWheel = 0xE0
    }
}