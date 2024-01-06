#region License

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
    /// Represents MetaMessage types.
    /// </summary>
    public enum MetaType
    {
        /// <summary>
        /// Represents sequencer number type.
        /// </summary>
        SequenceNumber,

        /// <summary>
        /// Represents the text type.
        /// </summary>
        Text,

        /// <summary>
        /// Represents the copyright type.
        /// </summary>
        Copyright,

        /// <summary>
        /// Represents the track name type.
        /// </summary>
        TrackName,

        /// <summary>
        /// Represents the instrument name type.
        /// </summary>
        InstrumentName,

        /// <summary>
        /// Represents the lyric type.
        /// </summary>
        Lyric,

        /// <summary>
        /// Represents the marker type.
        /// </summary>
        Marker,

        /// <summary>
        /// Represents the cue point type.
        /// </summary>
        CuePoint,

        /// <summary>
        /// Represents the program name type.
        /// </summary>
        ProgramName,

        /// <summary>
        /// Represents the device name type.
        /// </summary>
        DeviceName,

        /// <summary>
        /// Represents then end of track type.
        /// </summary>
        EndOfTrack = 0x2F,

        /// <summary>
        /// Represents the tempo type.
        /// </summary>
        Tempo = 0x51,

        /// <summary>
        /// Represents the Smpte offset type.
        /// </summary>
        SmpteOffset = 0x54,

        /// <summary>
        /// Represents the time signature type.
        /// </summary>
        TimeSignature = 0x58,

        /// <summary>
        /// Represents the key signature type.
        /// </summary>
        KeySignature,

        /// <summary>
        /// Represents the proprietary event type.
        /// </summary>
        ProprietaryEvent = 0x7F
    }
}
