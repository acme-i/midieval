using System;

namespace Sanford.Multimedia.Midi
{
    public abstract class MidiEventArgsBase : EventArgs
    {
        /// <summary>
        /// Delta samples when the event should be processed in the next audio buffer.
        /// Leave at 0 for realtime input to play as fast as possible.
        /// Set to the desired sample in the next buffer if you play a midi sequence synchronized to the audio callback
        /// </summary>
        public int DeltaFrames;
    }
}